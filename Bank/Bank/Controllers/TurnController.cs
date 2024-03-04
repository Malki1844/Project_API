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
        //public ActionResult Get(int id)
        //{
        //    int index = _turnService.GetAll().FindIndex(c => c.Id == id);
        //    if(index == -1)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(_turnService.GetAll()[index]);

        //}
        public Turn Get(int id)
        {
           
            return _turnService.GetId(id);
        }
        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Turn date)
        {
            _turnService.Post(date);    
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn value)
        {
            _turnService.Put(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    int index = _turnService.GetAll().FindIndex(x => x.Id == id);
        //    if(index == -1)
        //    {
        //        return NotFound();
        //    }
        //    _turnService.GetAll().RemoveAt(index);
        //    return Ok();
        //}
        public void Delete(int id)
        {
            _turnService.Delete(id);
        }
    }
}
