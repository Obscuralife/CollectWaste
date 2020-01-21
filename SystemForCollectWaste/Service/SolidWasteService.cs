using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste.Service
{
    internal sealed class SolidWasteService
    {
        private readonly ApplicationDbContext dbContext;

        public SolidWasteService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<string[]> GetWasteDropDownListAsync()
        {
            return await dbContext.SolidWastes.Select(i => i.Description).ToArrayAsync();
        }

        public async Task<SolidWaste> AddEntryAsync(SolidWasteModel model)
        {
            var dbSolidWaste = new SolidWaste
            {
                Description = model.Description
            };

            var addedWaste = dbContext.SolidWastes.Add(dbSolidWaste);
            await dbContext.SaveChangesAsync();
            return addedWaste;
        }

        public async Task<SolidWaste> GetRecordAsync(string description)
        {
            return await dbContext.SolidWastes.FirstOrDefaultAsync(i => i.Description == description);
        }

        public async Task<BindingList<SolidWasteModel>> GetGridDataAsync()
        {
            var gridDatas = new List<SolidWasteModel>();
            var solidWastes = await dbContext.SolidWastes.OrderBy(c => c.Id).ToArrayAsync();
            foreach (var solidWaste in solidWastes)
            {
                gridDatas.Add(new SolidWasteModel
                {
                    Id = solidWaste.Id,
                    Description = solidWaste.Description
                });
            }

            return new BindingList<SolidWasteModel>(gridDatas);
        }

        public async Task<SolidWaste> RemoveAsync(int id)
        {
            var solidWaste = await dbContext.SolidWastes.Where(i => i.Id == id).FirstOrDefaultAsync();
            var deletedSolidWaste = dbContext.SolidWastes.Remove(solidWaste);
            await dbContext.SaveChangesAsync();
            return deletedSolidWaste;
        }
    }
}
