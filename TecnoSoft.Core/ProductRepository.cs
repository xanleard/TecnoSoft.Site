using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnoSoft.DataBase;

namespace TecnoSoft.Core
{
    public class ProductRepository
    {
        public Product GetProducto()
        {
            return new Product { Id = 1, Cantidad = 2, Estado = "Registrado"};
        }
    }
}
