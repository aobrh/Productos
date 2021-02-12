using Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Producto> AgregarProducto(Producto model, List<Producto> Productos)
        {
            Productos.Add(new Producto()
            {
                Id = model.Id,
                Nombre = model.Nombre,
                Descripcion = model.Descripcion,
                Categoria = model.Categoria,
                Cantidad = model.Cantidad,
                Precio = model.Precio
            });

            return Productos;
        }

        public List<Producto> EditarProducto(Producto model, List<Producto> Productos)
        {
            foreach (var item in Productos)
            {
                if (item.Id == model.Id)
                {
                    item.Nombre = model.Nombre;
                    item.Descripcion = model.Descripcion;
                    item.Categoria = model.Categoria;
                    item.Cantidad = model.Cantidad;
                    item.Precio = model.Precio;
                }
            }
            return Productos;
        }

        public List<Producto> EliminarProducto(int Id, List<Producto> Productos)
        {
            foreach (var item in Productos)
            {
                if (item.Id == Id)
                {
                    Productos.Remove(item);
                    break;
                }
            }
            return Productos;
        }

        public List<Producto> ObtenerProductos()
        {
            return new List<Producto>()
            {
                new Producto(){Id=1, Nombre="Arduino Nano", Descripcion="Placa de dearrollo arduino Nano", Categoria="Robotica", Cantidad=50, Precio=250.70},
                new Producto(){Id=2, Nombre="ESP32", Descripcion="Placa de dearrollo ESP32", Categoria="Robotica", Cantidad=20, Precio=1355.50},
                new Producto(){Id=3, Nombre="Raspberry Pi 3B", Descripcion="Placa de dearrollo Raspberry pi 3B", Categoria="Robotica", Cantidad=15, Precio=985.20},
            };
        }
    }
}
