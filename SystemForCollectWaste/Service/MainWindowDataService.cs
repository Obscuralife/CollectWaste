using DataAccessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste.Service
{
    internal sealed class MainWindowDataService
    {
        private readonly ApplicationDbContext dbContext;

        public MainWindowDataService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<BindingList<WorkDoneModel>> GetGridDatasAsync()
        {
            var gridDatas = new List<WorkDoneModel>();
            var collects = await dbContext.Collects.OrderBy(c => c.Id).ToArrayAsync();
            foreach (var collect in collects)
            {
                gridDatas.Add(new WorkDoneModel
                {
                    Id = collect.Id,
                    Date = collect.DateTime,
                    Subject = collect.Subject.Name,
                    Address = collect.Subject.Address,
                    Email = collect.Subject.Email,
                    SolidWaste = collect.SolidWaste.Description,
                    Description = collect.Argument.Description
                });
            }
            return new BindingList<WorkDoneModel>(gridDatas);
        }

        public async Task<BindingList<WorkDoneModel>> GetGridDatasByNameAsync(string subjectName)
        {
            var gridDatas = new List<WorkDoneModel>();
            var collects = await dbContext.Collects.Where(i => i.Subject.Name == subjectName).ToArrayAsync();
            foreach (var collect in collects)
            {
                gridDatas.Add(new WorkDoneModel
                {
                    Id = collect.Id,
                    Date = collect.DateTime,
                    Subject = collect.Subject.Name,
                    Address = collect.Subject.Address,
                    Email = collect.Subject.Email,
                    SolidWaste = collect.SolidWaste.Description,
                    Description = collect.Argument.Description
                });
            }
            return new BindingList<WorkDoneModel>(gridDatas);
        }
    }
}
