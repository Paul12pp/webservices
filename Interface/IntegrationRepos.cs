using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeeryEscribir;
using Microsoft.EntityFrameworkCore;
using WebServices.Model;

namespace WebServices.Interface
{
    public class IntegrationRepos:IIntegration
    {
        private readonly ApplicationDbContext _context;
        public IntegrationRepos(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task AddResource(IntegrationInputDto model)
        {
            ///TO DO
            ///aplicar algo de logica respeto a los calculos de
            ///reducciones impuestos o afp
            _context.Empleados.AddRange(model.Empleados.AsEnumerable());
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Empleados>> GetEmpleados()
        {
            return await _context.Empleados.ToListAsync();
        }
    }
}
