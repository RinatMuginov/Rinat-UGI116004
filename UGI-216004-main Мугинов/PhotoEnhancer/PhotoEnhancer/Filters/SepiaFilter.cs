using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class SepiaFilter : PixelFilter
    {
        public override ParameterInfo[] GetParametersInfo()
        {
            return new[]
{
                new ParameterInfo()
                {
                    Name = "Оттенок",
                    MinValue = 0,
                    MaxValue = 359.95,
                    DefaultValue = 40,
                    Increment = 0.05
                },
                new ParameterInfo()
                {
                    Name = "Насыщенность",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0.2,
                    Increment = 0.01
                }
            };
        }

        public override Pixel ProcessPixel(Pixel pixel, double[] parameters)
        {
            var hue = parameters[0];
            var sat = parameters[1];
            return Convertors.HSLToPixel(hue, sat, pixel.L);
        }

        public override string ToString()
        {
            return "Сепия";
        }
    }
}
