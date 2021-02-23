using HotelForDogs.DataAccess;
using HotelForDogs.DataAccess.Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelForDogss.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientContoller : ControllerBase
    {
        private readonly IRepository<Client> clientRepository;
        public ClientContoller(IRepository<Client> clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Client> GetAllClients() => this.clientRepository.GetAll();
        [HttpGet]
        [Route("{clientId}")]
        public Client GetClient(int clientId) => this.clientRepository.GetById(clientId);
    }
}
