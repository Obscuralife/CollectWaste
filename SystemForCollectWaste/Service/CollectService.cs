using DataAccessLayer;
using DataAccessLayer.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SystemForCollectWaste.Service
{
    public sealed class CollectService
    {
        private readonly ApplicationDbContext dbContext;

        public CollectService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<Collect> AddCollectAsync(Collect collect)
        {
            var addedCollect = dbContext.Collects.Add(collect);
            await dbContext.SaveChangesAsync();
            return addedCollect;
        }

        public async Task<Collect> RemoveAsync(int id)
        {
            var collect = await dbContext.Collects.Where(i => i.Id == id).FirstOrDefaultAsync();
            var deletedCollect = dbContext.Collects.Remove(collect);
            await dbContext.SaveChangesAsync();
            return deletedCollect;
        }
    }
}
