using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pagi.Core.DTOs;
using Pagi.Core.Models;
using Pagi.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TurnController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITurnService _turnService;
        public TurnController(ITurnService turnService,IMapper mapper)
        {
            _turnService = turnService;
            _mapper = mapper;
        }
       
        // GET: api/<ClientController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //return await _turnService.GetAllAsync();
            var listTurn = _turnService.GetAllAsync();
            var listTurnDto = _mapper.Map<IEnumerable<TurnDto>>(listTurn.Result);
            return  Ok(listTurnDto);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            //return _turnService.GetId(id);
            var turn =await _turnService.GetIdAsync(id);
            var turnDto = _mapper.Map<ClientDto>(turn);
            return Ok(turnDto);
        }
        // POST api/<ClientController>
        [HttpPost]
        public async Task Post([FromBody] Turn date)
        {
           await _turnService.PostAsync(date);    
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Turn value)
        {
           await _turnService.PutAsync(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
       
        public async Task Delete(int id)
        {
           await _turnService.DeleteAsync(id);
        }
    }
}
