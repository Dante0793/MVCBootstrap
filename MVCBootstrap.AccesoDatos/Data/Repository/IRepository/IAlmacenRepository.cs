using MVCBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBootstrap.AccesoDatos.Data.Repository.IRepository
{
    public interface IAlmacenRepository : IRepository<Almacen>
    {
        void Update(Almacen almacen);
    }

}
