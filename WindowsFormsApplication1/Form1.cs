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
        RADIUS,
        POLYGON_CENTER,
        POLYGON_HEAD

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
            this.BackColor = Color.PowderBlue;
            pictureBox1.BackColor = Color.White;
            polygonTextBox.Enabled = false;
            pictureBox1.MouseDown += (mouseDownEvent);
            pictureBox1.MouseUp += (mouseUpEvent);
           // drawLine(100, 100, 100, 150, currentColor);
           // drawCircle(100,100,6, currentColor, bitMap);
           // drawPixel(10, 10, currentColor);       
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
                    // בחירת הערך המוחלט הגבוה מבין שניהם
                    currentRadius = Math.Abs(currentX - e.X)>Math.Abs(currentY-e.Y)? Math.Abs(currentX - e.X): Math.Abs(currentY - e.Y);
                    drawCircle(currentX, currentY, currentRadius, currentColor, bitMap);
                    stateFlag = State.CERCLE_POSITION;
                    break;

                case State.POLYGON_CENTER:
                    currentX = e.X;
                    currentY = e.Y;
                    stateFlag = State.POLYGON_HEAD;
                    break;

                case State.POLYGON_HEAD:
                    int sides = Convert.ToInt32(polygonTextBox.Text);
                    currentRadius = Math.Abs(currentX - e.X) > Math.Abs(currentY - e.Y) ? Math.Abs(currentX - e.X) : Math.Abs(currentY - e.Y);                   
                    drawPolygon(e.X,e.Y,sides);
                    stateFlag = State.POLYGON_CENTER;
                    break;
            }
            
        }

        /*public void RemoveText(object sender, EventArgs e)
        {
            if(!(radiusTextBox.Text!= "Radius"))
            {
                radiusTextBox.Text = "";
            }
            
        }*/

        /*public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(radiusTextBox.Text))
                radiusTextBox.Text = "Radius";
        }*/


        public void drawPixel(int x,int y,Color color)
        {
            try
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, color);
            }      
            catch(Exception ex)
            {
                return;
            }
            
        }

        

        public void drawLine(int startX, int startY, int endX, int endY,Color color)
        {
            double count;
            double ratioX;
            double ratioY;
            double tempX = startX;
            double tempY = startY;
           
            if (Math.Abs(startX-endX)>Math.Abs(startY-endY))
            {
                count = Math.Abs(startX - endX);
            }
            else
            {
                count = Math.Abs(startY - endY);
            }
            try
            {
                if(count==0)
                {
                    throw new Exception("לא ניתן לצייר קו בין נקודה אחת");
                }
                ratioX = (endX - startX) / count;
                ratioY = (endY - startY) / count;

                while (count >= 0)
                {
                    tempX = (tempX + ratioX);
                    tempY = (tempY + ratioY);
                    drawPixel((int)tempX, (int)tempY, currentColor);
                    count--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    x++;
                    y--;
                }
            }
        }

        public void circleButton_Click(object sender, EventArgs e)
        {
            stateFlag = State.CERCLE_POSITION;
            polygonTextBox.Enabled = false;
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
            
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            stateFlag = State.LINE_FIRST_DOT;
            polygonTextBox.Enabled = false;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            stateFlag = State.POLYGON_CENTER;
            polygonTextBox.Enabled = true;
            polygonTextBox.Focus();
        }

        private void drawPolygon(int headX,int headY,int sides)
        {
            try
            {
                if (sides < 3)
                {
                    throw new Exception("מצולע חייב להיות בעל שלוש צלעות לפחות");
                }
                float step = 360 / sides;
                float angle = 0;
                int count = sides;
                int x, y;
                for(double i=0;i<sides;i++)
                {
                    double radians = angle * Math.PI / 180.0;
                    x =Convert.ToInt32((float)Math.Cos(radians) * currentRadius + headX);
                    y = Convert.ToInt32((float)Math.Sin(-radians) * currentRadius + headY);
                    drawLine(headX, headY, (int)x, (int) y, currentColor);
                    angle += step;
                    headX = x;
                    headY = y;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
