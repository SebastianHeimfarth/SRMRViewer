using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SRMRDisplay.Data
{
    public class BarDisplayProvider
    {
        private const string Green = "rgb(0, 200, 0)";
        private const string Yellow = "rgb(255, 255, 50)";

        private IDictionary<string, BarDisplay> _entries = new Dictionary<string, BarDisplay>
        {
            { 
                "SR", 
                new BarDisplay
                {
                    Entries = 
                    {
                        new BarEntry
                        {
                            From = 1600,
                            To = 1750,
                            Color = Yellow
                        },
                        new BarEntry
                        {
                            From = 0,
                            To = 100,
                            Color = Green
                        },
                        new BarEntry
                        {
                            From = 200,
                            To = 250,
                            Color = Green
                        },
                        new BarEntry
                        {
                            From = -210,
                            To = -200,
                            Color = Green
                        }
                    }
                } 


            }
        }; 

        public BarDisplay GetByName(string name)
        {
            if (_entries.TryGetValue(name, out var result))
            {
                return result;
            }

            return null;
        }
    }
}