using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PersonaDto : BaseDto
    {
        public string IdPersona { get; set; }

        public string Nombre { get; set; }

        public DateOnly FechaRegistro { get; set; }
        public int IdUser { get; set; }

        public int IdTipoPersona { get; set; }

        public int IdCategoria { get; set; }

        public int IdCiudad { get; set; }
    }
}