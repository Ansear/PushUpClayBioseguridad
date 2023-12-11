using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ContratoDto : BaseDto
    {
        public DateOnly? Fechacontrato { get; set; }

        public DateOnly? FechaFin { get; set; }

        public int? IdEstado { get; set; }
    }
}