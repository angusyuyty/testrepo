using CADPLIS.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.MCApplications
{
    public interface IMCApplicationAppService
    {
        Task<int> GetSavedAsDraftCountAsync(string currentUserId);
        Task<int> GetActionRequiredCountAsync(string currentUserId);
        Task<int> GetValidCountAsync(string currentUserId, string roleId);
        Task<int> GetExpireIn1MonthCountAsync(string currentUserId, string roleId);
        Task<int> GetExpiredCountAsync(string currentUserId, string roleId);
        Task<int> GetSubmitCountAsync(string currentUserId);
        Task<int> GetApplicantsCountAsync(string currentUserId);
        Task<int> GetSuspendedCountAsync(string currentUserId);
        Task<int> GetOutstandingCountAsync(string currentUserId, string roleId);
        Task<int> GetSubmittedCountAsync(string currentUserId, string roleId);
        Task<int> GetPendingToConfirmCountAsync(string currentUserId, string roleId);
        Task<int> GetConfirmedCountAsync(string currentUserId, string roleId);
    }
}
