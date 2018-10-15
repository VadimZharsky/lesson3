using Microsoft.Win32;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;


namespace WpfApplication1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }
        public async void fornewthread()
        {
            OpenFileDialog streamer = new OpenFileDialog();
            streamer.Filter = "ALL|*.*|NCF|*.ncf";
            //MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
            if (streamer.ShowDialog() == true)
            {

                StreamReader str = new StreamReader(streamer.FileName);
                string line = str.ReadToEnd();
                string[] arr = line.Split('\n');
                foreach (string s in arr)
                {
                    string st = s.TrimEnd() + ";" + "\n";

                    Dispatcher.Invoke((Action)(() => this.TextBox1.AppendText(st)));
                    Regex Gcode = new Regex("([GXYFZIJPMS][+-]?[0-9]*\\.?[0-9]*)");
                    string g = Gcode.Match(st).ToString();
                    MatchCollection collect = Gcode.Matches(st);
                    string Offset; //g54-g59, 
                    string Interpol; //g41,g42,g40
                    string Replace; //g0,g1,g2,g3
                    string Cycle; //g81,g82,g83,g84,g85,g80
                    string X_p, Y_p, Z_p;
                    string X_n, Y_n, Z_n;
                    string spSpeed, feed;
                    int modul, coolant, prStop, spindle; //m8-m9|m3-m5
                    foreach (Match m in collect)
                    {
                        //TextBox2.AppendText(m.Value);
                        if (m.Value.StartsWith("X"))
                        {

                            X_n = m.Value.ToString().Replace("X", "");
                            Dispatcher.Invoke((Action)(() => this.x_cord.Content = X_n));
                            X_p = X_n;
                        }
                        if (m.Value.StartsWith("Y"))
                        {

                            Y_n = m.Value.ToString().Replace("Y", "");
                            Dispatcher.Invoke((Action)(() => this.y_cord.Content = Y_n));
                            Y_p = Y_n;
                        }
                        if (m.Value.StartsWith("Z"))
                        {

                            Z_n = m.Value.ToString().Replace("Z", "");
                            Dispatcher.Invoke((Action)(() => this.z_cord.Content = Z_n));
                            Z_p = Z_n;
                        }
                        if (m.Value.StartsWith("F"))
                        {

                            feed = m.Value.ToString().Replace("F", "");
                            Dispatcher.Invoke((Action)(() => this.feed.Content = feed));

                        }
                        if (m.Value.StartsWith("S"))
                        {

                            spSpeed = m.Value.ToString().Replace("S", "");
                            Dispatcher.Invoke((Action)(() => this.spindle.Content = spSpeed));
                        }
                    }
                    Thread.Sleep(100);

                    //Thread.SpinWait(3);
                    //splitter(st); 
                }
            }

        }


        private  void Button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog streamer = new OpenFileDialog();
            streamer.Filter = "ALL|*.*|NCF|*.ncf";
            if (streamer.ShowDialog() == true)
            {
                MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
                StreamReader str = new StreamReader(streamer.FileName);
                string line = str.ReadToEnd();
                string[] arr = line.Split('\n');

                foreach (string s in arr)
                {
                    
                    string st = s.TrimEnd() + ";" + "\n";
                    splitter(st);
                    Thread.CurrentThread.Abort();
                    
                }
                
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            



        }

        public  void splitter(string s)
        {
            TextBox1.AppendText(s);
            Regex Gcode = new Regex("([GXYZIJPMS][+-]?[0-9]*\\.?[0-9]*)");
            string g = Gcode.Match(s).ToString();
            
            
            MatchCollection collect = Gcode.Matches(s);
            string Offset; //g54-g59, 
            string Interpol; //g41,g42,g40
            string Replace; //g0,g1,g2,g3
            string Cycle; //g81,g82,g83,g84,g85,g80
            string X_p, Y_p, Z_p;
            string X_n, Y_n, Z_n;
            int spSpeed, feed;
            int modul, coolant, prStop, spindle; //m8-m9|m3-m5
            foreach (Match m in collect)
            {
                TextBox2.AppendText(m.Value);
                if (m.Value.StartsWith("X"))
                {

                    X_n = m.Value.ToString().Replace("X", "");
                    x_cord.Content = X_n;
                    X_p = X_n;
                }
                if (m.Value.StartsWith("Y"))
                {

                    Y_n = m.Value.ToString().Replace("Y", "");
                    y_cord.Content = Y_n;
                    Y_p = Y_n;
                }
                if (m.Value.StartsWith("Z"))
                {

                    Z_n = m.Value.ToString().Replace("Z", "");
                    z_cord.Content = Z_n;
                    Z_p = Z_n;
                }
            }
            TextBox2.AppendText("\n"); 
        }

        private void Button3_Click_1(object sender, RoutedEventArgs e)
        {
            Thread mythread = new Thread(fornewthread);
            mythread.Start();
            
            
        }
    }
}

