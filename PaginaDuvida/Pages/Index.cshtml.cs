using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PaginaDuvida.Models;
using PaginaDuvida.Services;

namespace PaginaDuvida.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private JsonServiceFile JsonFile;
        public Lista_Duvidas Tarefas { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonServiceFile listaTarefas)
        {
            _logger = logger;
            JsonFile = listaTarefas;
        }

        public void OnGet()
        {
            Tarefas = JsonFile.GetListaTarefas();
        }
    }
}
