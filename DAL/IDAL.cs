﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        //request
        void addRequest();
        void updateRequest();

        //hostingUnit
        void addHostingUnit();
        void deleteHostingUnit();
        void updateHostingUnit();

        //Invitation
        void addInvitation();
        void UpdateInvitation();

        //prints 
        void printAllHostingUnit();
        void printAllOrder();
        void printAllCustomer();
        void printAllBranchesOfBank();
    }
   
}
