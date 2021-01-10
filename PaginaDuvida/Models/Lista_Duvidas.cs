using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaDuvida.Models
{
    public class Lista_Duvidas
    {
        public List<lista_tarefas> lista_tarefas { get; set; }
    }

    public class lista_tarefas
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
    }
}
