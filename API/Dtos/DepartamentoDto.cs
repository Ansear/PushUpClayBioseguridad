using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DepartamentoDto : BaseDto
    {
        public string NombreDep { get; set; }

        public int? IdPais { get; set; }
    }
}