using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsUnitarios
{
    [TestClass]
    public class ClaseTesteo
    {
        [TestMethod]
        public void TestMethod_AgregarAlCarritoRestar()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            Assert.AreEqual(2, producto.Cantidad);
        }

        [TestMethod]
        public void TestMethod_AgregarAlCarritoSumar()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            Assert.AreEqual(5, ((Elaborado)carritoCompras.Productos[0]).Cantidad);
        }

        [TestMethod]
        public void TestMethod_AgregarAlCarritoSumarDoble()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            carritoCompras.AgregarAlCarrito(producto, 2);
            Assert.AreEqual(7, ((Elaborado)carritoCompras.Productos[0]).Cantidad);
        }

        [TestMethod]
        public void TestMethod_QuitarDelCarritoSumar()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            carritoCompras.QuitarDelCarrito(producto,2);
            Assert.AreEqual(4, producto.Cantidad);
        }

        [TestMethod]
        public void TestMethod_QuitarDelCarritoRestar()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            carritoCompras.QuitarDelCarrito(producto, 2);
            Assert.AreEqual(3, ((Elaborado)carritoCompras.Productos[0]).Cantidad);
        }

        [TestMethod]
        public void TestMethod_QuitarDelCarritoRemover()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            carritoCompras.QuitarDelCarrito(producto, 5);
            Assert.AreEqual(0, carritoCompras.Productos.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod_NoQuitarDeMas()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            carritoCompras.QuitarDelCarrito(producto, 5);
            carritoCompras.QuitarDelCarrito(producto, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(NoHayCantidadDelProductoException))]
        public void TestMethod_NoAgregarDeMas()
        {
            Elaborado producto = new Elaborado("milanesas de soja", 7, 159, Elaborado.ETipo.Milanesa, Elaborado.EMarca.Hierbalex);
            Carrito carritoCompras = new Carrito(true);
            carritoCompras.AgregarAlCarrito(producto, 5);
            carritoCompras.AgregarAlCarrito(producto, 5);
        }
    }
}
