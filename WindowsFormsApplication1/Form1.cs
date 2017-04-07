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
    enum State
    {
        LINE_FIRST_DOT,
        LINE_SECOND_DOT,
        CERCLE_POSITION,
        RADIUS
    };
    public partial class Form1 : Form
    {      
        PictureBox pb = new PictureBox();// new PictureBox(700, 700);
        Bitmap bitMap = null;
        Color currentColor = Color.Black;
        int currentX;
        int currentY;
        int currentRadius;
        State stateFlag;
        
        public Form1()
        {
            InitializeComponent();
            bitMap = new Bitmap(1000, 1000);
            pictureBox1.Image = bitMap;// new Bitmap(700, 700);
            radiusTextBox.Text = "Radius";
            pictureBox1.BackColor = Color.White;
            radiusTextBox.GotFocus += (RemoveText);
            radiusTextBox.LostFocus += (AddText);
            pictureBox1.MouseDown += (mouseDownEvent);
            pictureBox1.MouseUp += (mouseUpEvent);
            drawLine(100, 100, 100, 150, currentColor);
            drawCircle(100,100,6, currentColor, bitMap);
            drawPixel(10, 10, currentColor);       
        }

        private void mouseUpEvent(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(currentX.ToString());
        }

        private void mouseDownEvent(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = bitMap;
            switch (stateFlag)
            {
                case State.LINE_FIRST_DOT:
                    currentX = e.X;
                    currentY = e.Y;
                    stateFlag = State.LINE_SECOND_DOT;
                    break;

                case State.LINE_SECOND_DOT:
                    drawLine(currentX, currentY, e.X, e.Y, currentColor);
                    stateFlag = State.LINE_FIRST_DOT;
                    break;

                case State.CERCLE_POSITION:
                    currentX = e.X;
                    currentY = e.Y;
                    stateFlag = State.RADIUS;
                    break;

                case State.RADIUS:
                    currentRadius = Math.Abs(currentX - e.X)>Math.Abs(currentY-e.Y)? Math.Abs(currentX - e.X): Math.Abs(currentY - e.Y);
                    drawCircle(currentX, currentY, currentRadius, currentColor, bitMap);
                    stateFlag = State.CERCLE_POSITION;
                    break;

            }
            
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if(!(radiusTextBox.Text!= "Radius"))
            {
                radiusTextBox.Text = "";
            }
            
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(radiusTextBox.Text))
                radiusTextBox.Text = "Radius";
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

       
        public void drawCircle(int xCen,int yCen,int rad,Color color,Bitmap bitMap)
        {
            stateFlag = State.CERCLE_POSITION;
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
            stateFlag = State.CERCLE_POSITION;
            //drawLine(100, 100, 100, 150, Color.Black);
            /*int xCenter = Convert.ToInt32(xCenterTextBox.Text);
            int yCenter = Convert.ToInt32(yCenterTextBox.Text);
            int radius = Convert.ToInt32(radiusTextBox.Text);
            drawCircle(xCenter, yCenter, radius, currentColor, bitMap);*/
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            int i = 0;
            int currentX = Cursor.Position.X;
            int currentY = Cursor.Position.Y;
            
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            stateFlag = State.LINE_FIRST_DOT;
        }
    }
}
