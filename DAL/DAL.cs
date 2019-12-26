using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using static DS.DataSource;
namespace DAL
{
    public interface Idal
    {
        //request

        void addRequest(GuestRequest guest);
        void addHostingUnit(HostingUnit unit);
        void addOrder(Order order);


        void updateRequest();
        void updateHostingUnit();
        void updateOrder();

        void deleteHostingUnit();


        //get 
        void getAllHostingUnit();
        void getAllOrder();
        void getAllCustomer();
        void getAllBranchesOfBank();
    }
    public class Dal_imp : Idal
    {
        #region add
        public  void addRequest(GuestRequest guest) {
            List<GuestRequest> guestRequestList = DS.DataSource.guestRequestList;
            guestRequestList.Add(guest);
        }
        public void addHostingUnit(HostingUnit unit) {
            List < HostingUnit > hostingUnitsList = DS.DataSource.hostingUnitsList;
            hostingUnitsList.Add(unit);
        }
        public void addOrder(Order order) {
            List<Order> ordersList = DS.DataSource.ordersList;
            ordersList.Add(order);
        }

        #endregion

        public void updateRequest() { }
        public void updateHostingUnit() { }
        public void updateOrder() { }
 
        public void deleteHostingUnit() { }
        //get 
        public void getAllHostingUnit() { }
        public void getAllOrder() { }
        public void getAllCustomer() { }
        public void getAllBranchesOfBank() { }

    }
}
