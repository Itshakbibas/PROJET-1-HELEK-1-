using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        private long HostingUnitKey;
        private long GuestRequestKey;
        private long OrderKey;
        private StatusOfOrder Status;
        private DateTime CreateDate = new DateTime();
        private DateTime OrderDate = new DateTime();

        public  override string  ToString()
        {
            return " " ;
        }
    }
}
