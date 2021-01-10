using Microsoft.AspNetCore.Hosting;
using PaginaDuvida.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PaginaDuvida.Services
{
    public class JsonServiceFile
    {
        public JsonServiceFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string ArquivoJson
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "duvidas.json"); }
        }

        public Lista_Duvidas GetListaTarefas()
        {
            using (var jsonfile = File.OpenText(ArquivoJson))
            {
                return JsonSerializer.Deserialize(jsonfile.ReadToEnd(), typeof(Lista_Duvidas)) as Lista_Duvidas;
            }
        }
    }
}
