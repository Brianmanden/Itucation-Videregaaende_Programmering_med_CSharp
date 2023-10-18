using System.Collections.Generic;
using System.ServiceModel;

namespace WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {

        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        string GetData(int value);
    }
}
