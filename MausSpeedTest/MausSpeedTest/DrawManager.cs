using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MausSpeedTest
{
    class DrawManager
    {
        public static List<Point> Spline(decimal[] x, decimal[] y, int draw_lenght=0)
        {
            if (draw_lenght == 0)
            {
                draw_lenght = x.Count();
            }
            List<Point> Linear = new List<Point>();
            if ((decimal)y.Count() - x.Count()!=0)
            {
                Debug.WriteLine("x and y array count are not equal");
                return Linear;
            }
            int count =0;
            int lower_number=0;
            int higher_number=0;
            while (draw_lenght != count)
            {
                try
                {
                    if (y[count] != count)
                    {


                        lower_number = higher_number;
                        higher_number = count;
                        Linear.Add(new Point(count, (int)((count - x[lower_number]) / (x[higher_number] - x[lower_number]) * (y[lower_number] - y[higher_number]))));

                    }
                    else
                    {
                        try
                        {
                            Linear.Add(new Point(count, (int)((count - x[lower_number]) / (x[higher_number] - x[lower_number]) * (y[lower_number] - y[higher_number]))));
                        }
                        catch (DivideByZeroException) { }
                    }


                }
                catch (IndexOutOfRangeException) { }
                count++;
            }

            return Linear;
        }
    }
}