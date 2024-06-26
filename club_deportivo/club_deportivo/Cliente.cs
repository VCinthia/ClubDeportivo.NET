using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo
{
    public class Cliente : Persona
    {
       
        public int idCliente;
        public bool esSocio;
        public bool aptoFisico;

        public Cliente(string nombre, string apellido, int dNI, bool esSocio, bool aptoFisico) : base(nombre, apellido, dNI)
        {
            //IdCliente = 0;
            EsSocio = esSocio;
            AptoFisico = aptoFisico;

        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public bool EsSocio { get => esSocio; set => esSocio = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }





        //public Cliente( bool esSocio, bool aptoFisico)
        //{
        //    //IdCliente = 0;
        //    EsSocio = esSocio;
        //    AptoFisico = aptoFisico;
        //}

    }
}
