using Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Repositorios
{
    public interface IRepositorio
    {
        List<Producto> ObtenerProductos();
        List<Producto> AgregarProducto(Producto model, List<Producto> Productos);
        List<Producto> EditarProducto(Producto model, List<Producto> Productos);
        List<Producto> EliminarProducto(int Id, List<Producto> Productos);
    }
}
