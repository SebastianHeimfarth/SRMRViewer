using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

namespace SRMRDisplay.Data
{
    public class VerticalBarGraphManager
    {
        private const string Green = "rgb(0, 200, 0)";
        private const string Yellow = "rgb(255, 255, 50)";

        private Dictionary<string, VerticalBarGraphModel> _entries = new Dictionary<string, VerticalBarGraphModel>
        {
            {
                "SR",
                new VerticalBarGraphModel
                {
                    ProductName = "SR 08-12",
                    Elements =
                    {
                        new BarElementModel
                        {
                            From = 1600,
                            To = 1750,
                            Color = Yellow
                        },
                        new BarElementModel
                        {
                            From = 0,
                            To = 100,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = 200,
                            To = 250,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = -210,
                            To = -200,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = -340,
                            To = -300,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = -450,
                            To = -420,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = -1400,
                            To = -1200,
                            Color = Green
                        }
                    },
                    Index = new Dictionary<decimal, decimal>
                    {
                        { 2000, 730 },
                        { 1800, 430 },
                        { 1600, 400 },
                        { 1400, 360 },
                        { 1200, 330 },
                        { 1000, 320 },
                        { 800, 290 },
                        { 600, 273 },
                        { 400, 250 },
                        { 200, 130 },
                        { 0, 30 },
                        { -200, 10 },
                        { -400, -10 },
                        { -600, -30 },
                        { -800, -50 },
                        { -1000, -90 },
                        { -1200, -130 },
                        { -1400, -280 },
                        { -1600, -300 },
                        { -1800, -320 },
                        { -2000, -330 },

                    }
                }
            },
            {
                "MR",
                new VerticalBarGraphModel
                {
                    ProductName = "MR 08-12",
                    Elements =
                    {
                        new BarElementModel
                        {
                            From = 1400,
                            To = 1700,
                            Color = Yellow
                        },
                        new BarElementModel
                        {
                            From = 150,
                            To = 190,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = 224,
                            To = 270,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = -170,
                            To = -160,
                            Color = Yellow
                        },
                        new BarElementModel
                        {
                            From = -250,
                            To = -230,
                            Color = Green
                        },
                        new BarElementModel
                        {
                            From = -870,
                            To = -700,
                            Color = Yellow
                        }

                    },
                    Index = new Dictionary<decimal, decimal>
                    {
                        { 2000, 1430 },
                        { 1800, 1030 },
                        { 1600, 900 },
                        { 1400, 860 },
                        { 1200, 730 },
                        { 1000, 620 },
                        { 800, 490 },
                        { 600, 273 },
                        { 400, 250 },
                        { 200, 130 },
                        { 0, 30 },
                        { -200, 10 },
                        { -400, -10 },
                        { -600, -30 },
                        { -800, -50 },
                        { -1000, -230 },
                        { -1200, -430 },
                        { -1400, -580 },
                        { -1600, -700 },
                        { -1800, -820 },
                        { -2000, -1330 },

                    }
                }
            }
        }; 

        public string ToJson()
        {
            return JsonSerializer.Serialize(_entries, new JsonSerializerOptions() { WriteIndented = true, IgnoreReadOnlyProperties = true, IgnoreReadOnlyFields = true });
        }

        public void UpdateFromJson(string jsonString)
        {
            var newEntries = JsonSerializer.Deserialize(jsonString, typeof(Dictionary<string, VerticalBarGraphModel>));
            _entries = (Dictionary<string, VerticalBarGraphModel>)newEntries;
        }

        public VerticalBarGraphModel GetByName(string name)
        {
            if (_entries.TryGetValue(name, out var result))
            {
                return result;
            }

            return null;
        }
    }
}