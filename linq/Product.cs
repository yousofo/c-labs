using System;
namespace linq
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public String ProductName { get; set; }
        public String Category { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int32 UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;


    



