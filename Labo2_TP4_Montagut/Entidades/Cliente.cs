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
        /// Cambia la informacion del cliente, lanza una FormatException si algun parametro no es valido
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <exception cref="FormatException"></exception>
        public void CambiarInformacion(string mail, string nombre, string apellido)
        {
            if (!MailAddress.TryCreate(mail,out _))
            {
                throw new FormatException("No se ingreso un mail valido");
            }
            try
            {
                Mail = new MailAddress(mail);
                Nombre = nombre;
                Apellido = apellido;
            }
            catch
            {
                throw;
            }

        }
    }
}
