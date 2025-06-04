using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionWebGonzalesValenciaMicroservice.Entities
{
    public class RelacionesDTO
    {
        public List<string> TablasRelacionadas { get; set; } = new();
        public List<string> RelacionesAtributos { get; set; } = new();
        public List<string> Procedimientos { get; set; } = new();
    }
}
