using CADPLIS.Application.Contracts.MCApplications;
using CADPLIS.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCApplicationController : ControllerBase
    {
        private readonly IMCApplicationAppService _mCApplicationAppService;      
        public MCApplicationController(IMCApplicationAppService mCApplicationAppService)
        {
            _mCApplicationAppService = mCApplicationAppService;
        }
        [Route("GetApplicantCount")]
        [HttpGet]
        public async Task<ApiResponse> GetApplicantCount(string roleId, string currentUserId = null)
        {
            currentUserId = User.Identity.Name;
            var savedAsDraftNum = await _mCApplicationAppService.GetSavedAsDraftCountAsync(currentUserId);
            var submitNum = await _mCApplicationAppService.GetSubmitCountAsync(currentUserId);
            var actionRequiredNum = await _mCApplicationAppService.GetActionRequiredCountAsync(currentUserId);
            var validNum = await _mCApplicationAppService.GetValidCountAsync(currentUserId, roleId);
            var expireIn1MonthNum = await _mCApplicationAppService.GetExpireIn1MonthCountAsync(currentUserId, roleId);
            var expiredNum = await _mCApplicationAppService.GetExpiredCountAsync(currentUserId, roleId);
            MCApplicationCountDto acdto = new MCApplicationCountDto() { 
                SavedAsDraftNum= savedAsDraftNum,
                SubmitNum=submitNum,
                ActionRequiredNum=actionRequiredNum,
                ValidNum=validNum,
                ExpireIn1MonthNum=expireIn1MonthNum,
                ExpiredNum=expiredNum
            };

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, acdto) ;
        }
        [Route("GetAdministratorCount")]
        [HttpGet]
        public async Task<ApiResponse> GetAdministratorCount(string roleId, string currentUserId = null)
        {
            currentUserId = User.Identity.Name;
            var suspendedNum = await _mCApplicationAppService.GetSuspendedCountAsync(currentUserId);
            var applicantsNum = await _mCApplicationAppService.GetApplicantsCountAsync(currentUserId);
            var validNum = await _mCApplicationAppService.GetValidCountAsync(currentUserId, roleId);
            var expireIn1MonthNum = await _mCApplicationAppService.GetExpireIn1MonthCountAsync(currentUserId, roleId);
            var expiredNum = await _mCApplicationAppService.GetExpiredCountAsync(currentUserId, roleId);
            MCApplicationCountDto acdto = new MCApplicationCountDto()
            {
                SuspendedNum = suspendedNum,
                ApplicantsNum = applicantsNum,
                ValidNum = validNum,
                ExpireIn1MonthNum = expireIn1MonthNum,
                ExpiredNum = expiredNum
            };
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, acdto);
        }
        [Route("GetAMACount")]
        [HttpGet]
        public async Task<ApiResponse> GetAMACount(string roleId,string currentUserId = null)
        {
            currentUserId = User.Identity.Name;
            var outstandingNum = await _mCApplicationAppService.GetOutstandingCountAsync(currentUserId,roleId);
            var submittedNum = await _mCApplicationAppService.GetSubmittedCountAsync(currentUserId,roleId);
            MCApplicationCountDto acdto = new MCApplicationCountDto()
            {
                OutstandingNum = outstandingNum,
                SubmittedNum = submittedNum
            };
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, acdto);
        }
        [Route("GetAMECount")]
        [HttpGet]
        public async Task<ApiResponse> GetAMECount(string roleId, string currentUserId = null)
        {
            currentUserId = User.Identity.Name;
            var outstandingNum = await _mCApplicationAppService.GetOutstandingCountAsync(currentUserId, roleId);
            var submittedNum = await _mCApplicationAppService.GetSubmittedCountAsync(currentUserId, roleId);
            var pendingToConfirmNum = await _mCApplicationAppService.GetPendingToConfirmCountAsync(currentUserId,roleId);
            var cnfirmedNum = await _mCApplicationAppService.GetConfirmedCountAsync(currentUserId,roleId);
            MCApplicationCountDto acdto = new MCApplicationCountDto()
            {
                OutstandingNum = outstandingNum,
                SubmittedNum = submittedNum,
                PendingToConfirmNum=pendingToConfirmNum,
                ConfirmedNum= cnfirmedNum
            };
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, acdto);
        }
    }
}
