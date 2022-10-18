using System;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class CartLine//Sepet Elemanı
    {
        public Product Product{ get; set; }
        public int Quantity { get; set; }
    }
}
