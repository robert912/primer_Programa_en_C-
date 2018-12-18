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
            foreach(int componentes in v2.Valores)
            Console.Write("{0}, ",componentes);
            Console.WriteLine("\n"+v2.dimension);
            v2.Nombre = "Vector 1";
            Console.WriteLine(v2.Nombre);
            v2[0] = 5;
            Console.WriteLine(v2[0]);
            Console.ReadKey();
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

        public int dimension
        {
            get
            {
                return _Valores.Count;
            }
        }

        public string Nombre { get; set; }

        //Indexadores
        public int this[int i]
        {
            get { return _Valores[1]; }
            set { _Valores[i] = value; }
        }

        //Constructor
        public Vector(List<int> valores)
        {
            _Valores = valores;
        }

    }
}
