using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.ClassSerializer;

namespace WcfService
{
    public class CustomerService : ICustomerService
    {
        private PruebaDBEntities DBContext = new PruebaDBEntities();

        public List<CustomerSerializer> GetAll()
        {          

            var query = (from C in DBContext.Customers
                         select C).Distinct();

            List<CustomerSerializer> Lista = new List<CustomerSerializer>();

            query.ToList().ForEach(rec =>
            {
                Lista.Add(new CustomerSerializer
                {
                    id = rec.id,
                    idDocumentType = rec.idDocumentType,
                    DocumentsType = new DocumentsTypeSerializer { id = rec.DocumentsType.id, description =rec.DocumentsType.description},
                    documentNumber = rec.documentNumber,
                    birthdate = rec.birthdate,
                    idCity = rec.idCity,
                    City = new CitySerializer { id = rec.City.id, name = rec.City.name },
                    movilNumber = rec.movilNumber,
                    name = rec.name
                });
            });

            return Lista;
        }
    }
}
