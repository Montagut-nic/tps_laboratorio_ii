using System;
using System.Collections;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Producto <T> where T : Enum
    {
        public int id;
        public string nombre;
        public int cantidad;
        public float precio;
        public T tipo;
        
        public Producto(string nombre, int cantidad, float precio, T tipo)
        {
            id = LogicaNegocio.ultimoIdProducto+1;
            LogicaNegocio.ultimoIdProducto = id;
            this.tipo = tipo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        


    }
}
