using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace CADPLIS.Server.Helper
{
    public class RuntimeHelper
    {
        /// <summary>
        /// Get the project assembly, excluding all System assemblies (Microsoft.***, System.***, etc.), Nuget download package
        /// </summary>
        /// <returns></returns>
        public static IList<Assembly> GetAllAssemblies()
        {
            List<Assembly> list = new List<Assembly>();
            var deps = DependencyContext.Default;
            //Exclude all system assemblies, Nuget download packages
            var libs = deps.CompileLibraries.Where(lib => !lib.Serviceable && lib.Type != "package");
            foreach (var lib in libs)
            {
                try
                {
                    var assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(lib.Name));
                    list.Add(assembly);
                }
                catch (Exception ex)
                {
                    //
                }
            }
            return list;
        }

        public static Assembly GetAssembly(string assemblyName)
        {
            return GetAllAssemblies().FirstOrDefault(f => f.FullName.Contains(assemblyName));
        }

        public static IList<Type> GetAllTypes()
        {
            List<Type> list = new List<Type>();
            foreach (var assembly in GetAllAssemblies())
            {
                var typeinfos = assembly.DefinedTypes;
                foreach (var typeinfo in typeinfos)
                {
                    list.Add(typeinfo.AsType());
                }
            }
            return list;
        }

        /// <summary>
        /// Get all classes based on AssemblyName
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <returns></returns>
        public static IList<Type> GetTypesByAssembly(string assemblyName)
        {
            List<Type> list = new List<Type>();
            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(assemblyName));
            var typeinfos = assembly.DefinedTypes;
            foreach (var typeinfo in typeinfos)
            {
                list.Add(typeinfo.AsType());
            }
            return list;
        }

        public static Type GetImplementType(string typeName, Type baseInterfaceType)
        {
            return GetAllTypes().FirstOrDefault(t =>
            {
                if (t.Name == typeName && t.GetTypeInfo().GetInterfaces().Any(b => b.Name == baseInterfaceType.Name))
                {
                    var typeinfo = t.GetTypeInfo();
                    return typeinfo.IsClass && !typeinfo.IsAbstract && !typeinfo.IsGenericType;
                }
                return false;
            });
        }
    }
}
