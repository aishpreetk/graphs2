using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            string[] inputNumbers = inputTextBox.Text.Split(',');

            List<int> values = new List<int>();
            foreach (string input in inputNumbers)
            {
                if (int.TryParse(input.Trim(), out int value))
                {
                    values.Add(value);
                }
                else
                {
                    MessageBox.Show($"Invalid input: '{input}'. Please enter valid integers separated by commas.");
                    return;
                }
            }

            DrawPieChart(values);
        }

        private void DrawPieChart(List<int> values)
        {
            pictureBoxPie.Image = new Bitmap(pictureBoxPie.Width, pictureBoxPie.Height);
            lblpie.Text = "";

            Graphics g = Graphics.FromImage(pictureBoxPie.Image);
            int total = values.Sum();

            int startAngle = 0;
            Random random = new Random();

            for (int i = 0; i < values.Count; i++)
            {
                int sweepAngle = (int)((double)values[i] / total * 360);
                Brush brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
                g.FillPie(brush, new Rectangle(0, 0, pictureBoxPie.Width, pictureBoxPie.Height), startAngle, sweepAngle);

               lblpie.Text += $"Slice {i + 1}: {values[i]}\n";

                startAngle += sweepAngle;
            }
        }

        
    }
}
