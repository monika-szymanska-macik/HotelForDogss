using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForDogs.DataAccess
{
    class ClientAccountContextFactory : IDesignTimeDbContextFactory<ClientAccountContext>
    {
        public ClientAccountContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<ClientAccountContext>();
            optionBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=ClienAccount;Integrated Security=True; ");
            return new ClientAccountContext(optionBuilder.Options);
        }
    }
}
