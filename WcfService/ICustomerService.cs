using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WcfService.ClassSerializer;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICustomerService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetCustomers/")]
        List<CustomerSerializer> GetAll();
    }
}
