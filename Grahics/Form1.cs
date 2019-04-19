using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grahics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Level: 1 Score: 200 Live: ***";
        }
        

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
                Graphics battlefield = pictureBox1.CreateGraphics();
                SolidBrush c = new SolidBrush(Color.White);
                battlefield.FillEllipse(c, 50, 50, 20, 20);
                battlefield.FillEllipse(c, 60, 250, 20, 20);
                battlefield.FillEllipse(c, 200, 20, 20, 20);
                battlefield.FillEllipse(c, 200, 240, 20, 20);
                battlefield.FillEllipse(c, 300, 60, 20, 20);
                battlefield.FillEllipse(c, 400, 200, 20, 20);
                battlefield.FillEllipse(c, 500, 150, 20, 20);
                battlefield.FillEllipse(c, 550, 270, 20, 20);

                Point point1 = new Point(90, 80);
                Point point2 = new Point(95, 90);
                Point point3 = new Point(110, 90);
                Point point4 = new Point(100, 100);
                Point point5 = new Point(110, 110);
                Point point6 = new Point(95, 110);
                Point point7 = new Point(90, 120);
                Point point8 = new Point(85, 110);
                Point point9 = new Point(70, 110);
                Point point10 = new Point(80, 100);
                Point point11 = new Point(70, 90);
                Point point12 = new Point(85, 90);
                Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12 };
                SolidBrush d = new SolidBrush(Color.Red);
                battlefield.FillPolygon(d, curvePoints);


                Point point26 = new Point(110, 230);
                Point point27 = new Point(115, 240);
                Point point28 = new Point(130, 240);
                Point point29 = new Point(120, 250);
                Point point30 = new Point(130, 260);
                Point point31 = new Point(115, 260);
                Point point32 = new Point(110, 270);
                Point point33 = new Point(105, 260);
                Point point34 = new Point(90, 260);
                Point point35 = new Point(100, 250);
                Point point36 = new Point(90, 240);
                Point point37 = new Point(105, 240);
                Point[] curvePoints2 = { point26, point27, point28, point29, point30, point31, point32, point33, point34, point35, point36, point37 };
                battlefield.FillPolygon(d, curvePoints2);

                Point point38 = new Point(350, 200);
                Point point39 = new Point(355, 210);
                Point point40 = new Point(370, 210);
                Point point41 = new Point(360, 220);
                Point point42 = new Point(370, 230);
                Point point43 = new Point(355, 230);
                Point point44 = new Point(350, 240);
                Point point45 = new Point(345, 230);
                Point point46 = new Point(330, 230);
                Point point47 = new Point(340, 220);
                Point point48 = new Point(330, 210);
                Point point49 = new Point(345, 210);
                Point[] curvePoints3 = { point38, point39, point40, point41, point42, point43, point44, point45, point46, point47, point48, point49 };
                battlefield.FillPolygon(d, curvePoints3);

                Point point50 = new Point(370, 70);
                Point point51 = new Point(375, 80);
                Point point52 = new Point(390, 80);
                Point point53 = new Point(380, 90);
                Point point54 = new Point(390, 100);
                Point point55 = new Point(375, 100);
                Point point56 = new Point(370, 110);
                Point point57 = new Point(365, 100);
                Point point58 = new Point(350, 100);
                Point point59 = new Point(360, 90);
                Point point60 = new Point(350, 80);
                Point point61 = new Point(365, 80);
                Point[] curvePoints4 = { point50, point51, point52, point53, point54, point55, point56, point57, point58, point59, point60, point61 };
                battlefield.FillPolygon(d, curvePoints4);


                Point point13 = new Point(220, 90);
                Point point14 = new Point(250, 110);
                Point point15 = new Point(250, 140);
                Point point16 = new Point(220, 160);
                Point point17 = new Point(190, 140);
                Point point18 = new Point(190, 110);
                Point[] hexagon = { point13, point14, point15, point16, point17, point18 };
                SolidBrush y = new SolidBrush(Color.Yellow);
                battlefield.FillPolygon(y, hexagon);

                Point point19 = new Point(220, 110);
                Point point20 = new Point(235, 120);
                Point point21 = new Point(225, 120);
                Point point22 = new Point(225, 140);
                Point point23 = new Point(215, 140);
                Point point24 = new Point(215, 120);
                Point point25 = new Point(205, 120);
                Point[] arrow = { point19, point20, point21, point22, point23, point24, point25 };
                SolidBrush g = new SolidBrush(Color.Green);
                battlefield.FillPolygon(g, arrow);

                Point point62 = new Point(250, 70);
                Point point63 = new Point(255, 80);
                Point point64 = new Point(270, 85);
                Point point65 = new Point(255, 90);
                Point point66 = new Point(250, 100);
                Point point67 = new Point(245, 90);
                Point point68 = new Point(230, 85);
                Point point69 = new Point(245, 80);
                Point[] cometa = { point62, point63, point64, point65, point66, point67, point68, point69 };
                SolidBrush r = new SolidBrush(Color.Aquamarine);
                battlefield.FillPolygon(r, cometa);
            
        }
    }
}
