using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    /// <summary>
    /// Activities
    /// </summary>
    interface IWaiterActivity
    {
        void TakeOrder();
        void ServerCustomer();
    }

    //Cleint waiter cannot perform washing hence creating new interface
    interface IWashDish 
    {
        void WashDishes();
    }

    //Cleint waiter cannot perform cooking hence creating new interface
    interface ICookFood
    {
        void CookFoods();
    }
}
