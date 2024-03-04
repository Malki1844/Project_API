using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pagi.Core.DTOs;
using Pagi.Core.Models;
using Pagi.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClerkController : ControllerBase
    {
        private readonly IClerkService _clerkService;
        private readonly IMapper _mapper;
        public ClerkController(IClerkService clerkService,IMapper mapper)
        {
            _clerkService = clerkService;
            _mapper = mapper;
        }

        // GET: api/<ClerkController>
        [HttpGet]
        public  ActionResult Get()
        {
            var listClerk = _clerkService.GetAllAsync();
            var listClerkDto = _mapper.Map<IEnumerable<ClerckDto>>(listClerk.Result);
            return Ok(listClerkDto);
           
        }

        // GET api/<ClerkController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var clerk = _clerkService.GetId(id);
            var clerkDto = _mapper.Map<ClerckDto>(clerk);
            return Ok(clerkDto);
        }

        // POST api/<ClerkController>
        [HttpPost]
        public void Post([FromBody] ClerckDto clerkDto)
        {
          var clerk = _mapper.Map<Clerk>(clerkDto);
            _clerkService.PostAsync(clerk);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClerckDto value)
        {
            var clerk=_mapper.Map<Clerk>(value);

            _clerkService.Put(id, clerk);

        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clerkService.Delete(id);
        }
    }
}
