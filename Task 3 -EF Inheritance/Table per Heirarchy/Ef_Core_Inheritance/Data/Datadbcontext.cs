using System;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Inheritance.Models
{
    public class Datadbcontext:DbContext
    {
        public Datadbcontext(DbContextOptions<Datadbcontext> options):base (options)
        {

        }
        public DbSet<Studentdetails> Details {get;set;}
        public DbSet<Percentage> Percentage {get;set;}
        public DbSet<Address> Addressdetail {get;set;}

    }
}