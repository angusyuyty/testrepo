using CADPLIS.Application.Contracts.Accounts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Accounts
{
    public class EntityPermissions
    {
        private static readonly ReadOnlyCollection<EntityPermission> AllPermissions;
        static EntityPermissions()
        {
            List<EntityPermission> allPermissions = new List<EntityPermission>();
            IEnumerable<object> permissionClasses = typeof(Permissions).GetNestedTypes(BindingFlags.Static | BindingFlags.Public).Cast<TypeInfo>();
            foreach (TypeInfo permissionClass in permissionClasses)
            {
                IEnumerable<FieldInfo> permissions = permissionClass.DeclaredFields.Where(f => f.IsLiteral);
                foreach (FieldInfo permission in permissions)
                {
                    EntityPermission applicationPermission = new EntityPermission
                    {
                        Value = permission.GetValue(null).ToString(),
                        Name = permission.GetValue(null).ToString().Replace('.', ' '),
                        GroupName = permissionClass.Name
                    };

                    DisplayAttribute[] attributes = (DisplayAttribute[])permission.GetCustomAttributes(typeof(DisplayAttribute), false);

                    applicationPermission.Description = attributes != null && attributes.Length > 0 ? attributes[0].Description : applicationPermission.Name;

                    allPermissions.Add(applicationPermission);
                }
            }
            AllPermissions = allPermissions.AsReadOnly();
        }

        private IEnumerable<EntityPermission> GetAllPermission()
        {
            return AllPermissions;
        }

        public EntityPermission GetPermissionByName(string permissionName)
        {
            return GetAllPermission().Where(p => p.Name == permissionName).FirstOrDefault();
        }

        public EntityPermission GetPermissionByValue(string permissionValue)
        {
            return GetAllPermission().Where(p => p.Value == permissionValue).FirstOrDefault();
        }

        public string[] GetAllPermissionValues()
        {
            return GetAllPermission().Select(p => p.Value).ToArray();
        }

        public List<string> GetAllPermissionNames()
        {
            return GetAllPermission().Select(p => p.Name).ToList();
        }
    }
}
