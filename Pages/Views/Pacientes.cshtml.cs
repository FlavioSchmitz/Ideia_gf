using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Ideia_gf.Pages
{
    public class PacientesModel : PageModel
    {
        public IEnumerable<Paciente> Pacientes { get; set; }

        public void OnGet()
        {
            Pacientes = new List<Paciente> 
            {
                new Paciente { Nome = "Zeferino", Sobrenome = "Dent" },
                new Paciente { Nome = "Jagunço", Sobrenome = "Pefect" },
                new Paciente { Nome = "Silva", Sobrenome = "McTricia" },
                new Paciente { Nome = "Jaburu", Sobrenome = "Beeblebrox" },
            };
        }
    }
}
