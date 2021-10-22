using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SRMRDisplay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class BarDisplay
    {
        public decimal TotalWidth { get; set; } = 600;
        public decimal TotalHeight { get; set; } = 1000;
        public decimal Stroke { get; set; } = 4;

        public decimal ScalaWidth { get; set; } = 14;

        public decimal ScalingFactor => (BarHeight - Stroke) / (MaxValue - MinValue) ;


        public decimal BarWidth { get; set; } = 200;
        public decimal BarHeight => TotalHeight * .85m;

        public decimal MaxValue { get; set; } = 2000;
        public decimal MinValue { get; set; } = -2000;
        public decimal Step { get; set; } = 200;

        public IList<BarEntry> Entries { get; set; } = new List<BarEntry>();
        public decimal LeftArrow {get; set;}
        public decimal RightArrow {get; set;}
    }

    public class BarEntry
    {
        public decimal From {get; set;}
        public decimal To {get; set;}
        public decimal Height => Math.Abs(To - From);
        public string Color {get; set;}

        public string Tooltip => $"[{From} - {To}]";
    }
}
