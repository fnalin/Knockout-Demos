
using System.Collections.Generic;
namespace KO.Introducao.Models
{
    public class Demo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }


    public class Factory
    {

        public static List<Demo> Demos
        {
            get
            {
                return new List<Demo> { 
                    new Demo{ID=1,Nome="Introdução - 01",Descricao="Demo inicial introdutória"},
                    new Demo{ID=2,Nome="Introdução - 02",Descricao="Usando Observable"},
                };
            }
        }


    }

}