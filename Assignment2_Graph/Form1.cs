using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2_Graph
{
    public partial class Form1 : Form
    {
        private float[] dataPoints = new float[3];

        public Form1()
        {
            InitializeComponent();
            this.panel1.Paint += new PaintEventHandler(Panel1_Paint);
            this.txtHotPink.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtLightBlue.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtPurple.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            dataPoints[0] = float.TryParse(txtHotPink.Text, out float value1) ? value1 : 0;
            dataPoints[1] = float.TryParse(txtLightBlue.Text, out float value2) ? value2 : 0;
            dataPoints[2] = float.TryParse(txtPurple.Text, out float value3) ? value3 : 0;
            panel1.Invalidate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (dataPoints == null || dataPoints.Length == 0)
                return;

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(50, 50, 200, 200);
            Color[] colors = { Color.HotPink, Color.LightBlue, Color.Purple };

            float total = dataPoints.Sum();
            if (total == 0) return;

            float startAngle = 0;
            for (int i = 0; i < dataPoints.Length; i++)
            {
                if (dataPoints[i] > 0)
                {
                    float sweepAngle = (dataPoints[i] / total) * 360;
                    g.FillPie(new SolidBrush(colors[i]), rect, startAngle, sweepAngle);
                    startAngle += sweepAngle;
                }
            }
        }
    }
}
