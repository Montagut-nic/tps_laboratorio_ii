using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grano : Producto <Grano.ETipoGrano>
    {
        int pesoEnGramos;
        float pesoEnKilogramos;

        public Grano(string nombre, int cantidad, float precio, ETipoGrano tipo) : base(nombre, cantidad, precio, tipo)
        {
            this.pesoEnGramos = cantidad;
            this.pesoEnKilogramos = pesoEnGramos/1000;
        }

        public enum ETipoGrano
        {
            Lenteja,
            Arroz,
            Avena,
            Chia,
            Garbanzo,
            Poroto,
            MixSemilla
        }

        public override string ToString()
        {
            return $"{this.tipo}: {this.nombre}";
        }
    }
}
