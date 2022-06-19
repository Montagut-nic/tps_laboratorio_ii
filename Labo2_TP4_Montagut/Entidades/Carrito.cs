using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        private ArrayList productos;
        private double descuento;
        private double total;
        private Enum tipo;
        private Elaborado.EMarca marca;
        private bool requiereMarca;
        private int siguienteDescuento;

        public Carrito()
        {
            this.productos = new ArrayList();
            requiereMarca = false;
            AsignarDescuento();
        }

        private void AsignarDescuento()
        {
            switch (DateTime.Today.Day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    requiereMarca = true;
                    descuento = 35f / 100;
                    marca= Elaborado.EMarca.NotCorp;
                    tipo = Elaborado.ETipo.Hamburguesa;
                    siguienteDescuento = 5;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    descuento = 20f / 100;
                    tipo = Grano.ETipoGrano.Lenteja;
                    siguienteDescuento = 9;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    descuento = 50f / 100;
                    tipo = Merchandise.ETipoPrenda.Remera;
                    siguienteDescuento = 13;
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                    requiereMarca= true;
                    descuento = 15f / 100;
                    tipo = Elaborado.ETipo.Milanesa;
                    marca = Elaborado.EMarca.Hierbalex;
                    siguienteDescuento = 17;
                    break;
                case 17:
                case 18:
                case 19:
                case 20:
                    descuento = 40f / 100;
                    tipo = Merchandise.ETipoPrenda.Buzo;
                    siguienteDescuento = 21;
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                    requiereMarca = true;
                    descuento = 60f / 100;
                    tipo = Elaborado.ETipo.Leche;
                    marca = Elaborado.EMarca.NotCorp;
                    siguienteDescuento = 25;
                    break;
                case 25:
                case 26:
                case 27:
                    descuento = 30f / 100;
                    tipo = Grano.ETipoGrano.Garbanzo;
                    siguienteDescuento = 28;
                    break;
                case 28:
                case 29:
                case 30:
                case 31:
                    descuento = 70f / 100;
                    tipo= Grano.ETipoGrano.Avena;
                    siguienteDescuento = 1;
                    break;
            }
        }

        public int SiguienteDescuento { get=>siguienteDescuento; }

        public string MostrarDescuento()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hoy hay {Math.Round(descuento*100,0)}% de descuento en {tipo}s");
            if (requiereMarca)
            {
                sb.Append($" marca {marca}");
            }
            return sb.ToString();
        }

    }
}
