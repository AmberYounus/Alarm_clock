using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        string hour, minute, second;
        string user_hour, user_minute;
         SoundPlayer splayer;


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            user_hour = comboBox1.Text;
            user_minute = comboBox2.Text;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            splayer.Stop();
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour + "";
            minute = DateTime.Now.Minute + "";
            second = DateTime.Now.Second + "";
            label1.Text = hour;
            label3.Text = minute;
            label5.Text = second;
            if(hour == user_hour && user_minute == minute)
            {
                timer1.Stop();
                try
                {
                    SoundPlayer splayer = new SoundPlayer();
                    splayer.SoundLocation = @"C:\Users\Gotti\Documents\Visual Studio 2015\Projects\Alarm_Clock\alarm.mp3.wav";
                    splayer.PlayLooping();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
