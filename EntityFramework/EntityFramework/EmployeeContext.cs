using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    internal class EmployeeContext : DbContext

    {
        private readonly string connectionString;

        public EmployeeContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Employee> Employees{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
