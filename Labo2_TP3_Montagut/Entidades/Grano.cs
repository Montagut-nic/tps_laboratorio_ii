using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grano : Producto <Grano.ETipo>
    {
        int pesoEnGramos;
        float pesoEnKilogramos;
        

        public enum ETipo
        {
            Lentejas,
            Arroz,
            Avena,
            Chia,
            Garbanzo,
            Porotos,
            MixSemillas
        }
    }
}
