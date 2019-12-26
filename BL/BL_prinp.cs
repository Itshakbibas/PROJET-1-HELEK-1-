using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Threading;

namespace BL
{
    public class BL_prinp:IBL
    {
       public  void addRequest()   {
        if (1>2)
                Console.WriteLine("ta soeur");
        
        }
       public void updateRequest() { }
       //hostingUnit
       public void addHostingUnit() { }
       public void deleteHostingUnit() { }
       public void updateHostingUnit() { }
       
       //Invitation
       public void addInvitation() { }
       public void UpdateInvitation() { }
       
        //prints 
       public void printAllHostingUnit() { }
       public void printAllOrder() { }
       public void printAllCustomer() { }
       public void printAllBranchesOfBank() { }


    }
}
