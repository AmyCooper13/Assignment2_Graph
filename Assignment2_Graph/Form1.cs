using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2_Graph
{
    public partial class Form1 : Form
    {    //Array to store dataPoints for pie chart
        private float[] dataPoints = new float[3];

        public Form1() //Constructor and eventHandlers for the panel and text boxes
        {
            InitializeComponent();
            this.panel1.Paint += new PaintEventHandler(Panel1_Paint);
            this.txtHotPink.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtLightBlue.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtPurple.TextChanged += new EventHandler(TextBox_TextChanged);
        }
        //Event handler for text box changes
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //respondes to the change in each text box. If no value is entered then value is automatically zero and nothing is displayed.
            dataPoints[0] = float.TryParse(txtHotPink.Text, out float value1) ? value1 : 0;
            dataPoints[1] = float.TryParse(txtLightBlue.Text, out float value2) ? value2 : 0;
            dataPoints[2] = float.TryParse(txtPurple.Text, out float value3) ? value3 : 0;
            panel1.Invalidate();//trigger
        }
        //Event handler for painting the pie chart onto the panel
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {     
            if (dataPoints == null || dataPoints.Length == 0)// If the values are empty then nothing is drawn
                return;
            //Used to draw on the panel, where the pie chart will be drawn and the colours used in the chart
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(50, 50, 200, 200);
            Color[] colors = { Color.HotPink, Color.LightBlue, Color.Purple };
            //calculates the total value of the data points
            float total = dataPoints.Sum();
            if (total == 0) return;// if the total value is zero pie chart will not be drawn
            //start angle for the first slice of the pie chart
            float startAngle = 0;
            for (int i = 0; i < dataPoints.Length; i++)//loop through each data point
            {
                if (dataPoints[i] > 0)// only draw the slices for values above zero
                {
                    float sweepAngle = (dataPoints[i] / total) * 360;//calculate sweep 
                    g.FillPie(new SolidBrush(colors[i]), rect, startAngle, sweepAngle);//draw the slice using the calculated angles and match the colour
                    startAngle += sweepAngle;//update the start angle for the next slice
                }
            }
        }
    }
}
