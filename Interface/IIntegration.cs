using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServices.Model;

namespace WebServices.Interface
{
    public interface IIntegration
    {
        Task AddResource(IntegrationInputDto model);
        Task<IEnumerable<Empleados>>  GetEmpleados();
    }
}
