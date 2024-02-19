using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AquaSmart.ViewModels
{
    public class ChartVM
    {
        public Chart BarchartSample => new BarChart()
        {
            //Entries = new[]
            //{
            //    new Entry(100)
            //    {
            //        Color = SKColor.Parse("#ff80ff"),
            //        TextColor = SKColor.Parse("#ff80ff"),
            //        Label = "Baseball",
            //        ValueLabel = "100%"
            //    } ,
            //    new Entry(75)
            //    {
            //        Color = SKColor.Parse("#A8F4B4"),
            //        TextColor = SKColor.Parse("#A8F4B4"),
            //        Label = "Volleyball",
            //        ValueLabel = "75%"
            //    },
            //    new Entry(25)
            //    {
            //        Color = SKColor.Parse("#B7A8F4"),
            //        TextColor = SKColor.Parse("#B7A8F4"),
            //        Label = "Tennis",
            //        ValueLabel = "25%"
            //    },
            //},
            //LabelTextSize = 45,
            //LabelOrientation = Orientation.Vertical
        };
    }
}
