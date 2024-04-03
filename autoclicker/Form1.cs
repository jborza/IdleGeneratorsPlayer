using MovablePython;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hotkey hk = new Hotkey();
            hk.KeyCode = Keys.Oemtilde;
            //hk.KeyCode = Keys.A;
            hk.Pressed += Hk_Pressed;
            hk.Register(this);
            Hotkey hkCapture = new Hotkey();
            hkCapture.KeyCode = Keys.D1;
            hkCapture.Pressed += HkCapture_Pressed;
            hkCapture.Register(this);

        }

        private void HkCapture_Pressed(object sender, HandledEventArgs e)

        {
            string s = "";
            s += Cursor.Position.X + ",";
            s += Cursor.Position.Y;
            s += Environment.NewLine;
            textBoxDump.Text += s;
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            List<Point> points = new List<Point>
            {
                new Point(450, 88),
                new Point(750, 78),
                new Point(450, 160), //2nd
                new Point(750, 150),
                new Point(450, 226), //3rd
                new Point(755, 214),
                new Point(450,289), //4th
                new Point(750,281),
                new Point(450,356), //5th
                new Point(750,347),
                new Point(450,425), //6th
                new Point(750,412),
                new Point(450,490), //7th
                new Point(750,482)

            };
            foreach (var point in points)
            {
                moveMouse(point.X, point.Y);
                click();
                Thread.Sleep(1);
            }
        }

        private void moveMouse(int x, int y)
        {
            Cursor.Position = new Point(x, y);
        }

        bool started = false;


        //mouse event constants
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        //input type constant
        const int INPUT_MOUSE = 0;

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs,
                                   int cbSize);

        void click()
        {
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = Cursor.Position.X;
            i.mi.dy = Cursor.Position.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            started = true;
            timerClick.Interval = int.Parse(textTime.Text);
            timerClick.Start();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            started = false;
            timerClick.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Hk_Pressed(object sender, HandledEventArgs e)
        {
            if (started)
            {
                stop();
            }
            else
            {
                start();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode + "");
        }
    }
}
