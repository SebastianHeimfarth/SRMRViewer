using System;

namespace SRMRDisplay
{
    public class BarElementModel
    {
        public decimal From {get; set;}
        public decimal To {get; set;}
        public decimal Height => Math.Abs(To - From);
        public string Color {get; set;}

        public string Tooltip => $"[{From}, {To}]";
    }
}
