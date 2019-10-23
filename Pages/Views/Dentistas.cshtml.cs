using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Ideia_gf.Pages
{
    public class DentistasModel : PageModel
    {
        public IEnumerable<Dentista> Dentistas { get; set; }

        public void OnGet()
        {
            Dentistas = new List<Dentista> 
            {
                new Dentista { Nome = "Zeferino", Sobrenome = "Dent" },
                new Dentista { Nome = "Jagunço", Sobrenome = "Pefect" },
                new Dentista { Nome = "Trollado", Sobrenome = "McTricia" },
                new Dentista { Nome = "Maniaco do parque", Sobrenome = "Beeblebrox" },
            };
        }
    }
}
