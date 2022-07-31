using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IStockeable 
    {
        public void Agregar(ArrayList carritoProductos, int cantidad, float descuento);

        public void Quitar(ArrayList carritoProductos, int cantidad);
    }
}
