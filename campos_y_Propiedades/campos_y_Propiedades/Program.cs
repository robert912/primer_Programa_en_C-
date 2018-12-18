using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campos_y_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea la instancia(objeto) de la clase Vector
            var v2 = new Vector(new List<int> { 1, 2 });
            Console.WriteLine(v2.Valores);
            
        }
    }

    class Vector
    {
        //campo
        private List<int> _Valores;

        //propiedades
        public List<int> Valores
        {
            get
            {
                return _Valores;
            }
        }

        //Constructor
        public Vector(List<int> valores)
        {
            _Valores = valores;
        }
    }
}
