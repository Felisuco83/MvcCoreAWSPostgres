using MvcCoreAWSPostgres.Data;
using MvcCoreAWSPostgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSPostgres.Repositories
{
    public class RepositoryDepartamento
    {
        private DepartamentosContext context;

        public RepositoryDepartamento (DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public Departamento FindDepartamento( int id )
        {
            return this.context.Departamentos.SingleOrDefault(x => x.IdDepartamento == id);
        }
    }
}
