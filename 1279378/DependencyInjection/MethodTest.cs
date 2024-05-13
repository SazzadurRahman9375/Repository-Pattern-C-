using _1279378.Models;
using _1279378.Repository;
using _1279378.Repositoryfactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378.DependencyInjection
{
    internal class MethodTest
    {
        public void MethodRun(IRepoFactory repoFactory)
        {
            IRepository<Batch> repositoryB = repoFactory.CreateRepository<Batch>();
            repositoryB.Addrange(new Batch[]
            {
                new Batch { Id = 1,BatchName = "Morning",MaxTrainees=15,Course="CSharp" },
                new Batch { Id = 2,BatchName="Evening",MaxTrainees=15,Course="java"},
                new Batch { Id = 3,BatchName="Morning",MaxTrainees=15,Course="PHP"}

            });
            Console.WriteLine("*********Batch*********");
            Console.WriteLine("Get All");
            repositoryB.GetAll().ToList().ForEach(x =>
            {
                Console.WriteLine($"Id:{x.Id},BatchName:{x.BatchName},MaxTrainees:{x.MaxTrainees},Course:{x.Course}");
            });

            Console.WriteLine("Get By Id");
            var batch = repositoryB.Get(2);
            Console.WriteLine($"Id:{batch.Id},BatchName:{batch.BatchName},MaxTrainees:{batch.MaxTrainees},Course:{batch.Course}");

            Console.WriteLine("Update");
            batch.BatchName = "Afternoon";
            repositoryB.Update(batch);
            repositoryB.GetAll().ToList().ForEach(x =>
            {
                Console.WriteLine($"Id:{x.Id},BatchName:{x.BatchName},MaxTrainees:{x.MaxTrainees},Course:{x.Course}");
            });

            Console.WriteLine("Delete");
            repositoryB.Delete(2);
            repositoryB.GetAll().ToList().ForEach(x =>
            {
                Console.WriteLine($"Id:{x.Id},BatchName:{x.BatchName},MaxTrainees:{x.MaxTrainees},Course:{x.Course}");
            });

            Console.WriteLine("******Trainee******");
            IRepository<Trainee> repositoryT = repoFactory.CreateRepository<Trainee>();
            repositoryT.Addrange(new Trainee[]
            {
                new Trainee { Id = 1,Name="Robin",ContactNumber=01876543585,Address="Mirpur 10,Dhaka",BatchId=1},
                new Trainee { Id = 2,Name="Shila",ContactNumber=01986483935,Address="ECB chattar,Dhaka",BatchId=2},
                new Trainee { Id = 3,Name="Murad",ContactNumber=01789349938,Address="Mirpur 6,Dhaka",BatchId=1},
                new Trainee { Id = 4,Name="Sayed",ContactNumber=01876548433,Address="Gabtoli,Dhaka",BatchId=2},
                new Trainee { Id = 5,Name="Niaz",ContactNumber=015778393643,Address="Savar,Dhaka",BatchId=1}
            });

            Console.WriteLine("Get All");
            repositoryT.GetAll().ForEach(x =>
            Console.WriteLine($"Id:{x.Id},Name:{x.Name},ContactNumber:{x.ContactNumber},Address:{x.Address},BatchId:{x.BatchId}"));

            Console.WriteLine("Get By Id");
            var trainee2 = repositoryT.Get(2);
            var trainee5 = repositoryT.Get(5);
            Console.WriteLine($"Id:{trainee2.Id},Name:{trainee2.Name},ContactNumber:{trainee2.ContactNumber},Address:{trainee2.Address},BatchId:{trainee2.BatchId}");
            Console.WriteLine($"Id: {trainee5.Id} ,Name: {trainee5.Name} ,ContactNumber: {trainee5.ContactNumber} ,Address: {trainee5.Address} ,BatchId:{trainee5.BatchId}");

            Console.WriteLine("Update");
            trainee5.Address = "Uttara,Dhaka";
            repositoryT.Update(trainee5);
            repositoryT.GetAll().ForEach(x =>
            Console.WriteLine($"Id: {x.Id} ,Name: {x.Name} ,ContactNumber: {x.ContactNumber} ,Address: {x.Address} ,BatchId:{x.BatchId}"));


            Console.WriteLine("Delete");
            repositoryT.Delete(2);
            repositoryT.GetAll().ForEach(x =>
             Console.WriteLine($"Id: {x.Id} ,Name: {x.Name} ,ContactNumber: {x.ContactNumber} ,Address: {x.Address} ,BatchId:{x.BatchId}"));

        }
    }
}
    
