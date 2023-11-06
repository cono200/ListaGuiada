using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDesdeCero
{
    public  class Lista
    {
        //TENER UN DATO PRIMERO Y EL ULTIMO DATO
        Nodo primero;
        Nodo ultimo;


        //CONTRUCTOR PARA INICIAR LAS VARIABLES ANTERIORES
        public Lista()
        {
            //ESTO ES PARA CREAR UNA LISTA VACIA
            primero = ultimo = null;
        }

        //METODO PARA SABER SI EL PRIMER ELEMENTO DE LA LISTA ESTA VACIA O NO
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }

            return false;
        }

        //SABER LA LONGITUD DE LA LISTA

        //VACIA,AL MENOS UNO, Y CON MAS DE UNO


        public int  LongitudLista()
        {
            //VARIABLE PARA GUARDAR LA LONGITUD SIUUU
            int contador=0;

            //SABER SI LA LISTA ESTA VACIA
            //SI ESTA VACIA SE RETORNA CONTADOR QUE VALE 0 AL PRINCIPIO
            if (ListaVacia())
            {
                return contador;
            }

            else
            {
                //SI EL PRIMERO ES DIFERENTE DE VACIO (ES DECIR QUE TIENE UN VALOR) EL SIGUIENTE NUMERO DEBE DE SER DIFERENTE DE NULLO PARA SABER QUE HAY OTRO VALOR

                //SI EL SEGUNDO ESTA NULLO ES POR QUE SOLO AI UN DATO, QUE EL PRIMERO ES UNICO
                if (primero != null && primero.Siguiente != null)
                {

                    //QUE TE REGRESE EL NUMERO Y QUE TE LO SUMAN
                    return ++contador;
                }



            }
        }




    }
}
