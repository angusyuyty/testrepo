using CADPLIS.Domain.Shared.ToDoLists;
using CADPLIS.Domain.ToDoLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class ToDoListEntityTypeConfiguration: IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.ToTable("PLIS_TO_DO_LIST");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();
            builder.Property(x => x.Category).HasColumnName("category").HasMaxLength(ToDoListConsts.MaxCategoryLength).IsRequired();
            builder.Property(x => x.NotificationType).HasColumnName("notification_type").HasMaxLength(ToDoListConsts.MaxNotificationTypeLength).IsRequired();
            builder.Property(x => x.NotificationDate).HasColumnName("notification_date").IsRequired();
            builder.Property(x => x.ApplicationNo).HasColumnName("application_no");
            builder.Property(x => x.WorkflowStatusFrom).HasColumnName("workflow_status_from").HasMaxLength(ToDoListConsts.MaxWorkflowStatusFromLength);
            builder.Property(x => x.WorkflowStatusTo).HasColumnName("workflow_status_to").HasMaxLength(ToDoListConsts.MaxWorkflowStatusToLength);
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(ToDoListConsts.MaxDescriptionLength).IsRequired();
            builder.Property(x => x.SendFrom).HasColumnName("send_from").HasMaxLength(ToDoListConsts.MaxSendFromLength).IsRequired();
            builder.Property(x => x.SendTo).HasColumnName("send_to").HasMaxLength(ToDoListConsts.MaxSendToLength).IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(ToDoListConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(ToDoListConsts.MaxCreatedUserRoleIdLength);
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(ToDoListConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(ToDoListConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.DueDate).HasColumnName("due_date");
            builder.Property(x => x.Status).HasColumnName("Status").HasMaxLength(ToDoListConsts.MaxStatusLength).IsRequired();

        }
    }
}
