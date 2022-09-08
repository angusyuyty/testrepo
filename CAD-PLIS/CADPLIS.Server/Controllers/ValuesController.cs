using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common.CacheManager;
using CADPLIS.Common.Email;
using CADPLIS.Server.Application.Commands;
using CADPLIS.Server.Application.Events;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICacheService _cache;
        private INavMenuAppService _navMenuAppService;
        private IMediator _mediator;

        private EmailAccount emailAccount;
        public ValuesController(ICacheService memoryCache, INavMenuAppService navMenuAppService, IMediator mediator,IOptions<EmailAccount> options)
        {
            _cache = memoryCache;
            _navMenuAppService = navMenuAppService;
            _mediator = mediator;
            emailAccount = options.Value;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            // _mediator.Publish(new FindPasswordEvent { Email = "123@qq.com" });
           // string str = await _mediator.Send(new CreateUserCommand { Name = "123" });
           // var result = _navMenuAppService.GetByIdAsync("1");
            return await Task.FromResult(new string[] { "value1", "value2" });
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
