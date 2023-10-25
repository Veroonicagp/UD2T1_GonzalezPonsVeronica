using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T1GonzalezPonsVeronica
{
    class Empleado
    {
        string nombre;
        string apellido;
        string apellido2;
        int edad;
        string nif;
        double salario;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="apellido2"></param>
        /// <param name="edad"></param>
        /// <param name="nif"></param>
        /// <param name="salario"></param>
        public Empleado(string nombre, string apellido, string apellido2, int edad, string nif, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.nif = nif;
            this.salario = salario;
        }


        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }



}