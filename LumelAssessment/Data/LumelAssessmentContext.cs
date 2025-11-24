using Microsoft.EntityFrameworkCore;

namespace LumelAssessment.Data
{
    public class LumelAssessmentContext : DbContext
    {
        //public readonly DbContext dbContext;
        public LumelAssessmentContext(DbContextOptions<LumelAssessmentContext> options) : base(options)
        {

        }

    }
}
