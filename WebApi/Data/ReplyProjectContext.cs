using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Models.Response;
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
                var connectionString = configuration.GetConnectionString("ReplyProjectConn");
                optionsBuilder.UseSqlServer(connectionString);
                ////var connectionString = configuration.GetConnectionString("LibLibConnString");
                //optionsBuilder.UseSqlServer();
            }


        }
        public DbSet<Cars> cars { get; set; }
    }
}
