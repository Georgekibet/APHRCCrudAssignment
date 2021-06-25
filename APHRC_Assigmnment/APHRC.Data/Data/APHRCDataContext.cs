using System;
using System.Collections.Generic;
using System.Text;
using APHRC_Assigmnment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace APHRC.Data.Data
{
   public class APHRCDataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public APHRCDataContext(DbContextOptions<APHRCDataContext> options) : base(options)
        {

        }
    }
}
