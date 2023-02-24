using Scolar.Data;
using Scolar.Data.Entity;

namespace Scolar.Service
{
    public class SchoolService : ISchoolsService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public SchoolService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task InitSchools()
        {
            if(!applicationDbContext.schools.Any())
            {
                var schools = new List<Schools>()
                {
                    new Schools
                    {
                        Name = "СПГЕ Джон Атанасов",
                        address = "Anna ahmatova"
                    },
                    new Schools
                    {
                        Name = "81 Виктор Юго",
                        address = "Anna ahmatova 2"
                    },
                     new Schools
                    {
                        Name = "81 Виктор Юго",
                        address = "Anna ahmatova 2"
                    }

                };
                await applicationDbContext.AddRangeAsync(schools);
                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
