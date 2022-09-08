using AutoMapper;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.References;
using CADPLIS.Domain;
using CADPLIS.Domain.Functions;
using CADPLIS.Domain.References;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Functions
{
    public class FunctionAppService : IFunctionAppService
    {
        private readonly IMapper _autoMapper;
        private readonly IFunctionRepository _functionRepository;
        public FunctionAppService(IMapper mapper, IFunctionRepository functionRepository)
        {
            _autoMapper = mapper;
            _functionRepository = functionRepository;
        }
        public async Task Insert(FunctionDto model)
        {
            var functionmodel = _autoMapper.Map<Function>(model);
            await _functionRepository.InsertAsync(functionmodel, true);
            model.Id = functionmodel.Id;
        }

        public async Task Update(FunctionDto model)
        {
            var dbModel = _autoMapper.Map<Function>(model);
            await _functionRepository.UpdateAsync(dbModel, true);
        }
        public async Task<FunctionDto> GetByIdAsync(int id)
        {
            var model = await _functionRepository.FindAsync(u => u.Id.Equals(id));
            var result = _autoMapper.Map<FunctionDto>(model);
            return result;
        }

        public async Task<List<FunctionDto>> GetFunctionAsync(string fid=null, string ftype=null, string fname=null)
        {
            var list = await _functionRepository.GetListAsync(fid, ftype, fname);
            if (list.Any())
            {
                var result = _autoMapper.Map<List<FunctionDto>>(list);
                return result.OrderBy(u => u.DisplaySequence).ToList();
            }
            return new List<FunctionDto>();
        }
        public async Task<Paginator<FunctionDto>> GetListBySearchAsync(int pageSize, int pageIndex, string fid, string ftype, string fname)
        {
            Paginator<FunctionDto> pageData = new Paginator<FunctionDto>(pageSize, pageIndex);
            var count = await _functionRepository.GetCountAsync(fid, ftype, fname);
            var result = await _functionRepository.GetPageListAsync(pageSize, pageIndex, fid, ftype, fname);
            pageData.pageCount = count;
            pageData.data = result.Any() ? _autoMapper.Map<List<FunctionDto>>(result) : new List<FunctionDto>(); 
            return pageData;
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _functionRepository.FindAsync(u => u.Id.Equals(id));
            if (model != null)
            {
                await _functionRepository.DeleteAsync(model, true);
            }
        }
        public async Task<FunctionDto> FunctionValidate(FunctionDto model, string action)
        {
            var result = new FunctionDto();
            if (action == "edit")
            {
                var result1 = await _functionRepository.FindAsync(u => u.FunctionId == model.FunctionId && u.FunctionType == model.FunctionType && u.Id != model.Id);
                result = _autoMapper.Map<FunctionDto>(result1);
            }
            else
            {
                var result1 = await _functionRepository.FindAsync(u => u.FunctionId == model.FunctionId && u.FunctionType == model.FunctionType && u.Id != model.Id);
                result = _autoMapper.Map<FunctionDto>(result1);
            }
            return result;
        }
    }
}
