using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class ShiftDownTransformer : ITransformer<ShiftDownParameters>
    {
        Size oldSize { get; set; }
        double border { get; set; }
        double k { get; set; }

        public Size ResultSize { get; private set; }

        public void Initialize(Size size, ShiftDownParameters parameters)
        {
            oldSize = size;
            ResultSize = oldSize;
            border = Math.Round(parameters.ShiftPercent/100 * size.Height);
            k = parameters.ShiftPercent/100;
        }

        public Point? MapPoint(Point point)
        {
            int x, y;
            x = point.X;
            if (point.Y < border)
                y = point.Y + (int)(oldSize.Height - oldSize.Height * k);
            else
                y = point.Y - (int)(oldSize.Height * k);

            if (y < 0 || y >= ResultSize.Height)
                return null;

            return new Point(x, y);
        }
    }
}
