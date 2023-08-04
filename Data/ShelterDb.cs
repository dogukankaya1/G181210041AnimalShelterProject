using AnimalShelterProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterProject.Data


{
    public class ShelterDb:DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Application> Applications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                Database=ShelterDatabase;Trusted_Connection=True;");

        }



    }
}
