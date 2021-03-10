using System.Threading.Tasks;
using Cv_App.Core.Models;
using Cv_App.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cv_App.Data.Models
{
    public class CvAppContext: DbContext, ICvAppContext
    {
        public CvAppContext(DbContextOptions<CvAppContext> options):
            base(options){}

        public DbSet<CvModel> CvModels { get; set; }
        public DbSet<PersonalData> PersonalData { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Property> Properties { get; set; }

        public async Task<int> SaveAsync()
        {
            return await SaveChangesAsync();
        }

        public async Task EnsureDataBaseCreated()
        {
            await Database.EnsureCreatedAsync();
        }
    }
}
