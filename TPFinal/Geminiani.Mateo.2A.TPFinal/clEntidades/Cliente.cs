using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clEntidades
{
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private uint _dni;
        private List<Libro> _librosPrestados;
        private bool activo;

        public Cliente() : this("", "", 0) { }
        public Cliente(string _nombre, string _apellido, uint _dni)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._dni = _dni;
            this.activo = true;
            _librosPrestados = new List<Libro>();
        }
        public bool Estado
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public string apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                this._apellido = value;
            }
        }
        public uint dni
        {
            get
            {
                return _dni;
            }
            set
            {
                this._dni = value;
            }
        }
        public override string ToString()
        {
            return Cliente.FormatoNombre(this);
        }
        private static string FormatoNombre(Cliente cl)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(cl.nombre.ToLower());
            sb[0] = char.ToUpper(sb[0]);
            sb.Append(" ");
            sb.Append(cl.apellido.ToLower());
            sb[cl.nombre.Length + 1] = char.ToUpper(sb[cl.nombre.Length + 1]);
            return sb.ToString();
        }
    }
}
