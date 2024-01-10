using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.Models
{
    public class ProductInfo
    {
        [PrimaryKey,AutoIncrement]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductQty { get; set; }
        public string ProductPrice { get; set; }
    }
}
