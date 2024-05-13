using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1279378.Models
{
    public class Trainee:baseEntity
    {
        public Trainee()
        {
        }

        public Trainee(int id, string name, long contactNumber, string address, int batchId)
        {
            Name = name;
            ContactNumber = contactNumber;
            Address = address;
            BatchId = batchId;
            this.Id = id;
        }

        public string Name { get; set; }
        public long ContactNumber { get; set; }
        public string Address {  get; set; }
        public int BatchId { get; set; }

    }
}
