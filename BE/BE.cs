using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankAccount
    {
        private long BankNumber { get; set; }
        private string BankName { get; set; }
        private long BranchNumber { get; set; }
        private string BranchAddress { get; set; }
        private string BranchCity { get; set; }
        private long BankAccountNumber { get; set; }
        public override string ToString()
        {
            return;
        }

    }


    public class Order
    {
        private long HostingUnitKey;
        private long GuestRequestKey;
        private long OrderKey;
        private StatusOfOrder Status;
        private DateTime CreateDate = new DateTime();
        private DateTime OrderDate  = new DateTime();
       
        public override ToString()
        {
            return;
        }
    }

    public class GuestRequestKey
    {
        private string PrivateName;
        private string FamilyName;
        private string MailAddress;
        //status
        private CustomerRequirementStatus Status;
        private DateTime RegistrationDate = new DateTime();
        private DateTime EntryDate = new DateTime();
        private DateTime ReleaseDate = new DateTime();
        //area
        private TypeAreaOfTheCountry Area;
        //subArea
        //type hostingUnit
        private TypeOfHostingUnit Type;
        private int Adults;
        private int Children;
        private Options Pool;
        private Options Jacuzzi;
        private Options Garden;
        private Options ChildrensAttractions;
        public override ToString();

    }

}

