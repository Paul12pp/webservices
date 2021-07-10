using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeeryEscribir;

namespace WebServices.Model
{
    public class IntegrationInputDto
    {
        public string RNC { get; set; }
        public DateTime Periodo { get; set; }
        public DateTime Transimision { get; set; }
        public List<Empleados> Empleados { get; set; }
    }
}
