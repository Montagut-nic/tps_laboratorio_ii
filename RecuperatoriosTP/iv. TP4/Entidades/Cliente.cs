using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private MailAddress mail;
        private string nombre;
        private string apellido;
        private int id;
        private bool activo;

        public MailAddress Mail 
        {
            get 
            { 
                return mail; 
            }
            set 
            {
                mail = value;
            } 
        }

        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().ToUpper().All(char.IsLetter))
                {
                    nombre = value.Trim().ToUpper();
                }
                else
                {
                    throw new FormatException("No se ingreso un nombre valido");
                }
                 
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().ToUpper().All(char.IsLetter))
                {
                    apellido = value.Trim().ToUpper();
                }
                else
                {
                    throw new FormatException("No se ingreso un apellido valido");
                }

            }
        }

        public int Id { get => id; set => id = value; }
        public bool Activo { get => activo; set => activo = value; }

        /// <summary>
        /// constructor publico de la clase cliente, hecho para el ingreso manual de un nuevo cliente, solo recibe strings
        /// el cliente construido tendra activo=true
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="stringId"></param>
        /// <exception cref="Exception"></exception>
        /// <exception cref="FormatException"></exception>
        public Cliente(string mail, string nombre, string apellido, string stringId)
        {
            int id;
            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(stringId) ||
                string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                throw new Exception("Asegurese de completar todos los campos");
            }
            if (!MailAddress.TryCreate(mail, out _))
            {
                throw new FormatException("No se ingreso un mail valido");
            }
            if (!int.TryParse(stringId.Trim(), out id) || id <= 0)
            {
                throw new FormatException("No se ha ingresado un id valido");
            }
            this.Mail = new MailAddress(mail);
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id = id;
            this.Activo = true;
        }

        /// <summary>
        /// constructor publico de la clase cliente, hecho para la carga desde la base de datos, el cliente puede 
        /// tener mail null si no es activo 
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="stringId"></param>
        /// <param name="activo"></param>
        /// <exception cref="Exception"></exception>
        /// <exception cref="FormatException"></exception>
        public Cliente(string mail, string nombre, string apellido, string stringId, int activo)
        {
            int id;
            if (activo == 1 && string.IsNullOrWhiteSpace(mail) )
            {
                throw new Exception($"el mail de id {stringId} en la BD no deberia estar vacio");
            }
            if (!string.IsNullOrWhiteSpace(mail) && !MailAddress.TryCreate(mail, out _))
            {
                throw new FormatException($"id {stringId} en la BD no tiene un mail valido");
            }
            if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(stringId))
            {
                throw new Exception($"hay campos vacios en la BD cuando no deberia");
            }
            if (!int.TryParse(stringId.Trim(), out id) || id <= 0)
            {
                throw new FormatException("un cliente en la BD tiene un id invalido");
            }
            if (string.IsNullOrWhiteSpace(mail))
            {
                this.Mail = null;
            }
            else
            {
                this.Mail = new MailAddress(mail);
            }
            this.Nombre= nombre;
            this.Apellido= apellido;
            this.Id = id;
            if(activo == 1)
            {
                this.Activo = true;
            }
            else
            {
                this.Activo= false;
            }
        }





        /// <summary>
        /// Cambia la informacion del cliente y aplica los cambios en la base de datos
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <exception cref="FormatException"></exception>
        public void CambiarInformacion(string mail, string nombre, string apellido, DelegadoActualizarMensaje delegado)
        {
            if (!MailAddress.TryCreate(mail,out _))
            {
                delegado("No se ingreso un mail valido");
            }
            try
            {
                Mail = new MailAddress(mail);
                Nombre = nombre;
                Apellido = apellido;
                ManejadorBD.ModificarCliente(Nombre,Apellido,Mail.Address,Id,Activo);
            }
            catch (Exception ex)
            {
                delegado(ex.Message);
            }

        }
    }
}
