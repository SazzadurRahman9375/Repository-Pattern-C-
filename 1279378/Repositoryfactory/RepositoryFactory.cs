using _1279378.Models;
using _1279378.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378.Repositoryfactory
{
    public class RepositoryFactory : IRepoFactory
    {
        public IRepository<T> CreateRepository<T>() where T : baseEntity
        {
            return new GenericRepository<T>();
        }
    }
}
