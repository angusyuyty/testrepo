using CADPLIS.Domain.MCApplications;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.MCApplications
{
    public class MCApplicationRepository : EfBaseRepository<MCApplication>, IMCApplicationRepository
    {
        public MCApplicationRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }
        public Task<int> GetCount(string sqlstr, object param = null)
        {
            return ComSqlCount(sqlstr,param);
        }

  
        public Task<int> GetSubmitCount(string userId)
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
	                                        and b.applicant_user_id = {0}", userId);
            return ComSqlCount(sql);
        }
        public Task<int> GetActionRequiredCount(string userId)
        {
            string sql = string.Format(@"select * from PLIS_TO_DO_LIST a left join PLIS_MC_APPLICATION b on a.application_no = b.application_no				
                                        left join plis_user u on b.applicant_user_id = u.[user_id]				
                                        left join plis_acct ac on u.[uid] = ac.[uid]				
                                        Where a.category = 'MC' and a.status = 'Pending' 				
	                                        and a.workflow_status_to in (left hand side blue font in column Q)			
	                                        and b.applicant_user_id ={0}", userId);
            return ComSqlCount(sql);
        }
    }
}
