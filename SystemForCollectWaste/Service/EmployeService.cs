using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste.Service
{
    internal sealed class EmployeService
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<BindingList<EmployeModel>> GetGridDatasAsync()
        {
            var gridDatas = new List<EmployeModel>();
            var employes = await dbContext.Employes.OrderBy(i => i.Id).ToArrayAsync();

            foreach (var employe in employes)
            {
                gridDatas.Add(new EmployeModel
                {
                    Id = employe.Id,
                    Login = employe.Login,
                    Password = employe.Password,
                    Address = employe.Address,
                    Name = employe.Name,
                    PhoneNumber = employe.PhoneNumber,
                    Position = employe.Position
                });
            }
            
            return new BindingList<EmployeModel>(gridDatas);
        }

        public async Task<Employe> RemoveAsync(int id)
        {
            var employe = await dbContext.Employes.Where(i => i.Id == id).FirstOrDefaultAsync();
            var deletedEmploye = dbContext.Employes.Remove(employe);
            await dbContext.SaveChangesAsync();
            return deletedEmploye;
        }

        public async Task<Employe> AddEntryAsync(EmployeModel model)
        {
            var dbEmploye = new Employe
            {
                Address = model.Address,
                Login = model.Login,
                Password = model.Password,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                Position = model.Position
            };
            var addedEmploye = dbContext.Employes.Add(dbEmploye);
            await dbContext.SaveChangesAsync();
            return addedEmploye;
        }

        public async Task<string[]> GetEmployesDropDownListAsync()
        {
            return await dbContext.Employes
                .OrderBy(i => i.Id)
                .Select(i => i.Name)
                .ToArrayAsync();
        }

        public async Task<Employe> GetRecordAsync(string name)
        {
            return await dbContext.Employes.FirstOrDefaultAsync(i => i.Name == name);
        }
    }
}
