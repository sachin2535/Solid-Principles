using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    /// <summary>
    /// client class
    /// </summary>
    class ClientWaiter : IWaiterActivity
    {
        void IWaiterActivity.TakeOrder()
        {
            throw new NotImplementedException();
        }

        void IWaiterActivity.ServerCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
