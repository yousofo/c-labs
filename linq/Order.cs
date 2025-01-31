using System;
namespace linq
{
    public class Order
    {
        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }

        public Order() { }

        public int OrderID;
        public DateTime OrderDate;
        public decimal Total;

        public override string ToString()
        {
            return $"Order Id: {OrderID},Date: {OrderDate.ToShortTimeString()},Total: {Total}";
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;


    



