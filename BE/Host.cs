using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        private long HostKey { get; set; }
        private string PrivateName { get; set; }
        private long PhoneNumber { get; set; }
        private string MailAddress { get; set; }
        private string BankAccuont { get; set; }
        private bool CollectionClearance { get; set; }

        public override string ToString()
        {
            return;
        }

    }
}
