using _1279378.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378.Repository
{
    public interface IRepository<T> where T : baseEntity
    {
        List<T> GetAll();
        T Get (int id);
        void Update (T entity);
        void Delete (int id);
        void Add (T entity);
        void Addrange (IEnumerable<T> entities);
    }
}
