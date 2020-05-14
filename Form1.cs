using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_1
{
    public partial class Form1 : Form
    {

        private int prevX = -1;

        private int prevY = -1;

        private double distance = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void main_button_Click(object sender, EventArgs e)
        {
            if (ShowDialog("Поздравляем! Вы смогли нажать на кнопку!", "Поздравляем!")) {
                System.Windows.Forms.Application.Exit();
            };
        }

        public static bool ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK;
        }

        private void main_button_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (prevX != -1 || prevY != -1)
            {
                int deltaX = Math.Abs(e.X - prevX);
                int deltaY = Math.Abs(e.Y - prevY);
                double newDistance = Math.Sqrt(Math.Pow(e.X - main_button.Location.X, 2) + Math.Pow(e.Y - main_button.Location.Y, 2));
                var t = 1.01 + ((deltaX + deltaY) * 0.001);
                if (deltaY < 10 && deltaY > 0 && newDistance < distance)
                {
                    //int newX = main_button.Location.X + deltaX;
                    //int newY = main_button.Location.Y + deltaY;
                    var newY = (1 - t) * e.Y + t * main_button.Location.Y;
                    if (newY > 0 && (newY < (Height - main_button.Size.Height * 2.5)))
                    {
                        main_button.Location = new Point(main_button.Location.X, Convert.ToInt32(newY));
                    }
                    
                }
                if (deltaX > 0 && deltaX < 10 && newDistance < distance)
                {
                    Double newX = ((1 - t) * e.X + t * main_button.Location.X);
                    if (newX > 0 && (newX < Width - main_button.Size.Width* 1.25)) {
                        main_button.Location = new Point(Convert.ToInt32(newX), main_button.Location.Y);
                    }
                    
                }
                distance = newDistance;
            }
            
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
