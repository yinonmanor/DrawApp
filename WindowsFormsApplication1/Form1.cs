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
        POLYGON_HEAD,
        CURRVE_FIRST_DOT,
        CURRVE_SECOND_DOT,
        CURRVE_THIRD_DOT,
        CURRVE_FOURTH_DOT
    };
    public partial class Form1 : Form
    {      
        PictureBox pb = new PictureBox();// new PictureBox(700, 700);
        Bitmap bitMap = null;
        Color currentColor = Color.Black;
        int currentX;
        int currentY;
        int currentRadius;
        int[] currveDots = new int[8];
        State stateFlag;
        
        public Form1()
        {
            InitializeComponent();
            bitMap = new Bitmap(1000, 1000);
            pictureBox1.Image = bitMap;// new Bitmap(700, 700);
            this.BackColor = Color.PowderBlue;
            pictureBox1.BackColor = Color.White;
            polygonTextBox.Enabled = false;
            currveTextBox.Enabled = false;
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
            
            int[] crvFirst = new int[2];
            int[] crvSecond = new int[2];
            int[] crvThird = new int[2];
            int[] crvFourth = new int[2];
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

                case State.CURRVE_FIRST_DOT:
                    currveDots[0] = e.X;
                    currveDots[1] = e.Y;
                    crvFirst[0] = e.X;
                    crvFirst[1] = e.Y;
                    drawPixel(e.X, e.Y, Color.Red);
                    drawPixel(e.X + 1, e.Y, Color.Red);
                    drawPixel(e.X - 1, e.Y, Color.Red);
                    drawPixel(e.X, e.Y + 1, Color.Red);
                    drawPixel(e.X, e.Y - 1, Color.Red);
                    stateFlag = State.CURRVE_SECOND_DOT;
                    break;

                case State.CURRVE_SECOND_DOT:
                    currveDots[2] = e.X;
                    currveDots[3] = e.Y;
                    crvSecond[0] = e.X;
                    crvSecond[1] = e.Y;
                    drawPixel(e.X, e.Y, Color.Red);
                    drawPixel(e.X + 1, e.Y, Color.Red);
                    drawPixel(e.X - 1, e.Y, Color.Red);
                    drawPixel(e.X, e.Y + 1, Color.Red);
                    drawPixel(e.X, e.Y - 1, Color.Red);
                    stateFlag = State.CURRVE_THIRD_DOT;
                    break;

                case State.CURRVE_THIRD_DOT:
                    currveDots[4] = e.X;
                    currveDots[5] = e.Y;
                    crvThird[0] = e.X;
                    crvThird[1] = e.Y;
                    drawPixel(e.X, e.Y, Color.Red);
                    drawPixel(e.X + 1, e.Y, Color.Red);
                    drawPixel(e.X - 1, e.Y, Color.Red);
                    drawPixel(e.X, e.Y + 1, Color.Red);
                    drawPixel(e.X, e.Y - 1, Color.Red);
                    stateFlag = State.CURRVE_FOURTH_DOT;
                    break;

                case State.CURRVE_FOURTH_DOT:
                    currveDots[6] = e.X;
                    currveDots[7] = e.Y;
                    crvFourth[0] = e.X;
                    crvFourth[1] = e.Y;
                    drawPixel(e.X, e.Y, Color.Red);
                    drawPixel(e.X + 1, e.Y, Color.Red);
                    drawPixel(e.X - 1, e.Y, Color.Red);
                    drawPixel(e.X, e.Y + 1, Color.Red);
                    drawPixel(e.X, e.Y - 1, Color.Red);
                    stateFlag = State.CURRVE_FIRST_DOT;
                    //drawCurrve(crvFirst, crvSecond, crvThird, crvFourth);
                    drawCurrve(currveDots);
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
            currveTextBox.Enabled = false;
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
            currveTextBox.Enabled = false;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            stateFlag = State.POLYGON_CENTER;
            polygonTextBox.Enabled = true;
            currveTextBox.Enabled = false;
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
                float angle = 2;
                int count = sides;
                int x, y;
                for(double i=0;i<sides;i++)
                {
                    double radians = angle * Math.PI / 180.0;
                    x =Convert.ToInt32((float)Math.Cos(radians) * currentRadius + headX);
                    y = Convert.ToInt32((float)Math.Sin(-radians) * currentRadius + headY);
                    drawLine(headX, headY,x,y, currentColor);
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

        private void currveButton_Click(object sender, EventArgs e)
        {
            polygonTextBox.Enabled = false;
            currveTextBox.Enabled = true;
            currveTextBox.Focus();
            stateFlag = State.CURRVE_FIRST_DOT;
        }

        private void drawCurrve(int[] dots)
        {
            try
            {
                int sides;// = Convert.ToInt32(currveTextBox.Text);
                bool isNumeric = int.TryParse(currveTextBox.Text, out sides);
                if (isNumeric==false)
                {
                    throw new Exception("הערך חייב להיות מספרי");
                }
                int length = dots.Length - 2;
                for (int i = 0; i < length; i += 2)
                {
                    drawLine(dots[i], dots[i + 1], dots[i + 2], dots[i + 3], currentColor);
                }
            }
            catch(Exception ex)
            {
                int length = dots.Length;
                for(int i=0;i<length;i+=2)
                {
                    drawPixel(dots[i], dots[i + 1],Color.White);
                    drawPixel(dots[i]+1, dots[i + 1], Color.White);
                    drawPixel(dots[i]-1, dots[i + 1], Color.White);
                    drawPixel(dots[i], dots[i + 1]+1, Color.White);
                    drawPixel(dots[i], dots[i + 1]-1, Color.White);
                }
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
