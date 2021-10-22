using System.Collections.Generic;

namespace SRMRDisplay
{
    public class VerticalBarGraphModel
    {
        public string ProductName { get; set; }
        public decimal TotalWidth { get; set; } = 400;
        public decimal TotalHeight { get; set; } = 1000;
        public decimal Stroke { get; set; } = 4;

        public decimal ScalaWidth { get; set; } = 14;

        public decimal ScalingFactor => (BarHeight - Stroke) / (MaxValue - MinValue);


        public decimal BarWidth { get; set; } = 100;
        public decimal BarHeight => TotalHeight * .85m;

        public decimal MaxValue { get; set; } = 2000;
        public decimal MinValue { get; set; } = -2000;
        public decimal Step { get; set; } = 200;

        public List<BarElementModel> Elements { get; set; } = new List<BarElementModel>();
        public Dictionary<decimal, decimal> Index { get; set; } = new Dictionary<decimal, decimal> { };
        public decimal LeftArrow {get; set;}
        public decimal RightArrow {get; set;}

        public decimal? GetValueForIndex(decimal index)
        {
            if(Index.TryGetValue(index, out var result))
            {
                return result;
            }

            return null;
        }
    }
}
