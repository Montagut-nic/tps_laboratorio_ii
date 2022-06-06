using System;

namespace Entidades
{
    public abstract class Producto <T> where T : Enum
    {
        public int id;
        public string nombre;
        public int cantidad;
        public float precio;
        public T etipo;

        
    }
}
