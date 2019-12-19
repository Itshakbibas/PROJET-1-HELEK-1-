using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
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
