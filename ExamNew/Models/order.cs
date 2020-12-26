using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNew.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PackageId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
