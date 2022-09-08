using CADPLIS.Common;
using CADPLIS.Domain.AuditInfos;
using CADPLIS.Domain.CodeLists;
using CADPLIS.Domain.Functions;
using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.Domain.Groups;
using CADPLIS.Domain.Identity;
using CADPLIS.Domain.Logs;
using CADPLIS.Domain.MCApplications;
using CADPLIS.Domain.NavMenus;
using CADPLIS.Domain.References;
using CADPLIS.Domain.Roles;
using CADPLIS.Domain.SystemAuditLogs;
using CADPLIS.Domain.Users;
using CADPLIS.Domain.WorkFlows;
using CADPLIS.EntityFrameworkCore.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityFrameworkCore
{
    public class PlisDbcontext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public PlisDbcontext(DbContextOptions<PlisDbcontext> options) : base(options)
        {
        }
        public DbSet<AuditInfo> AuditInfos { get; set; }

        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Role> WKRoles { get; set; }
        public virtual DbSet<StructDivision> StructDivisions { get; set; }
        public virtual DbSet<Head> VHeads { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<WorkflowScheme> WorkflowSchemes { get; set; }
        public virtual DbSet<LogRecordDetail> LogRecordDetails { get; set; }

        public virtual DbSet<GroupInfo> GroupInfos { get; set; }

        public virtual DbSet<PlisNavMenu> PlisNavMenus { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<ReferenceValue> ReferenceValues { get; set; }
        public virtual DbSet<User> PlisUsers { get; set; }
        public virtual DbSet<UserRole> PlisUserRoles { get; set; }

        public virtual DbSet<RoleInfo> RoleInfos { get; set; }
        public virtual DbSet<Group> PlisGroups { get; set; }
        public virtual DbSet<UserRoleGroup> UserRoleGroups { get; set; }
        public virtual DbSet<GroupAccessibleFunction> GroupAccessibleFunctions { get; set; }
        public virtual DbSet<GeneralActionLog> GeneralActionLogs { get; set; }
        public virtual DbSet<DropDownList> DropDownLists { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<RoleLog> RoleLogs { get; set; }
        public virtual DbSet<GroupLog> GroupLogs { get; set; }
        public virtual DbSet<MCApplication> MCApplications { get; set; }
        public virtual DbSet<WorkFlowDocument> WorkFlowDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            //modelBuilder.ApplyConfiguration(new NavMenuEntityTypeConfiguration());

            modelBuilder.Entity<Employee>()
                  .HasMany(e => e.Documents)
                 .WithOne(e => e.Author)
                  .HasForeignKey(e => e.AuthorId);

            modelBuilder.Entity<Employee>()
                 .HasMany(e => e.Documents1)
                .WithOne(e => e.Manager)
                .HasForeignKey(e => e.ManagerId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeRoles)
                .WithOne(r => r.Employee)
                .HasForeignKey(r => r.EmployeeId);

            modelBuilder.Entity<Role>()
                        .HasMany(e => e.EmployeeRoles)
                        .WithOne(r => r.Role)
                        .HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<StructDivision>()
                .HasMany(e => e.StructDivision1)
                .WithOne(e => e.StructDivision2)
                .HasForeignKey(e => e.ParentId)
            ;

            modelBuilder.Entity<EmployeeRole>()
                .HasKey(x => new { x.RoleId, x.EmployeeId })
            ;

            modelBuilder.Entity<EmployeeRole>()
             .HasOne(x => x.Role).WithMany(x => x.EmployeeRoles);

            modelBuilder.Entity<Document>().Property(x => x.Sum).HasColumnType("money");


            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }

        //public override int SaveChanges()
        //{

        //    WriteEFDataLog();

        //    return base.SaveChanges();
        //}

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{

        //    WriteEFDataLog();

        //    return await base.SaveChangesAsync();
        //}

        private void WriteEFDataLog()
        {
            //The EF change entry is obtained
            var list = this.ChangeTracker.Entries().ToList();
            try
            {
                foreach (var item in list)
                {

                    #region To get the name of the table
                    string tableName = item.Metadata.GetTableName();

                    #endregion

                    switch (item.State)
                    {
                        case EntityState.Detached:

                            break;
                        case EntityState.Unchanged:

                            break;
                        case EntityState.Deleted:
                            WriteEFDeleteLog(item, tableName);
                            break;
                        case EntityState.Modified:
                            if(tableName!= "AuditInfo")
                            WriteEFUpdateLog(item, tableName);
                            break;
                        case EntityState.Added:
                            if (tableName != "AuditInfo")
                                WriteEFAddLog(item, tableName);
                            break;
                    }
                }
            }
            catch (Exception e)
            { 
            }
        }

        /// <summary>
        /// Record EF modification operation logs
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="tableName"></param>
        private void WriteEFUpdateLog(EntityEntry entry, string tableName)
        {
            var propertyList = entry.CurrentValues.Properties;
            string keyId = "";
            //PropertyEntry keyEntity = entry.Property("KeyId");
            var logID = UniqueId.Generate();
            foreach (var prop in propertyList)
            {
                PropertyEntry entity = entry.Property(prop.Name);
                if (prop.IsKey())
                    keyId+= entity.CurrentValue?.ToString()+" ";
            }

            foreach (var prop in propertyList)
            {
                PropertyEntry entity = entry.Property(prop.Name);
                string oldvalue = entry.GetDatabaseValues().GetValue<object>(prop.Name)?.ToString();
                string newvalue = entity.CurrentValue?.ToString();
                if (oldvalue != newvalue && !string.IsNullOrEmpty(oldvalue) && !string.IsNullOrEmpty(newvalue))
                {
                    string log = $"user：test，the table：{ tableName } data is modified";
                    string action = "Modified";
                    if (prop.Name == "IsDeleted" && newvalue == "True")
                    {
                        log = $"user：test，the table：{ tableName } data is deleted";
                        action = "Deleted";
                    }

                    LogRecordDetail detailModel = new LogRecordDetail();
                    detailModel.Id = UniqueId.Generate();
                    //detailModel.LogID = logID;
                    detailModel.FieldName = prop.Name;
                    detailModel.CurrentValue = newvalue;
                    detailModel.OriginalValue = oldvalue;
                    detailModel.OperationKeyID = keyId;
                    detailModel.LogOperator = "test";
                    detailModel.OperationTable = tableName;
                    detailModel.LogContent = log;
                    detailModel.OperationAction = action;
                    detailModel.CreateTime = DateTime.Now;
                    LogRecordDetails.Add(detailModel);
                }

            }
        }
        /// <summary>
        ///Record new EF operation logs
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="tableName"></param>
        private void WriteEFAddLog(EntityEntry entry, string tableName)
        {
            var propertyList = entry.CurrentValues.Properties;
            bool flag = true;
            var logID = UniqueId.Generate();
            string keyId ="";
            
            if (propertyList.Count > 0)
            {
                foreach (var prop in propertyList)
                {
                    PropertyEntry entity = entry.Property(prop.Name);
                    if (prop.IsKey())
                        keyId = entity.CurrentValue?.ToString()+" ";
                }
                foreach (var prop in propertyList)
                {
                    PropertyEntry entity = entry.Property(prop.Name);
                    string newvalue = entity.CurrentValue?.ToString();

                    if (!string.IsNullOrEmpty(newvalue))
                    {
                        string log = $"user：test，the table：{ tableName } data has been added";

                        LogRecordDetail detailModel = new LogRecordDetail();
                        detailModel.Id = UniqueId.Generate();
                        //detailModel.LogID = logID;
                        detailModel.FieldName = prop.Name;
                        detailModel.CurrentValue = newvalue;
                        detailModel.OriginalValue = "";
                        //detailModel.OperationKeyID = keyId;
                        detailModel.LogOperator = "test";
                        detailModel.OperationTable = tableName;
                        detailModel.LogContent = log;
                        detailModel.OperationAction = "Added";
                        detailModel.CreateTime = DateTime.Now;
                        LogRecordDetails.Add(detailModel);
                    }
                }
              


            }
        }

        private void WriteEFDeleteLog(EntityEntry entry, string tableName)
        {
            var propertyList = entry.CurrentValues.Properties;
            bool flag = true;
            var logID = UniqueId.Generate();
            if (propertyList.Count > 0)
            {
                foreach (var prop in propertyList)
                {
                    PropertyEntry entity = entry.Property(prop.Name);
                    string log = $"user：test，the table：{ tableName } data is deleted";
                    LogRecordDetail detailModel = new LogRecordDetail();
                    detailModel.Id = UniqueId.Generate();
                    //detailModel.LogID = logID;
                    detailModel.FieldName = prop.Name;
                    detailModel.CurrentValue = entity.CurrentValue?.ToString();
                    detailModel.OriginalValue = entity.CurrentValue?.ToString();
                    detailModel.OperationKeyID = entry.Property("Id")?.CurrentValue?.ToString();
                    detailModel.LogOperator = "test";
                    detailModel.OperationTable = tableName;
                    detailModel.LogContent = log;
                    detailModel.OperationAction = "Deleted";
                    detailModel.CreateTime = DateTime.Now;
                    LogRecordDetails.Add(detailModel);
                }



            }
        }


    }
}
