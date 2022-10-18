using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcWebUI.Service
{
    public interface ICartSessionService
    {
        Cart GetCart();//Yazmak için 
        void SetCart(Cart cart);//Okumak için 
    }
}
