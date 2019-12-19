using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataSource
    {
        public static List<HostingUnit> hostingUnits;
        public static List<GuestRequestKey> guestRequestKeys;
        public static List<Order> orders;

        public DataSource()
        {
            string[] privateName = new string[] { "mickael", "itshak", "chmoulik", "hillel", "acher" };
            string[] familyName = new string[] { "balensi", "bibas", "illouz", "farouz", "klein" };

            long[] phoneNumber = new long[] { 0767894905, 0584191198, 0512061998, 0648786859, 0589758695 };

            for (int i = 0; i < 5; i++)
            {
                hostingUnits.Add(new HostingUnit());
            }
        }
    }
}
