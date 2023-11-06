using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDesdeCero
{
    public class Nodo
    {
        private int _Datos;
        private Nodo _Siguiente;


        //ESTÓ PARA CREAR UN NODO VACIA
        //PARA SABER  SI ES EL ULTIMO EL SIGUIENTE DEBE DE SER NULLO

        public Nodo(int valor)
        {
            _Datos = valor;

            _Siguiente = null;

        }


        //ESTE PARA Q UNA LISTA QUE YA ESTE INICIADA
        //EN OTRAS PALABRAS SOBRECARGA DE METODOS

        public Nodo(int valor, Nodo Siguiente)
        {
            _Datos = valor;
            _Siguiente = Siguiente;
        }


        //PARA ACCEDER A LOS DATOS, YA QUE ESTAN EN PRIVATE

        /*
        public int GetDatos()
        {
            return _Datos;
        }

        //PARA ACCEDER A LOS DATOS, YA QUE ESTAN EN PRIVATE


        public Nodo GetSiguiente()
        {
            return _Siguiente;
        }
        */

        //TAMBIEN SE PUEDE ASI
        
        public int Datos { get; }
        public Nodo Siguiente { get; set; }





    }
}
