using DataAccessLayer;
using DataAccessLayer.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SystemForCollectWaste.Model;

namespace SystemForCollectWaste.Service
{
    internal sealed class SubjectService
    {
        private readonly ApplicationDbContext dbContext;

        public SubjectService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<Subject> AddEntryAsync(SubjectModel model)
        {
            var subject = new Subject
            {
                Address = model.Address,
                Email = model.Email,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber
            };

            var addedSubject = dbContext.Subjects.Add(subject);
            await dbContext.SaveChangesAsync();
            return addedSubject;
        }

        public async Task<string[]> GetSubjectsDropDownListAsync()
        {
            return await dbContext.Subjects
                .OrderBy(i => i.Id)
                .Select(i => i.Name)
                .ToArrayAsync();
        }

        public async Task<Subject> GetRecordAsync(string name)
        {
            return await dbContext.Subjects.FirstOrDefaultAsync(i => i.Name == name);
        }

        public async Task<BindingList<SubjectModel>> GetGridDatasAsync()
        {
            var gridDatas = new List<SubjectModel>();
            var subjects = await dbContext.Subjects.OrderBy(i => i.Id).ToArrayAsync();

            foreach (var subject in subjects)
            {
                gridDatas.Add(new SubjectModel
                {
                    Id = subject.Id,
                    Address = subject.Address,
                    Name = subject.Name,
                    PhoneNumber = subject.PhoneNumber,
                    Email = subject.Email
                });
            }

            return new BindingList<SubjectModel>(gridDatas);
        }

        public async Task<Subject> RemoveAsync(int id)
        {
            var subject = await dbContext.Subjects.Where(i => i.Id == id).FirstOrDefaultAsync();
            var deletedSubject = dbContext.Subjects.Remove(subject);
            await dbContext.SaveChangesAsync();
            return deletedSubject;
        }
    }
}
