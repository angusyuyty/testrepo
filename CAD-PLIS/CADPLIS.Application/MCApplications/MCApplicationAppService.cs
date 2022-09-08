using CADPLIS.Application.Contracts.MCApplications;
using CADPLIS.Domain.MCApplications;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using CADPLIS.Common.consts;

namespace CADPLIS.Application.MCApplications
{
    public class MCApplicationAppService : IMCApplicationAppService
    {
        private readonly IMCApplicationRepository _mCApplicationRepository;
        private readonly PlisDbcontext _plisDbcontext;

        public MCApplicationAppService(IMCApplicationRepository mCApplicationRepository, PlisDbcontext plisDbcontext)
        {
            _mCApplicationRepository = mCApplicationRepository;
            _plisDbcontext = plisDbcontext;
        }
        //public async Task<MCApplicationDto> GetPageListSavedAsDraftAsync(int pageSize, int pageIndex, int applicationNo, string applicationStatus,string applicantUserId,string applicationType)
        //{ 

        //}
        public async Task<int> GetSavedAsDraftCountAsync(string currentUserId)
        {
            string sql = string.Format(@"select * from PLIS_TO_DO_LIST a left join PLIS_MC_APPLICATION b on a.application_no = b.application_no				
                                        left join plis_user u on b.applicant_user_id = u.[user_id]
                                        left join plis_acct ac on u.[uid] = ac.[uid]
                                        Where a.category = 'MC' and a.[status] = 'Pending'
                                        and workflow_status_to in ('IAME-Drafted DCA153 by Applicant', 'IAMA-Drafted DCA153 by Applicant', 'RAME-Drafted DCA153 by Applicant')
                                        and b.applicant_user_id = @userId");
            //var c= await _plisDbcontext.Database.GetDbConnection().ExecuteScalarAsync<int>(sql,new { userId = currentUserId });
            return await _mCApplicationRepository.GetCount(sql,new { userId = currentUserId });
        }
        public async Task<int> GetSubmitCountAsync(string currentUserId)
        {
            string sql = string.Format(@"select * from PLIS_TO_DO_LIST a 				
                                        left join PLIS_MC_APPLICATION b on a.application_no = b.application_no				
                                        left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 				
                                        left join plis_user u on b.applicant_user_id = u.[user_id]				
                                        left join plis_acct ac on u.[uid] = ac.[uid]				
                                        Where a.category = 'MC' 				
	                                        and (((a.status = 'Done' and a.workflow_status_to = 'IAME-Drafted DCA153 by Applicant'))			
	                                        or ((a.status = 'Done' and a.workflow_status_to = 'IAMA-Drafted DCA153 by Applicant'))			
	                                        or ((a.status = 'Done' and a.workflow_status_to = 'RAME-Drafted DCA153 by Applicant'))			
	                                        or ((a.status = 'Done' and a.workflow_status_to = 'RAMA-Drafted DCA153 by Applicant')))			
	                                        and b.applicant_user_id =  @userId");
            return await _mCApplicationRepository.GetCount(sql,new { userId = currentUserId });
        }
        public async Task<int> GetActionRequiredCountAsync(string currentUserId)
        {
            string sql = string.Format(@"select * from PLIS_TO_DO_LIST a left join PLIS_MC_APPLICATION b on a.application_no = b.application_no				
                                        left join plis_user u on b.applicant_user_id = u.[user_id]				
                                        left join plis_acct ac on u.[uid] = ac.[uid]				
                                        Where a.category = 'MC' and a.status = 'Pending' 				
	                                        and a.workflow_status_to in ('IAME-Request Applicant Fill In DCA153','IAMA-Request Applicant Fill In DCA153',
                                                                         'RAME-Request Applicant Fill In DCA153','RAMA-Request Applicant Fill In DCA153',
                                                                          'UNFIT-Request applicant append information','PS-Completed')			
	                                        and b.applicant_user_id = @userId");
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetValidCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.Applicant)
            {
                sql = string.Format(@"select * from PLIS_MC_APPLICATION m 					
                                        left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
                                        left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
                                        left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
                                        left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
                                        left join PLIS_STATUS e on m.application_status = e.status_id 					
                                        left join plis_acct ac on b.[uid] = ac.[uid]					
                                        where d.[expiry_date] <= convert(varchar(12),getdate(), 111) and m.application_type = 'MC Application'					
	                                        and e.status_type = 'Valid'				
	                                        and m.applicant_user_id =  @userId				
	                                        and not exists(Select 1 from  PLIS_MC_APPLICATION m 				
					                                        left join PLIS_MC_NOTIFICATION_UNFITNESS a on m.application_no = a.application_no 
					                                        left join PLIS_STATUS e on m.application_status = e.status_id 
					                                        where m.application_type in ('Notification Unfitness') and m.application_status = 'Suspend')
	                                        and not exists(Select 1 from  PLIS_MC_APPLICATION m 				
					                                        left join PLIS_MC_NOTIFICATION_UNFITNESS a on m.application_no = a.application_no 
					                                        left join PLIS_STATUS e on m.application_status = e.status_id 
					                                        where m.application_type in ('Provisional Suspension') and m.application_status = 'Suspend')");
            }
            else if (roleId == RoleConsts.Administrator)
            {
                sql = string.Format(@"select * from PLIS_MC_APPLICATION m 					
                                    left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
                                    left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
                                    left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
                                    left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
                                    left join PLIS_STATUS e on m.application_status = e.status_id 					
                                    left join plis_acct ac on b.[uid] = ac.[uid]					
                                    where d.[expiry_date] <= convert(varchar(12),getdate(), 111) and m.application_type = 'MC Application'					
	                                    and e.status_type = 'Valid'				
	                                    and a.ame_user_id in (select [user_id] from PLIS_USER where corp_admin = @userId) 				
	                                    and not exists(Select 1 from  PLIS_MC_APPLICATION m 				
					                                    left join PLIS_MC_NOTIFICATION_UNFITNESS a on m.application_no = a.application_no 
					                                    left join PLIS_STATUS e on m.application_status = e.status_id 
					                                    where m.application_type in ('Notification Unfitness') and m.application_status = 'Suspend')
	                                    and not exists(Select 1 from  PLIS_MC_APPLICATION m 				
					                                    left join PLIS_MC_NOTIFICATION_UNFITNESS a on m.application_no = a.application_no 
					                                    left join PLIS_STATUS e on m.application_status = e.status_id 
					                                    where m.application_type in ('Provisional Suspension') and m.application_status = 'Suspend')");

            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetExpireIn1MonthCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.Applicant)
            {
                sql = string.Format(@"select * from PLIS_MC_APPLICATION m 					
                                        left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
                                        left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
                                        left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
                                        left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
                                        left join PLIS_STATUS e on m.application_status = e.status_id 					
                                        left join plis_acct ac on b.[uid] = ac.[uid]					
                                        where d.[expiry_date] <= convert(varchar(12),getdate(), 111) 					
	                                        and d.[expiry_date] >= DATEADD(month, 1, convert(varchar(12),getdate(), 111))				
	                                        and m.application_type = 'MC Application'				
	                                        and e.status_type = 'Valid'				
	                                        and m.applicant_user_id = @userId");
            }
            else if (roleId == RoleConsts.Administrator)
            {
                sql = string.Format(@"select * from PLIS_MC_APPLICATION m 					
                                        left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
                                        left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
                                        left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
                                        left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
                                        left join PLIS_STATUS e on m.application_status = e.status_id 					
                                        left join plis_acct ac on b.[uid] = ac.[uid]					
                                        where d.[expiry_date] <= convert(varchar(12),getdate(), 111) 					
	                                        and d.[expiry_date] >= DATEADD(month, 1, convert(varchar(12),getdate(), 111))				
	                                        and m.application_type = 'MC Application'				
	                                        and e.status_type = 'Valid'				
	                                        and a.ame_user_id in (select [user_id] from PLIS_USER where corp_admin = @userId)");
            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetExpiredCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.Applicant)
            {
                sql = string.Format(@"select * from PLIS_MC_APPLICATION m 					
                                        left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
                                        left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
                                        left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
                                        left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
                                        left join PLIS_STATUS e on m.application_status = e.status_id 					
                                        left join plis_acct ac on b.[uid] = ac.[uid]					
                                        where d.[expiry_date] > convert(varchar(12),getdate(), 111) 					
	                                        and m.application_type = 'MC Application'				
	                                        and e.status_type = 'Valid'				
	                                        and m.applicant_user_id = @userId");
            }
            else if (roleId==RoleConsts.Administrator)
            {
                sql = string.Format(@"select * from PLIS_MC_APPLICATION m 					
                                    left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
                                    left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
                                    left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
                                    left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
                                    left join PLIS_STATUS e on m.application_status = e.status_id 					
                                    left join plis_acct ac on b.[uid] = ac.[uid]					
                                    where d.[expiry_date] > convert(varchar(12),getdate(), 111) 					
	                                    and m.application_type = 'MC Application'				
	                                    and e.status_type = 'Valid'				
	                                    and a.ame_user_id in (select [user_id] from PLIS_USER where corp_admin = @userId )");
            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetApplicantsCountAsync(string currentUserId)
        {
             string   sql = string.Format(@"select * from PLIS_MC_APPLICATION m 				
	                                        left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 			
	                                        left join PLIS_MC_NOTIFICATION_UNFITNESS nu on m.application_no = nu.application_no			
	                                        left join PLIS_MC_PROVISIONAL_SUSPENSION ps on m.application_no = ps.application_no			
	                                        left join PLIS_User b on (m.applicant_user_id =  b.[user_id] or m.applicant_user_id =  b.[user_id] or m.applicant_user_id =  b.[user_id]) 			
	                                        left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no			
	                                        left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no			
	                                        left join PLIS_STATUS e on m.application_status = e.status_id 			
	                                        left join plis_acct ac on b.[uid] = ac.[uid]			
	                                        where a.ame_user_id in (select [user_id] from PLIS_USER where corp_admin = @userId)");
            
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetSuspendedCountAsync(string currentUserId)
        {
            string sql = string.Format(@"select * from PLIS_MC_APPLICATION m 						
	                                    left join PLIS_MC_MEDREPORTFORM a on m.application_no = a.application_no 					
	                                    left join PLIS_User b on m.applicant_user_id =  b.[user_id]					
	                                    left join PLIS_MC_MEDICAL_CERTIFICATE c on a.application_no = c.application_no					
	                                    left join PLIS_MC_MED_CERTIFICATE_EXPIRY d on c.application_no = d.application_no					
	                                    left join PLIS_STATUS e on m.application_status = e.status_id 					
	                                    left join plis_acct ac on b.[uid] = ac.[uid]					
	                                    where d.[expiry_date] <= convert(varchar(12),getdate(), 111) and m.application_type = 'MC Application'					
		                                    and e.status_type = 'Valid'				
		                                    and a.ame_user_id in (select [user_id] from PLIS_USER where corp_admin = @userId) 				
		                                    and (exists(Select 1 from  PLIS_MC_APPLICATION m 				
						                                    left join PLIS_MC_NOTIFICATION_UNFITNESS a on m.application_no = a.application_no 
						                                    left join PLIS_STATUS e on m.application_status = e.status_id 
						                                    where m.application_type in ('Notification Unfitness') and m.application_status = 'Suspend')
		                                    or exists(Select 1 from  PLIS_MC_APPLICATION m 				
						                                    left join PLIS_MC_NOTIFICATION_UNFITNESS a on m.application_no = a.application_no 
						                                    left join PLIS_STATUS e on m.application_status = e.status_id 
						                                    where m.application_type in ('Provisional Suspension') and m.application_status = 'Suspend'))");

            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetOutstandingCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.AMA)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                        left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                        left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                        left join plis_user u on b.applicant_user_id = u.[user_id]					
                                        left join plis_acct ac on u.[uid] = ac.[uid]					
                                        Where a.category = 'MC' and a.status = 'Pending' 					
	                                        and a.workflow_status_to in ('IAME-Seek AMA reply','RAME-Seek AMA reply')				
	                                        and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            else if (roleId == RoleConsts.AME)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                    left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                    left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                    left join plis_user u on b.applicant_user_id = u.[user_id]					
                                    left join plis_acct ac on u.[uid] = ac.[uid]					
                                    Where a.category = 'MC' and a.status = 'Pending' 					
	                                    and a.workflow_status_to in ('IAME-Confirmed booking','IAME-Incomplete information','IAME-Unfit to Applicant','RAME-Confirmed booking','RAME-Incomplete information','RAME-Unfit to Applicant','RAMA-Confirmed booking','RAMA-AME Assessment')				
	                                    and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            else if (roleId == RoleConsts.AME_AMA)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                    left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                    left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                    left join plis_user u on b.applicant_user_id = u.[user_id]					
                                    left join plis_acct ac on u.[uid] = ac.[uid]					
                                    Where a.category = 'MC' and a.status = 'Pending' 					
	                                    and a.workflow_status_to in ('IAMA-Confirmed booking','IAMA-AME Assessment','RAMA-Confirmed booking','RAMA-AME Assessment')				
	                                    and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetSubmittedCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.AMA)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                        left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                        left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                        left join plis_user u on b.applicant_user_id = u.[user_id]					
                                        left join plis_acct ac on u.[uid] = ac.[uid]					
                                        Where a.category = 'MC' and a.status = 'Done' 					
	                                        and a.workflow_status_to in ('IAME-Seek AMA reply','RAME-Seek AMA reply')				
	                                        and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            else if (roleId == RoleConsts.AME)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
	                                left join PLIS_MC_APPLICATION b on a.application_no = b.application_no				
	                                left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 				
	                                left join plis_user u on b.applicant_user_id = u.[user_id]				
	                                left join plis_acct ac on u.[uid] = ac.[uid]				
	                                Where a.category = 'MC' 				
		                                and (((a.status = 'Done' and a.workflow_status_to = 'IAME-Confirmed booking')			
		                                and (a.status = 'Done' and a.workflow_status_to = 'IAME-Incomplete information')			
		                                and (a.status = 'Done' and a.workflow_status_to = 'IAME-Unfit to Applicant'))			
		                                or ((a.status = 'Done' and a.workflow_status_to = 'RAME-Confirmed booking')			
		                                and (a.status = 'Done' and a.workflow_status_to = 'RAME-Incomplete information')			
		                                and (a.status = 'Done' and a.workflow_status_to = 'RAME-Unfit to Applicant'))			
		                                or ((a.status = 'Done' and a.workflow_status_to = 'RAMA-Confirmed booking')			
		                                and (a.status = 'Done' and a.workflow_status_to = 'RAMA-AME Assessment')))			
		                                and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            else if (roleId == RoleConsts.AME_AMA)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                    left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                    left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                    left join plis_user u on b.applicant_user_id = u.[user_id]					
                                    left join plis_acct ac on u.[uid] = ac.[uid]					
                                    Where a.category = 'MC' 					
	                                    and (((a.status = 'Done' and a.workflow_status_to = 'IAMA-Confirmed booking')				
	                                    and (a.status = 'Done' and a.workflow_status_to = 'IAMA-AME Assessment'))				
	                                    or ((a.status = 'Done' and a.workflow_status_to = 'RAMA-Confirmed booking')				
	                                    and (a.status = 'Done' and a.workflow_status_to = 'RAMA-AME Assessment')))				
	                                    and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }

        public async Task<int> GetPendingToConfirmCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.AME)
            {
                 sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                        left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                        left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                        left join plis_user u on b.applicant_user_id = u.[user_id]					
                                        left join plis_acct ac on u.[uid] = ac.[uid]					
                                        Where a.category = 'MC' and a.status = 'Pending' 					
	                                        and a.workflow_status_to in ('IAME-Verify Booking','RAME-Verify Booking')				
	                                        and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            else if (roleId == RoleConsts.AME_AMA)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                    left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                    left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                    left join plis_user u on b.applicant_user_id = u.[user_id]					
                                    left join plis_acct ac on u.[uid] = ac.[uid]					
                                    Where a.category = 'MC' and a.status = 'Pending' 					
	                                    and a.workflow_status_to in ('IAMA-Verify Booking','RAMA-Verify Booking')				
	                                    and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
        public async Task<int> GetConfirmedCountAsync(string currentUserId,string roleId)
        {
            string sql = "";
            if (roleId == RoleConsts.AME)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                        left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                        left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                        left join plis_user u on b.applicant_user_id = u.[user_id]					
                                        left join plis_acct ac on u.[uid] = ac.[uid]					
                                        Where a.category = 'MC' and a.status = 'Done' 					
	                                        and a.workflow_status_to in ('IAME-Verify Booking','RAME-Verify Booking')				
	                                        and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            else if (roleId == RoleConsts.AME_AMA)
            {
                sql = string.Format(@"select * from PLIS_TO_DO_LIST a 					
                                    left join PLIS_MC_APPLICATION b on a.application_no = b.application_no					
                                    left join PLIS_MC_MEDREPORTFORM c on b.application_no = c.application_no 					
                                    left join plis_user u on b.applicant_user_id = u.[user_id]					
                                    left join plis_acct ac on u.[uid] = ac.[uid]					
                                    Where a.category = 'MC' and a.status = 'Done' 					
	                                    and a.workflow_status_to in ('IAMA-Verify Booking','RAMA-Verify Booking')				
	                                    and (c.ame_user_id = @userId or c.ame_user_id in (select [user_id] from PLIS_USER where isnull(corp_admin,'') <> '' and corp_admin = (select top 1 corp_admin from PLIS_USER where [user_id] = @userId)))");
            }
            return await _mCApplicationRepository.GetCount(sql, new { userId = currentUserId });
        }
    }
}
