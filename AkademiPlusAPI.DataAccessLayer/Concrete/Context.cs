﻿using AkademiPlusAPI.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusAPI.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NODIFQV\\SQLEXPRESS;initial catalog=DbAkademiPlus;integrated Security=true");
        }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Balance>Balances { get; set; }
        public DbSet<Activity>Activities { get; set; }
    }
}
