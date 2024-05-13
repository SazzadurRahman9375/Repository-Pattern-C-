using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378.Models
{
    public class Batch:baseEntity
    {
        public Batch()
        {
        }

        public Batch(int id,string batchName, int maxTrainees, string course)
        {
            BatchName = batchName;
            MaxTrainees = maxTrainees;
            Course = course;
            this.Id = id;

        }

        public string BatchName { get; set; }
        public int MaxTrainees { get; set; }
        public string Course { get; set; }
    }
}
