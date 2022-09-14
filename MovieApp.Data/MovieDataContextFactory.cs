using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class MovieDataContextFactory : IDesignTimeDbContextFactory<MovieDataContext>
    {
        public MovieDataContext CreateDbContext(string[] args)
        {
            var stringConnection = "Host=127.0.0.1;Database=NailSonOne;Username=postgres;Password=123456";
            var optionBuilder = new DbContextOptionsBuilder<MovieDataContext>();
            optionBuilder.UseNpgsql(stringConnection);
            return new MovieDataContext(optionBuilder.Options);
        }
    }
}
