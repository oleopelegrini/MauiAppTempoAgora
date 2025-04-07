using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTempoAgora.Models
{
    internal class Tempo
    {
        public double? lon {  get; set; }
        public double? lat { get; set; }
        public double? tempo_min { get; set; }
        public double? tempo_max { get; set; }
        public double? visibility { get; set; }
        public double? speed { get; set; }
        public double? main { get; set; }
        public double? description { get; set; }
        public double? sunrise { get; set; }
    }
}
