using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MausSpeedTest
{
    public partial class Form1 : Form
    {
        //Config Begin

           int AverageMaxCount=120;

        //Config End
        int new_mouse_x;
        int new_mouse_y;
        int new_cache_mouse_x;
        int new_cache_mouse_y;

        int _count_range;

        int average_speed_x = 0;
        double[] average_speed_kmh = { 0.0 };
        double[] average_speed_mps = { 0.0 };
        public static string stat_MaxSpeed_cache = "0 | 0";
        public static int stat_counter = 0;
        public static double stat_maxSpeed = 0;

        string _range;
        string _speedkmh;
        string _speedmps;

        public Form1()
        {
            InitializeComponent();

            change_label(false);
            timer1.Start();
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Interval = 1000;
            myTimer.Start();

            Thread save_thread = new Thread(() => save_file_manager.load(this));
            save_thread.Start();
        }
        public void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                _range = _count_range.ToString();
                double mps = ((double.Parse(((_count_range * 1) / int.Parse(textBox1.Text)).ToString()) * 25.4) / 1000.0);
                _speedmps = Math.Round(((decimal)(mps)), 3).ToString();
                _speedkmh = Math.Round(((decimal)(mps * 3.6)), 3).ToString();
                _count_range = 0;




                Debug.WriteLine("AverageCounter" + average_speed_x);
                List<double> aspeedkmh = new List<double>(average_speed_kmh);
                List<double> aspeedmps = new List<double>(average_speed_mps);
                if(aspeedkmh.Count()>= AverageMaxCount)
                {
                    aspeedkmh.RemoveAt(aspeedkmh.Count - 1);
                    aspeedmps.RemoveAt(aspeedmps.Count - 1);
                    Debug.WriteLine("TryDel");
                }
                aspeedkmh.Insert(0, double.Parse(_speedkmh));
                aspeedkmh.Insert(0, double.Parse(_speedmps));
                average_speed_kmh = aspeedkmh.ToArray();
                average_speed_mps = aspeedkmh.ToArray();
                Debug.WriteLine("Number" + aspeedkmh.Count());

            }
            Invalidate();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            speedms.Text = _speedmps;
            speed.Text = _speedkmh;
            range.Text = _range + "px";
            range_stat.Text = stat_counter.ToString() + "px";
            try
            {
                if (double.Parse(_speedmps) >= stat_maxSpeed - (stat_maxSpeed / 4))
                {
                    speed.ForeColor = Color.Orange;
                    speedms.ForeColor = Color.Orange;

                }
                else
                {
                    speed.ForeColor = Color.White;
                    speedms.ForeColor = Color.White;
                }
                if (double.Parse(_speedmps) >= stat_maxSpeed)
                {
                    Debug.WriteLine(_speedmps);
                    stat_maxSpeed = double.Parse(_speedmps);
                    stat_MaxSpeed_cache = _speedkmh + " | " + _speedmps;
                    max_speed.Text = stat_MaxSpeed_cache;
                    if (stat_maxSpeed != 0)
                    {
                        speed.ForeColor = Color.Red;
                        speedms.ForeColor = Color.Red;
                    }
                    else
                    {
                        speed.ForeColor = Color.White;
                        speedms.ForeColor = Color.White;
                    }

                }
            }
            catch (ArgumentNullException)
            {
                max_speed.Text = stat_MaxSpeed_cache;
            }

            new_mouse_x = MousePosition.X;
            new_mouse_y = MousePosition.Y;
            mouse_pos.Text = MousePosition.X.ToString() + " | " + MousePosition.Y.ToString();
            int add_range = (make_number_positive(new_mouse_x - new_cache_mouse_x) + make_number_positive(new_mouse_y - new_cache_mouse_y));
            try
            {
                average_speed_label.Text = Math.Round(average_speed_kmh.Sum() / average_speed_kmh.Count(), 3).ToString() + " | " + Math.Round(average_speed_mps.Sum() / average_speed_mps.Count(), 3).ToString();
            }
            catch (NullReferenceException)
            {
                average_speed_label.Text = "0 | 0";
            }
            catch (ArgumentNullException)
            {
                average_speed_label.Text = "0 | 0";
            }

            stat_counter = add_range + stat_counter;
            _count_range = add_range + _count_range;

            new_cache_mouse_x = new_mouse_x;
            new_cache_mouse_y = new_mouse_y;

        }

        private int make_number_positive(int number)
        {
            if (number < 0)
            {
                number = Math.Abs(number);
            }
            else
            {
            }
            return number;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Array.Clear(average_speed_mps, 0, average_speed_mps.Length);
                Array.Clear(average_speed_kmh, 0, average_speed_kmh.Length);
            }
            catch (NullReferenceException) { }
            stat_maxSpeed = 0;
            try
            {
                int.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "")
            {
                change_label(false);

            }
            else
            {
                change_label(true);
            }
        }
        private void change_label(Boolean state)
        {
            label2.Visible = state;
            label3.Visible = state;
            label4.Visible = state;
            label5.Visible = state;
            label6.Visible = state;
            label7.Visible = state;
            label8.Visible = state;
            speedms.Visible = state;
            speed.Visible = state;
            range.Visible = state;
            range_stat.Visible = state;
            max_speed.Visible = state;
            average_speed_label.Visible = state;
            button1.Visible = state;
            save_checkbox.Visible = state;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Clear(average_speed_mps, 0, average_speed_mps.Length);
            Array.Clear(average_speed_kmh, 0, average_speed_kmh.Length);
            stat_maxSpeed = 0;
            stat_counter = 0;
            stat_MaxSpeed_cache = "0 | 0";
            _speedmps = "0";
            _speedkmh = "0";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (save_checkbox.Checked)
            {
                save_file_manager.save(this);
            }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //set/get voids
        public Boolean get_save_checkbox()
        {
            return save_checkbox.Checked;
        }
        public void set_save_checkbox(Boolean check)
        {
            if (this.save_checkbox.InvokeRequired)
            {
                this.Invoke(new Action<Boolean>(set_save_checkbox), new object[] { check });
                return;
            }
            save_checkbox.Checked = check;
        }
        public String get_dpi()
        {
            return textBox1.Text;
        }
        public void set_dpi(string dpi)
        {
            if (this.textBox1.InvokeRequired)
            {
                this.Invoke(new Action<string>(set_dpi), new object[] { dpi });
                return;
            }
            textBox1.Text = dpi;
        }
        public void set_max_speed(String s)
        {
            if (this.max_speed.InvokeRequired)
            {
                this.Invoke(new Action<string>(set_max_speed), new object[] { s });
                return;
            }
            stat_MaxSpeed_cache = s;
            max_speed.Text = s;
            Debug.WriteLine("Set max-Speed to " + s);
        }

        private void save_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (save_checkbox.Checked) { }
            else
            {
                save_file_manager.save(this);
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (textBox1.Text.Length > 0)
            {
                // Call the OnPaint method of the base class.
                base.OnPaint(pe);
                // Declare and instantiate a new pen.
                Pen myPen = new Pen(Color.Orange, (float)1);

                // Draw an aqua rectangle in the rectangle represented by the control.
                int draw_height = 145;
                int draw_lenght = 500;
                int start = 140;
                List<Point> pointArray = new List<Point>();
                Point last_point = new Point(start, draw_height);
                int number_counter = 0;
                double[] number = new double[5];
                int counter = 0;
                int y = 0;
                int color = 255;
                double pen_width = 2;
                Boolean firstentry = true;
                while ( counter <= (average_speed_kmh.Count())-1 && counter <= draw_lenght)
                {
                    if(number_counter == 5)
                    {
                        y++;
                        y++;
                        if (!firstentry)
                        {
                            pointArray.Add(last_point);
                            pointArray.Add(new Point(start + y, draw_height - (int)(((number[0] + number[1] + number[2] + number[3] + number[4]) / (double)5))));
                            try
                            {
                                color = color - 5;
                                pen_width = pen_width - 0.05;
                                myPen = new Pen(Color.FromArgb(color, 255, 148, 0),(float)pen_width);
                                pe.Graphics.DrawLines(myPen, pointArray.ToArray());
                            }

                            catch (ArgumentException) { }
                        }else
                        {
                            firstentry = false;
                        }
                        last_point =(new Point(start + y, draw_height - (int)((number[0]+ number[1]+ number[2]+ number[3]+ number[4])/(double)5)));
                        pointArray.Clear();
                        number_counter = 0;

                    }
                    else
                    {
                        number[number_counter] = average_speed_kmh[counter]*10;
                        number_counter++;
                    }
                    counter++;
                }

            }
        }
    }
}
