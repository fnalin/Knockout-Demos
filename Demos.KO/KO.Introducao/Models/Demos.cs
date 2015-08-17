
using System.Collections.Generic;
namespace KO.Introducao.Models
{
    public class Demo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string View { get; set; }

        public string Descricao { get; set; }

    }


    public class Dados
    {

        public static IList<Demo> Demos
        {
            get
            {
                return new List<Demo> { 
                    new Demo{ID=1,Nome="Introdução",View="Introducao",Descricao="Demo inicial introdutória"},
                    new Demo{ID=2,Nome="Observable",View="Observable",Descricao="Usando Observable"},
                    new Demo{ID=3,Nome="ObservableArray",View="ObservableArray",Descricao="Usando ObservableArray"},
                    new Demo{ID=4,Nome="Binding - visible",View="Binding_visible", Descricao="Binding - visible"},
                    new Demo{ID=5,Nome="Binding - text",View="Binding_text",Descricao="Binding - text"},
                    new Demo{ID=6,Nome="Binding - html",View="Binding_html",Descricao="Binding - html"},
                    new Demo{ID=7,Nome="Binding - css",View="Binding_css",Descricao="Binding - css"},
                    new Demo{ID=7,Nome="Binding - style",View="Binding_style",Descricao="Binding - style"},
                };
            }
        }


    }

}