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
        /// <summary>
        /// Inicializa la calculadora
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cuando se presiona el boton cerrar abre un mensaje y cierra el forms si se presiona Si
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }

        }

        /// <summary>
        /// Al presionar el boton Convertir a Binario convierte un numero decimal valido a binario y lo muestra en el label Resultado  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Al presionar el boton Convertir a Decimal convierte un numero binario valido a decimal y lo muestra en el label Resultado  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Limpia las cajas de texto, label, listbox y deshabilita las conversiones
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = string.Empty;
            // los botones de convertir estan deshabilitados para que no se intente convertir un string vacio
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            lstOperaciones.Items.Clear();
        }

        /// <summary>
        /// Al presionar el boton Operar usa dos numeros validos de las text box numero 1 y 2 para realizar una operacion determinada por el operador de la combo box operador y 
        /// muestra el resultado de la operacion en el label resultado, la operacion se agrega al list box Operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (String.IsNullOrEmpty((string)cmbOperador.SelectedItem))
                    {
                        cmbOperador.Text = "+";
                    }
                    lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                    btnConvertirADecimal.Enabled = false;
                    btnConvertirABinario.Enabled = true;
                    lstOperaciones.Items.Insert(0,txtNumero1.Text.Replace(" ","")+" "+cmbOperador.Text.Replace(" ", "")+ " "+txtNumero2.Text.Replace(" ", "")+ " = "+lblResultado.Text.Replace(" ", "")+ "\n");
                }
            }

        }

        /// <summary>
        /// Cuando se inicia el forms llama a la funcion limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cuando se presiona el boton limpiar llama a la funcion limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        /// <summary>
        /// Recibe dos numeros y un operador como strings y realiza una operacion matematica
        /// </summary>
        /// <param name="numero1">Primer numero de la operacion</param>
        /// <param name="numero2">Segundo numero de la operacion</param>
        /// <param name="operador">Operador de la operacion</param>
        /// <returns>Retorna el resultado de la operacion como un numero double</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char[] bufferChar = operador.ToCharArray();
            return Calculadora.Operar(operando1, operando2, bufferChar[0]);
        }
    }
}
