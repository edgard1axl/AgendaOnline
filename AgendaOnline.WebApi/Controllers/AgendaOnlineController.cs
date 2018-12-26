using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaOnline.Application.Contracts;
using AgendaOnline.Application.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaOnline.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(type: typeof(object), statusCode: 200)]
    public class AgendaOnlineController : ApiController
    {
        private readonly IAgendaOnlineService _agendaOnlineService;

        public AgendaOnlineController(IAgendaOnlineService agendaOnlineService)
        {
            _agendaOnlineService = agendaOnlineService;
        }

        [HttpPost]
        [Route("save-contact")]
        public IActionResult Post([FromBody]SaveContactRequest request)
        {
            if (ModelState.IsValid)
                _agendaOnlineService.SaveContractAgendaOnline(request);

            return Ok(new
            {
                success = true,
                data = request
            });
        }

        [HttpGet]        
        public async Task<ActionResult> Get()
        {
            SaveContactRequest request = new SaveContactRequest();
            request.Contact = new Domain.Entities.Contact();
            
            

            await _agendaOnlineService.SaveContractAgendaOnline(request);

            return new string[] { "Deu", "certo" };
        }
    }
}