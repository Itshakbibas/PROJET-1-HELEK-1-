using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    enum CustomerRequirementStatus
    {
        active,
        transactionClosed,
        hasExpired
    }
    enum StatusOfOrder
    {
        NotYetAddressed,
        anemailwassent,
        closedduetostatusinconsistency,
        Customer,
        ClosesCustomersResponse
    }

    enum TypeOfHostingUnit
    {
        zimmer,
        apartment,
        roomOfHotel,
        tent
    }

    enum TypeAreaOfTheCountry
    {
        all,
        north,
        south,
        center,
        jerusalem
    }
    
    enum Options
    {
        yes,
        no,
        optional
    }
    
    //rajouter subArea
}
