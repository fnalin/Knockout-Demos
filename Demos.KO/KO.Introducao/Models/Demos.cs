
using System.Collections.Generic;
namespace KO.Introducao.Models
{
    public class Demo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }


    public class Dados
    {

        public static IList<Demo> Demos
        {
            get
            {
                return new List<Demo> { 
                    new Demo{ID=1,Nome="Introdução",Descricao="Demo inicial introdutória"},
                    new Demo{ID=2,Nome="Observable",Descricao="Usando Observable"},
                    new Demo{ID=3,Nome="ObservableArray",Descricao="Usando ObservableArray"},
                    new Demo{ID=4,Nome="Binding_visible",Descricao="Binding - visible"},
                    //
                };
            }
        }


    }

}