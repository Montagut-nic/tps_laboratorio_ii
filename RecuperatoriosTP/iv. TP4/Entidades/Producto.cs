using System;
using System.Collections;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Producto <T> where T : Enum
    {
        private string nombre;
        private int cantidad;
        private float precio;
        private T tipo;

         public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public T Tipo { get => tipo; set => tipo = value; }

        /// <summary>
        /// constructor publico de la clase abstracta producto
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="tipo"></param>
        public Producto(string nombre, int cantidad, float precio, T tipo)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
       
    }
}
