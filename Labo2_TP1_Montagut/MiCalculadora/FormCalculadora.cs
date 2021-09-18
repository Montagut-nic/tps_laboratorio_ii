using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }

        }

        

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            if(!Double.TryParse(lblResultado.Text,out double bufferDouble))
            {
                MessageBox.Show("¡Error! "+lblResultado.Text+" no es un numero valido para convertir a binario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
            if(string.Equals(lblResultado.Text,"Valor inválido"))
            {
                btnConvertirABinario.Enabled = false;
            }
            else
            {
                btnConvertirABinario.Enabled = true;
            }
            btnConvertirADecimal.Enabled = false;

        }

        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = string.Empty;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            lstOperaciones.Items.Clear();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("¡Error! Falta ingresar el valor de por lo menos un operando.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(!Double.TryParse(txtNumero1.Text,out double bufferDouble) || !Double.TryParse(txtNumero2.Text, out bufferDouble))
                {
                    MessageBox.Show("¡Error! No se ha ingresado un valor valido en algun operando.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbOperador.SelectedItem == null)
                    {
                        cmbOperador.Text = "+";
                    }
                    lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                    btnConvertirADecimal.Enabled = false;
                    btnConvertirABinario.Enabled = true;
                    lstOperaciones.Items.Insert(0,txtNumero1.Text+" "+cmbOperador.Text +" "+txtNumero2.Text+" = "+lblResultado.Text+"\n");
                }
            }

        }


        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char[] bufferChar = operador.ToCharArray();
            return Calculadora.Operar(operando1, operando2, bufferChar[0]);
        }
    }
}
