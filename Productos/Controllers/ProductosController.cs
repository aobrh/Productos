using Microsoft.AspNetCore.Mvc;
using Productos.Models;
using Productos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IRepositorio _repositorio;
        private List<Producto> lstProductos;
        public ProductosController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
            lstProductos = _repositorio.ObtenerProductos();
        }
        public IActionResult Index()
        {
            return View(lstProductos);
        }

        public IActionResult AgregarProducto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarProducto(Producto model)
        {
            var addProd = _repositorio.AgregarProducto(model, lstProductos);
            lstProductos = addProd;
            return RedirectToAction("Index");
        }

        public IActionResult EditarProducto(int Id)
        {
            var model = lstProductos.Where(p => p.Id == Id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public IActionResult EditarProducto(Producto model)
        {
            var editProd = _repositorio.EditarProducto(model, lstProductos);
            lstProductos = editProd;
            return RedirectToAction("Index");
        }

        public IActionResult EliminarProducto(int Id)
        {
            var elimProd = _repositorio.EliminarProducto(Id, lstProductos);
            lstProductos = elimProd;
            return RedirectToAction("Index");
        }
    }
}
