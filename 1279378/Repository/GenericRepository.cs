using _1279378.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : baseEntity
    {
        private readonly  IList<T> data;

        public GenericRepository() 
        { 
            this.data = new List<T>();
        }

        public List<T> GetAll()
        {
            return this.data.ToList();
        }
        public T Get(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }

        

        public void Update(T entity)
        {
            int i = this.data.IndexOf(entity);
            this.data.RemoveAt(i);
            this.data.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = this.data.FirstOrDefault(x=>x.Id == id);
            if (entity != null)
            {
                this.data.Remove(entity);
            }
        }

        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public void Addrange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                this.data.Add(entity);
            }
        }
    }
}
