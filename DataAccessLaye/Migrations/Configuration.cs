using DataAccessLayer.Models;
using System;
using System.Data.Entity.Migrations;
using System.Diagnostics;

namespace DataAccessLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            ContextKey = "ApplicationData";
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            SeedDatabase(context);
        }

        [Conditional("DEBUG")]
        private void SeedDatabase(ApplicationDbContext context)
        {
            context.Subjects.AddOrUpdate(i => i.Id,
                            new Subject
                            {
                                Id = 1,
                                Address = "ул. Социалистическая 2",
                                Name = "ОАО «Минский автомобильный завод»",
                                Email = "maz@mail.ru",
                                PhoneNumber = "8(033)5789678"
                            },
                            new Subject
                            {
                                Id = 2,
                                Address = "ул. Жилуновича 2",
                                Name = "ОАО «Минский подшипниковый завод»",
                                Email = "romanuk@mail.ru",
                                PhoneNumber = "8(033)1234245"
                            });

            context.SolidWastes.AddOrUpdate(i => i.Id,
                new SolidWaste
                {
                    Id = 1,
                    Description = "Бумага"
                },
                new SolidWaste
                {
                    Id = 2,
                    Description = "Резина"
                });

            context.Arguments.AddOrUpdate(i => i.Id,
                new Argument
                {
                    Id = 1,
                    Description = "Частный дом"
                },
                new Argument
                {
                    Id = 2,
                    Description = "Общественный объект"
                });

            context.Employes.AddOrUpdate(i => i.Id,
                new Employe
                {
                    Id = 1,
                    Address = "Кирова 78-45",
                    Login = "test12",
                    Name = "Жукович Н.В.",
                    Password = "qwerty12",
                    PhoneNumber = "(8029)1231283",
                    Position = "Инжинер"
                },
                new Employe
                {
                    Id = 2,
                    Address = "Брестская 23-56",
                    Login = "test34",
                    Name = "Валевич И.П.",
                    Password = "zaqw34",
                    PhoneNumber = "(8029)0990011",
                    Position = "Мастер"
                });

            context.Collects.AddOrUpdate(i => i.Id,
               new Collect
               {
                   Id = 1,
                   DateTime = DateTime.UtcNow,
                   EmployeId = 1,
                   ArgumentId = 1,
                   SolidWasteId = 1,
                   SubjectId = 1
               },
               new Collect
               {
                   Id = 2,
                   DateTime = DateTime.UtcNow,
                   EmployeId = 2,
                   ArgumentId = 2,
                   SolidWasteId = 2,
                   SubjectId = 2
               });
        }
    }
}
