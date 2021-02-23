using HotelForDogs.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForDogs.DataAccess
{
    public class ClientAccountContext : DbContext
    {
        public ClientAccountContext(DbContextOptions<ClientAccountContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}
