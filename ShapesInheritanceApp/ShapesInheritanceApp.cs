using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;

namespace ShapesInheritanceApp
{
    public partial class ShapesInheritanceApp : Form
    {
        public List<Quadrilateral> QuadrilateralList = new List<Quadrilateral>();

        public ShapesInheritanceApp()
        {
            InitializeComponent();
            ResetPointFields();
            ResetImageSection();
            SetOuputBoxHeader();

        }

        private void shapePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetPointFields();
            ResetImageSection();
            ToggleActiveInputs();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Quadrilateral quad = null;
            ResetImageSection();

            if (ValidateFields()) {
                quad = CreateShape();

                Txt_Description.Text = quad.Description;
                TxtBox_RunningTotal.Text += quad.ObjectInfo;
                PopulateImageSection(quad);
                QuadrilateralList.Add(quad);
            }

            ResetPointFields();
        }

        private void SetOuputBoxHeader()
        {
            TxtBox_RunningTotal.Text = "_______________|__X1__|__Y1__|__X2__|__Y2__|__X3__|__Y3__|__X4__|__Y4__|__AREA__|__PERIMETER__|\n";
        }

        private void PopulateImageSection(Quadrilateral quad)
        {
            if (quad is Square)
                Img_Diagram.Image = Properties.Resources.square;
            if (quad is ShapesLibrary.Rectangle && !(quad is Square))
                Img_Diagram.Image = Properties.Resources.rectangle;
            if (quad is Parallelogram && !(quad is ShapesLibrary.Rectangle))
                Img_Diagram.Image = Properties.Resources.parallelogram;
            if (quad is Trapezoid)
                Img_Diagram.Image = Properties.Resources.trapezoid;

            Img_Diagram.Refresh();
            Img_Diagram.Visible = true;

            var temp = quad.GetPoint(1);
            Txt_Image1.Text = $"P1 = {temp.X},{temp.Y}";
            temp = quad.GetPoint(2);
            Txt_Image2.Text = $"P2 = {temp.X},{temp.Y}";
            temp = quad.GetPoint(3);
            Txt_Image3.Text = $"P3 = {temp.X},{temp.Y}";
            temp = quad.GetPoint(4);
            Txt_Image4.Text = $"P4 = {temp.X},{temp.Y}";
        }

        private void ResetPointFields()
        {
            //Reset Point fields
            P1_X.Text = "";
            P1_Y.Text = "";
            P2_X.Text = "";
            P2_Y.Text = "";
            P3_X.Text = "";
            P3_Y.Text = "";
            P4_X.Text = "";
            P4_Y.Text = "";
        }

        private void ResetImageSection()
        {
            //Reset Image section
            Txt_Image1.Text = "";
            Txt_Image2.Text = "";
            Txt_Image3.Text = "";
            Txt_Image4.Text = "";
            Img_Diagram.Image = null;
        }

        private void ToggleActiveInputs()
        {
            Btn_Calculate.Enabled = true;
            switch (shapePicker.Text[0])
            {
                case 'S':
                    Ctn_Point1.Enabled = true;
                    Ctn_Point2.Enabled = true;
                    Ctn_Point3.Enabled = false;
                    Ctn_Point4.Enabled = false;
                    break;
                case 'T':
                    Ctn_Point1.Enabled = true;
                    Ctn_Point2.Enabled = true;
                    Ctn_Point3.Enabled = true;
                    Ctn_Point4.Enabled = true;
                    break;
                case 'R':
                    Ctn_Point1.Enabled = true;
                    Ctn_Point2.Enabled = false;
                    Ctn_Point3.Enabled = true;
                    Ctn_Point4.Enabled = false;
                    break;
                case 'P':
                    Ctn_Point1.Enabled = true;
                    Ctn_Point2.Enabled = true;
                    Ctn_Point3.Enabled = true;
                    Ctn_Point4.Enabled = false;
                    break;
                default:
                    Btn_Calculate.Enabled = false;
                    break;
            }
        }

        private Quadrilateral CreateShape()
        {
            Quadrilateral returnable = null;
            List<PolygonPoint> points = new List<PolygonPoint>();
            switch (shapePicker.Text[0])
            {
                case 'S':
                    //make a square
                    points.Add(new PolygonPoint(int.Parse(P1_X.Text), int.Parse(P1_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P2_X.Text), int.Parse(P2_Y.Text)));
                    returnable = new Square(points);
                    break;
                case 'T':
                    //make a trapezoid
                    points.Add(new PolygonPoint(int.Parse(P1_X.Text), int.Parse(P1_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P2_X.Text), int.Parse(P2_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P3_X.Text), int.Parse(P3_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P4_X.Text), int.Parse(P4_Y.Text)));
                    returnable = new Trapezoid(points);
                    break;
                case 'R':
                    //make a rectangle
                    points.Add(new PolygonPoint(int.Parse(P1_X.Text), int.Parse(P1_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P3_X.Text), int.Parse(P3_Y.Text)));
                    returnable = new ShapesLibrary.Rectangle(points);
                    break;
                case 'P':
                    //make a parallelogram
                    points.Add(new PolygonPoint(int.Parse(P1_X.Text), int.Parse(P1_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P2_X.Text), int.Parse(P2_Y.Text)));
                    points.Add(new PolygonPoint(int.Parse(P3_X.Text), int.Parse(P3_Y.Text)));
                    returnable = new Parallelogram(points);
                    break;
            }

            return returnable;
        }

        private bool ValidateFields()
        {
            bool succeed = true;
            if(!TryValidate(P1_X, P1_Y))
            {
                succeed = false;
            }

            if(Ctn_Point2.Enabled)
                if (!TryValidate(P2_X, P2_Y))
                {
                    succeed = false;
                }

            if (Ctn_Point3.Enabled)
                if (!TryValidate(P3_X, P3_Y))
                {
                    succeed = false;
                }

            if (Ctn_Point4.Enabled)
                if (!TryValidate(P4_X, P4_Y))
                {
                    succeed = false;
                }

            return succeed;
        }

        private bool TryValidate(TextBox tbx, TextBox tby)
        {
            bool succeed = false;
            try
            {
                int tempX = int.Parse(tbx.Text);
                int tempY = int.Parse(tbx.Text);

                if (tempX < 0 || tempY < 0)
                    throw new ArgumentOutOfRangeException();

                succeed = true;
            }
            catch (ArgumentOutOfRangeException rangeException)
            {
                MessageBox.Show($"Values can't be negative numbers for {tbx.Name} or {tby.Name}", "Negative Number Detected!");
                Debug.WriteLine(rangeException.Message, "Exception");
            }
            catch(Exception e)
            {
                MessageBox.Show($"Converting string to int failed for {tbx.Name} or {tby.Name}", "Parsing Error Detected!");
                Debug.WriteLine(e.Message, "Exception");
            }

            return succeed;
        }

        private void Btn_Count_Click(object sender, EventArgs e)
        {
            int squares = 0;
            int traps = 0;
            int rects = 0;
            int parls = 0;

            foreach (Quadrilateral quad in QuadrilateralList)
            {
                if (quad is Square)
                {
                    squares++;
                    continue;
                }
                if(quad is ShapesLibrary.Rectangle)
                {
                    rects++;
                    continue;
                }
                if (quad is Parallelogram)
                    parls++;
                if (quad is Trapezoid)
                    traps++;
            }

            Txt_SquareCount.Text = $"Squares: {squares}";
            Txt_TrapCount.Text = $"Trapezoids: {traps}";
            Txt_RectCount.Text = $"Rectangles: {rects}";
            Txt_ParlCount.Text = $"Parallelogram: {parls}";
        }
    }
}
