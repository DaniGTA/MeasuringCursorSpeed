using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MausSpeedTest
{
    class save_file_manager
    {
        public static string[] lines;
        public static void save(Form1 a)
        {

            string[] lines = {
            "Save="+a.get_save_checkbox().ToString(),
            "dpi="+a.get_dpi(),
            "counter="+Form1.stat_counter.ToString(),
            "max_speed="+Form1.stat_maxSpeed.ToString(),
            "max_speed_cache="+Form1.stat_MaxSpeed_cache
        };
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SpeedMouseStats.cfg"), lines);
        }
        public static void load(Form1 a)
        {

            Thread.Sleep(1500);
            try
            {
                lines = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SpeedMouseStats.cfg"));

                foreach (string line in lines)
                {
                    string[] data = line.Split('=');
                    switch (data[0])
                    {
                        case ("Save"):
                            a.set_save_checkbox(Boolean.Parse(data[1]));
                            if (!Boolean.Parse(data[1]))
                            {
                                return;
                            }
                            break;
                        case ("dpi"):
                            a.set_dpi(data[1]);
                            break;
                        case ("max_speed_cache"):
                            Form1.stat_MaxSpeed_cache = data[1];
                            a.set_max_speed(data[1]);
                            break;
                        case ("max_speed"):
                            Form1.stat_maxSpeed = Double.Parse(data[1]);
                            break;
                        case ("counter"):
                            Form1.stat_counter = int.Parse(data[1]);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (IOException) { }
        }
    }
}
