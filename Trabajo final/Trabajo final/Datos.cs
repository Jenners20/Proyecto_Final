using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final.Clases
{
    public class Datos
    {
        public struct Usuario1
        {
            public long username;
            public string Nombre;
            public int clave;
            public string rol;
            public DateTime fecha_creacion;
            public bool actividad;

        }
        

        public static void Usuarios()
        {
            const int MAX = 4;
            Usuario1[] U1 = new Usuario1[MAX];

         //Datos del Primer usuario
            U1[0].username = 05500014500;
            U1[0].Nombre = "Miguel Aurelino";
            U1[0].clave = 1234;
            U1[0].rol = "Supervisor";
            U1[0].fecha_creacion = new DateTime(2020, 2, 15);
            U1[0].actividad = true;

            //Datos del segundo usuario
            U1[1].username = 40225053392;
            U1[1].Nombre = "Aderly Ramirez";
            U1[1].clave = 1234;
            U1[1].rol = "Administrador";
            U1[1].fecha_creacion = new DateTime(2015, 3, 2);
            U1[1].actividad = true;

            //Datos del tercer usuario
            U1[2].username = 00114219033;
            U1[2].Nombre = "Arismendy Mañon ";
            U1[2].clave = 324242;
            U1[2].rol = "Vendedor";
            U1[2].fecha_creacion = new DateTime(2010, 10, 10);
            U1[2].actividad = true;

            //Datos del cuarto usuario
            U1[3].username = 40224382370;
            U1[3].Nombre = "Gladeline Rapozo";
            U1[3].clave = 5453;
            U1[3].rol = "Vendedor";
            U1[3].fecha_creacion = new DateTime(2019, 8, 25);
            U1[3].actividad = false;

            Program.Login(U1);
        }
        
       
       

    }
}
