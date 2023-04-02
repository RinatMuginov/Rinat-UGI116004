using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public struct Pixel
    {
        private double r;
        public double R 
        {
            get => r;
            set  => r = CheckValue(value); 
        }

        private double g;
        public double G
        {
            get => g;
            set => g = CheckValue(value);
        }

        private double b;
        public double B
        {
            get => b;
            set => b = CheckValue(value);
        }
        public double H
        {
            get
            {
                if ((MaxOfRGB(R, G, B) == R)&&(G >= B))
                    return 60*((G - B)/(MaxOfRGB(R, G, B) - MinOfRGB(R, G, B))) + 0;
                if ((MaxOfRGB(R, G, B) == R) && (G < B))
                    return 60 * ((G - B) / (MaxOfRGB(R, G, B) - MinOfRGB(R, G, B))) + 360;
                if (MaxOfRGB(R, G, B) == G)
                    return 60 * ((B - R) / (MaxOfRGB(R, G, B) - MinOfRGB(R, G, B))) + 120;
                else
                    return 60 * ((R - G) / (MaxOfRGB(R, G, B) - MinOfRGB(R, G, B))) + 240;
            }
        }
        public double S
        {
            get
            {
                if ((L == 0 ||(MaxOfRGB(R, G, B) == MinOfRGB(R, G, B))))
                    return 0;
                if ((L > 0 && L < 0.5))
                    return CheckValue((MaxOfRGB(R, G, B) - MinOfRGB(R, G, B)) / (2 * L));
                else
                    return CheckValue((MaxOfRGB(R, G, B) - MinOfRGB(R, G, B)) / (2 - 2 * L));
            }
        }
        public double L
        {
            get => CheckValue(Trim(0.5 * (MaxOfRGB(R,G,B) + MinOfRGB(R,G,B))));
        }


        public Pixel(double red, double green, double blue) : this()
        {
            R = red;
            G = green;
            B = blue;
        }

        public static Pixel operator *(double k, Pixel p)
        {
            Pixel result = new Pixel();

            result.r = Trim(k * p.r);
            result.g = Trim(k * p.g);
            result.b = Trim(k * p.b);

            return result;
        }

        public static Pixel operator *(Pixel p, double k) => k * p;      

        private double CheckValue(double val)
        {
            if (val < 0 || val > 1)
                throw new ArgumentException("Неверное значение яркости канала");

            return val;
        }

        private static double Trim(double lightness)
        {
            if(lightness > 1)
                return 1;

            return lightness;
        }

        private static double MaxOfRGB(double r,double g, double b)
        {
            double max = 0;
            if ((r >= g) && (r >= b)) max = r;
            else if ((g >= r) && (g >= b)) max = g;
            else max = b;
            return max;
        }
        private static double MinOfRGB(double r, double g, double b)
        {
            double min = 0;
            if ((r <= g) && (r <= b)) min = r;
            else if ((g <= r) && (g <= b)) min = g;
                else min = b;
            return min;
        }
    }
}
