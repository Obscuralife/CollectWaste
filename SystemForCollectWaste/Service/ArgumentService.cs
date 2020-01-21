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
    internal sealed class ArgumentService
    {
        private readonly ApplicationDbContext dbContext;

        public ArgumentService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<string[]> GetArgumentsDropDownList()
        {
            return await dbContext.Arguments.Select(i => i.Description).ToArrayAsync();
        }

        public async Task<Argument> AddEntryAsync(ArgumentModel model)
        {
            var addedArgument = dbContext.Arguments.Add(new Argument { Description = model.Description });
            await dbContext.SaveChangesAsync();
            return addedArgument;
        }

        public async Task<Argument> RemoveAsync(int id)
        {
            var argument = await dbContext.Arguments.Where(i => i.Id == id).FirstOrDefaultAsync();
            var deletedArgument = dbContext.Arguments.Remove(argument);
            await dbContext.SaveChangesAsync();
            return deletedArgument;
        }

        public async Task<Argument> GetRecordAsync(string description)
        {
            return await dbContext.Arguments.FirstOrDefaultAsync(i => i.Description == description);
        }

        public async Task<BindingList<ArgumentModel>> GetGridDatasAsync()
        {
            var gridDatas = new List<ArgumentModel>();

            var arguments = await dbContext.Arguments.OrderBy(i => i.Id).ToArrayAsync();
            foreach (var argument in arguments)
            {
                gridDatas.Add(new ArgumentModel
                {
                    Id = argument.Id,
                    Description = argument.Description
                });
            }

            return new BindingList<ArgumentModel>(gridDatas);
        }
    }
}
