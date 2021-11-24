using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.DTO.Response;
using Models.Models.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Data
{
    public class ReplyProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = "Server=.;Database=mertcanDb;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(connectionString);
                ////var connectionString = configuration.GetConnectionString("LibLibConnString");
                //optionsBuilder.UseSqlServer();
            }


        }
        public DbSet<Cars> cars { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Demands> demands { get; set; }
    }
}
