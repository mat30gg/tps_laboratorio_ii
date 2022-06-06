using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.IO;
using System.Text;

namespace clEntidades
{
    public class Libro
    {
        private static int ultimoIdLibro;
        private int _idLibro;
        private string _titulo;
        private string _autor;
        private List<Cliente> _prestatarios;
        private int _cantDisponible;

        /*static Libro()
        {
            //leer ultimo id de archivo
            string uid;
            try
            {
                FileStream file = new FileStream("libultid.txt", FileMode.Open);
            }
            catch (FileNotFoundException e)
            {
                //crea archivo que guarda ultimo id en 0
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }*/
        public Libro(string _titulo, string _autor) : this(_titulo, _autor, 1) { }
        public Libro(string _titulo, string _autor, int _cantDispo)
        {
            this._titulo = _titulo;
            this._autor = _autor;
            this._cantDisponible = _cantDispo;
            this._idLibro = ultimoIdLibro++;
            this._prestatarios = new List<Cliente>();
        }
        public bool CopiaDisponible
        {
            get
            {
                return (this._cantDisponible > 0);
            }
        }
        public string titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;
            }
        }
        public string autor
        {
            get
            {
                return _autor;
            }
            set
            {
                _autor = value;
            }
        }
        public int cantDispo
        {
            get
            {
                return _cantDisponible;
            }
            set
            {
                _cantDisponible = value;
            }
        }
        public static bool operator >(Libro l1, Libro l2)
        {
            bool retorn = false;
            if(string.Compare(l1.titulo, l2.titulo) > 0)
            {
                retorn = true;
            }
            return retorn;
        }
        public static bool operator <(Libro l1, Libro l2)
        {
            bool retorn = false;
            if (string.Compare(l1.titulo, l2.titulo) < 0)
            {
                retorn = true;
            }
            return retorn;
        }
        public static bool operator ==(Libro l1, Libro l2)
        {
            bool retorn = false;
            if (string.Compare(l1.titulo, l2.titulo) == 0)
            {
                retorn = true;
            }
            return retorn;
        }
        public static bool operator !=(Libro l1, Libro l2)
        {
            bool retorn = false;
            if (string.Compare(l1.titulo, l2.titulo) != 0)
            {
                retorn = true;
            }
            return retorn;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(titulo + " / ");
            sb.Append(autor);
            sb[titulo.Length + 3] = char.ToUpper(sb[titulo.Length + 3]);
            return sb.ToString();
        }
    }
}
