using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public static class Convertors
    {
        public static Photo BitmapToPhoto(Bitmap bmp)
        {
            var photo = new Photo(bmp.Width, bmp.Height);

            for(var x = 0; x < bmp.Width; x++)
                for(var y = 0; y < bmp.Height; y++)
                {
                    var p = bmp.GetPixel(x, y);
                    photo[x, y] = new Pixel(p.R / 255.0, p.G / 255.0, p.B / 255.0);
                }

            return photo;
        }

        public static Bitmap PhotoToBitmap(Photo photo)
        {
            var bmp = new Bitmap(photo.Width, photo.Height);

            for (var x = 0; x < photo.Width; x++)
                for (var y = 0; y < photo.Height; y++)
                    bmp.SetPixel(x, y, 
                        Color.FromArgb(
                        (int)Math.Round(photo[x, y].R * 255),
                        (int)Math.Round(photo[x, y].G * 255),
                        (int)Math.Round(photo[x, y].B * 255)
                        ));
            return bmp;
        }
        public static Pixel HSLToPixel(double hue, double saturation, double lightness)
        {
            double q;
            if (lightness < 0.5)
                q = lightness * (1 + saturation);
            else
                q = lightness + saturation - (lightness * saturation);
            double p = 2 * lightness - q;
            hue = hue / 360;
            double tr, tg, tb;
            tr = hue + 1 / 3;
            tg = hue;
            tb = hue - 1 / 3;
            return new Pixel(GetEveryChannelFromHSL(tr, q, p), GetEveryChannelFromHSL(tg, q, p), GetEveryChannelFromHSL(tb, q, p));


        }
        public static double GetEveryChannelFromHSL(double chnl, double q, double p)
        {
            if (chnl < 0)
                chnl+= 1;
            if (chnl > 1)
                chnl-=1;

            if (chnl < 1 / 6)
                return p + ((q - p) * 6 * chnl);
            if ((chnl >= 1/6) && (chnl < 0.5))
                return q;
            if ((chnl >= 0.5) && (chnl < 2 / 3))
                return p + ((q - p) * (2 / 3 - chnl) * 6);
            else
                return p;
        }
    }
}
