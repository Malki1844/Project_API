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

    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        public ClientController(IClientService clientService,IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }
        //private static List<Client> clients=new List<Client> { new Client { Id = 1, Name = "ariel" } };
        // GET: api/<ClientController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var listClient = _clientService.GetAllAsync();
            var listClientDto = _mapper.Map<IEnumerable<ClientDto>>(listClient.Result);
            return Ok(listClientDto);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var client= await _clientService.GetIdAsync(id);
            var clientDto = _mapper.Map<ClientDto>(client);
            return  Ok(clientDto);

        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task Post([FromBody] ClientDto clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);
           await _clientService.PostAsync(client);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ClientDto value)
        {
            var client = _mapper.Map<Client>(value);

           await _clientService.PutAsync(id, client);
            
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _clientService.DeleteAsync(id);
        }
    }
}
