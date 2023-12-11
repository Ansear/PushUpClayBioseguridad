using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CiudadDto : BaseDto
    {
        public string Nombreciud { get; set; }

        public int? IdDep { get; set; }
    }
}