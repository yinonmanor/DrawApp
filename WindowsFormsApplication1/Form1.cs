using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        PictureBox pb = new PictureBox();// new PictureBox(700, 700);
        Bitmap bitMap = null;
        Color currentColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            bitMap = new Bitmap(1000, 1000);
            pictureBox1.Image = bitMap;// new Bitmap(700, 700);
           
            radiusTextBox.Text = "radius";
            drawLine(100, 100, 100, 150, currentColor);
            drawCircle(100,100,6, currentColor, bitMap);
            drawPixel(10, 10, currentColor);       
        }


      
        public void drawPixel(int x,int y,Color color)
        {           
            ((Bitmap)pictureBox1.Image).SetPixel(x, y, color);
        }
        
        public void drawLine(int startX, int startY, int endX, int endY,Color color)
        {
            int countX = endX - startX;
            int countY = endY - startY;
            int count = countX > countY ? countX : countY;
            int x = startX;
            int y = startY;
            for(int i=0;i<count;i++,x++,y++)
            {
                drawPixel(x,y,color);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((Bitmap)pictureBox1.Image).SetPixel(100, 100, Color.Black);           
        }

        public void drawCircle(int xCen,int yCen,int rad,Color color,Bitmap bitMap)
        {
            pictureBox1.Image = bitMap;
            int xCenter = xCen;//Convert.ToInt32(xCenterTextBox.Text);
            int yCenter = yCen;// Convert.ToInt32(yCenterTextBox.Text);
            int radius = rad;//Convert.ToInt32(radiusTextBox.Text);
            int x = 0;
            int y = radius;
            int p = 3 - 2 * radius;
            while (y >= x)
            {
                drawPixel(xCenter - x, yCenter - y, color);
                drawPixel(xCenter - y, yCenter - x, color);
                drawPixel(xCenter + y, yCenter - x, color);
                drawPixel(xCenter + x, yCenter - y, color);
                drawPixel(xCenter - x, yCenter + y, color);
                drawPixel(xCenter - y, yCenter + x, color);
                drawPixel(xCenter + y, yCenter + x, color);
                drawPixel(xCenter + x, yCenter + y, color);
                if (p < 0)
                {
                    p += 4 * x + 6;
                    x++;
                }
                else
                {
                    p += 4 * (x - y) + 10;
                    x++; y--;
                }
            }
        }

        public void circleButton_Click(object sender, EventArgs e)
        {
            //drawLine(100, 100, 100, 150, Color.Black);
            int xCenter = Convert.ToInt32(xCenterTextBox.Text);
            int yCenter = Convert.ToInt32(yCenterTextBox.Text);
            int radius = Convert.ToInt32(radiusTextBox.Text);
            drawCircle(xCenter, yCenter, radius, currentColor, bitMap);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }
    }
}
