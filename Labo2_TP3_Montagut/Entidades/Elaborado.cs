﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Elaborado : Producto <Elaborado.ETipo>
    {

        public enum ETipo
        {
            Milanesa,
            Hamburguesa,
            Leche
        }
        public enum EMarca
        {
            Hierbalex,
            NotCorp,
            GranjaDeLaLuna
        }
    }
}
