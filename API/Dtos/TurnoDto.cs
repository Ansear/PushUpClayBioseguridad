using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class TurnoDto : BaseDto
    {
        public string NombreTurno { get; set; }

        public TimeOnly? HoraTurnoInicio { get; set; }

        public TimeOnly? HoraTurnoFin { get; set; }
    }
}