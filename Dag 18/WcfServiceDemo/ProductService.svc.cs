using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    //[DataContract(IsReference = true)]
    public class ProductService: IProductService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Product> GetProducts()
        {
            SalesDB db = new SalesDB();
            return db.Products.ToList();
        }
    }
}
