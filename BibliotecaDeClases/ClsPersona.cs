using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public class ClsPersona
    {
        #region
        private String apellido;
        private String nombre;
        private int edad;
        public String desscripcion { get; private set;}
        public ClsPersona()
        {
            this.apellido = "anonimo";
            this.nombre = "anonimo";
            this.edad = 0;
        }

        public ClsPersona(string nombre, string apellido, int edad)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value.ToLower(); }
        }
        public int FechaNac
        {
            get { return edad; }
            set { edad = value; }
        }
       
    }
    #endregion
}
