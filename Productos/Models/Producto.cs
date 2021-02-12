using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
