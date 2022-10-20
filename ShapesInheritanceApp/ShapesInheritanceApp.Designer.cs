namespace ShapesInheritanceApp
{
    partial class ShapesInheritanceApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ctn_DropdownContainer = new System.Windows.Forms.GroupBox();
            this.Ctn_CountContainer = new System.Windows.Forms.GroupBox();
            this.Txt_ParlCount = new System.Windows.Forms.Label();
            this.Txt_TrapCount = new System.Windows.Forms.Label();
            this.Txt_RectCount = new System.Windows.Forms.Label();
            this.Txt_SquareCount = new System.Windows.Forms.Label();
            this.shapePicker = new System.Windows.Forms.ComboBox();
            this.Ctn_PointTextBoxes = new System.Windows.Forms.GroupBox();
            this.Ctn_Point4 = new System.Windows.Forms.GroupBox();
            this.P4_X = new System.Windows.Forms.TextBox();
            this.P4_Y = new System.Windows.Forms.TextBox();
            this.Ctn_Point3 = new System.Windows.Forms.GroupBox();
            this.P3_X = new System.Windows.Forms.TextBox();
            this.P3_Y = new System.Windows.Forms.TextBox();
            this.Ctn_Point2 = new System.Windows.Forms.GroupBox();
            this.P2_X = new System.Windows.Forms.TextBox();
            this.P2_Y = new System.Windows.Forms.TextBox();
            this.Ctn_Point1 = new System.Windows.Forms.GroupBox();
            this.P1_Y = new System.Windows.Forms.TextBox();
            this.P1_X = new System.Windows.Forms.TextBox();
            this.Ctn_ImageContainer = new System.Windows.Forms.GroupBox();
            this.Txt_Image4 = new System.Windows.Forms.Label();
            this.Txt_Image3 = new System.Windows.Forms.Label();
            this.Txt_Image2 = new System.Windows.Forms.Label();
            this.Txt_Image1 = new System.Windows.Forms.Label();
            this.Img_Diagram = new System.Windows.Forms.PictureBox();
            this.TxtBox_RunningTotal = new System.Windows.Forms.RichTextBox();
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.Btn_Count = new System.Windows.Forms.Button();
            this.Txt_Description = new System.Windows.Forms.RichTextBox();
            this.Ctn_DropdownContainer.SuspendLayout();
            this.Ctn_CountContainer.SuspendLayout();
            this.Ctn_PointTextBoxes.SuspendLayout();
            this.Ctn_Point4.SuspendLayout();
            this.Ctn_Point3.SuspendLayout();
            this.Ctn_Point2.SuspendLayout();
            this.Ctn_Point1.SuspendLayout();
            this.Ctn_ImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // Ctn_DropdownContainer
            // 
            this.Ctn_DropdownContainer.Controls.Add(this.Ctn_CountContainer);
            this.Ctn_DropdownContainer.Controls.Add(this.shapePicker);
            this.Ctn_DropdownContainer.Location = new System.Drawing.Point(12, 12);
            this.Ctn_DropdownContainer.Name = "Ctn_DropdownContainer";
            this.Ctn_DropdownContainer.Size = new System.Drawing.Size(201, 129);
            this.Ctn_DropdownContainer.TabIndex = 0;
            this.Ctn_DropdownContainer.TabStop = false;
            this.Ctn_DropdownContainer.Text = "Pick A Shape";
            // 
            // Ctn_CountContainer
            // 
            this.Ctn_CountContainer.Controls.Add(this.Txt_ParlCount);
            this.Ctn_CountContainer.Controls.Add(this.Txt_TrapCount);
            this.Ctn_CountContainer.Controls.Add(this.Txt_RectCount);
            this.Ctn_CountContainer.Controls.Add(this.Txt_SquareCount);
            this.Ctn_CountContainer.Location = new System.Drawing.Point(7, 43);
            this.Ctn_CountContainer.Name = "Ctn_CountContainer";
            this.Ctn_CountContainer.Size = new System.Drawing.Size(188, 80);
            this.Ctn_CountContainer.TabIndex = 1;
            this.Ctn_CountContainer.TabStop = false;
            // 
            // Txt_ParlCount
            // 
            this.Txt_ParlCount.AutoSize = true;
            this.Txt_ParlCount.Location = new System.Drawing.Point(88, 41);
            this.Txt_ParlCount.Name = "Txt_ParlCount";
            this.Txt_ParlCount.Size = new System.Drawing.Size(82, 13);
            this.Txt_ParlCount.TabIndex = 3;
            this.Txt_ParlCount.Text = "Parallelogram: 0";
            // 
            // Txt_TrapCount
            // 
            this.Txt_TrapCount.AutoSize = true;
            this.Txt_TrapCount.Location = new System.Drawing.Point(88, 16);
            this.Txt_TrapCount.Name = "Txt_TrapCount";
            this.Txt_TrapCount.Size = new System.Drawing.Size(66, 13);
            this.Txt_TrapCount.TabIndex = 2;
            this.Txt_TrapCount.Text = "Trapezoid: 0";
            // 
            // Txt_RectCount
            // 
            this.Txt_RectCount.AutoSize = true;
            this.Txt_RectCount.Location = new System.Drawing.Point(6, 41);
            this.Txt_RectCount.Name = "Txt_RectCount";
            this.Txt_RectCount.Size = new System.Drawing.Size(68, 13);
            this.Txt_RectCount.TabIndex = 1;
            this.Txt_RectCount.Text = "Rectangle: 0";
            // 
            // Txt_SquareCount
            // 
            this.Txt_SquareCount.AutoSize = true;
            this.Txt_SquareCount.Location = new System.Drawing.Point(6, 16);
            this.Txt_SquareCount.Name = "Txt_SquareCount";
            this.Txt_SquareCount.Size = new System.Drawing.Size(53, 13);
            this.Txt_SquareCount.TabIndex = 0;
            this.Txt_SquareCount.Text = "Square: 0";
            // 
            // shapePicker
            // 
            this.shapePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shapePicker.FormattingEnabled = true;
            this.shapePicker.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Parallelogram",
            "Trapezoid"});
            this.shapePicker.Location = new System.Drawing.Point(3, 16);
            this.shapePicker.Name = "shapePicker";
            this.shapePicker.Size = new System.Drawing.Size(195, 21);
            this.shapePicker.TabIndex = 0;
            this.shapePicker.SelectedIndexChanged += new System.EventHandler(this.shapePicker_SelectedIndexChanged);
            // 
            // Ctn_PointTextBoxes
            // 
            this.Ctn_PointTextBoxes.Controls.Add(this.Ctn_Point4);
            this.Ctn_PointTextBoxes.Controls.Add(this.Ctn_Point3);
            this.Ctn_PointTextBoxes.Controls.Add(this.Ctn_Point2);
            this.Ctn_PointTextBoxes.Controls.Add(this.Ctn_Point1);
            this.Ctn_PointTextBoxes.Location = new System.Drawing.Point(219, 12);
            this.Ctn_PointTextBoxes.Name = "Ctn_PointTextBoxes";
            this.Ctn_PointTextBoxes.Size = new System.Drawing.Size(161, 129);
            this.Ctn_PointTextBoxes.TabIndex = 1;
            this.Ctn_PointTextBoxes.TabStop = false;
            this.Ctn_PointTextBoxes.Text = "Enter your point values";
            // 
            // Ctn_Point4
            // 
            this.Ctn_Point4.Controls.Add(this.P4_X);
            this.Ctn_Point4.Controls.Add(this.P4_Y);
            this.Ctn_Point4.Location = new System.Drawing.Point(84, 74);
            this.Ctn_Point4.Name = "Ctn_Point4";
            this.Ctn_Point4.Size = new System.Drawing.Size(72, 49);
            this.Ctn_Point4.TabIndex = 4;
            this.Ctn_Point4.TabStop = false;
            this.Ctn_Point4.Text = "Point 4";
            // 
            // P4_X
            // 
            this.P4_X.Location = new System.Drawing.Point(6, 19);
            this.P4_X.Name = "P4_X";
            this.P4_X.Size = new System.Drawing.Size(25, 20);
            this.P4_X.TabIndex = 6;
            // 
            // P4_Y
            // 
            this.P4_Y.Location = new System.Drawing.Point(37, 19);
            this.P4_Y.Name = "P4_Y";
            this.P4_Y.Size = new System.Drawing.Size(25, 20);
            this.P4_Y.TabIndex = 7;
            // 
            // Ctn_Point3
            // 
            this.Ctn_Point3.Controls.Add(this.P3_X);
            this.Ctn_Point3.Controls.Add(this.P3_Y);
            this.Ctn_Point3.Location = new System.Drawing.Point(84, 19);
            this.Ctn_Point3.Name = "Ctn_Point3";
            this.Ctn_Point3.Size = new System.Drawing.Size(72, 49);
            this.Ctn_Point3.TabIndex = 3;
            this.Ctn_Point3.TabStop = false;
            this.Ctn_Point3.Text = "Point 3";
            // 
            // P3_X
            // 
            this.P3_X.Location = new System.Drawing.Point(6, 19);
            this.P3_X.Name = "P3_X";
            this.P3_X.Size = new System.Drawing.Size(25, 20);
            this.P3_X.TabIndex = 4;
            // 
            // P3_Y
            // 
            this.P3_Y.Location = new System.Drawing.Point(37, 19);
            this.P3_Y.Name = "P3_Y";
            this.P3_Y.Size = new System.Drawing.Size(25, 20);
            this.P3_Y.TabIndex = 5;
            // 
            // Ctn_Point2
            // 
            this.Ctn_Point2.Controls.Add(this.P2_X);
            this.Ctn_Point2.Controls.Add(this.P2_Y);
            this.Ctn_Point2.Location = new System.Drawing.Point(6, 19);
            this.Ctn_Point2.Name = "Ctn_Point2";
            this.Ctn_Point2.Size = new System.Drawing.Size(72, 49);
            this.Ctn_Point2.TabIndex = 2;
            this.Ctn_Point2.TabStop = false;
            this.Ctn_Point2.Text = "Point 2";
            // 
            // P2_X
            // 
            this.P2_X.Location = new System.Drawing.Point(6, 19);
            this.P2_X.Name = "P2_X";
            this.P2_X.Size = new System.Drawing.Size(25, 20);
            this.P2_X.TabIndex = 2;
            // 
            // P2_Y
            // 
            this.P2_Y.Location = new System.Drawing.Point(37, 19);
            this.P2_Y.Name = "P2_Y";
            this.P2_Y.Size = new System.Drawing.Size(25, 20);
            this.P2_Y.TabIndex = 3;
            // 
            // Ctn_Point1
            // 
            this.Ctn_Point1.Controls.Add(this.P1_Y);
            this.Ctn_Point1.Controls.Add(this.P1_X);
            this.Ctn_Point1.Location = new System.Drawing.Point(6, 74);
            this.Ctn_Point1.Name = "Ctn_Point1";
            this.Ctn_Point1.Size = new System.Drawing.Size(72, 49);
            this.Ctn_Point1.TabIndex = 0;
            this.Ctn_Point1.TabStop = false;
            this.Ctn_Point1.Text = "Point 1";
            // 
            // P1_Y
            // 
            this.P1_Y.Location = new System.Drawing.Point(37, 19);
            this.P1_Y.Name = "P1_Y";
            this.P1_Y.Size = new System.Drawing.Size(25, 20);
            this.P1_Y.TabIndex = 1;
            // 
            // P1_X
            // 
            this.P1_X.Location = new System.Drawing.Point(6, 19);
            this.P1_X.Name = "P1_X";
            this.P1_X.Size = new System.Drawing.Size(25, 20);
            this.P1_X.TabIndex = 0;
            // 
            // Ctn_ImageContainer
            // 
            this.Ctn_ImageContainer.Controls.Add(this.Txt_Image4);
            this.Ctn_ImageContainer.Controls.Add(this.Txt_Image3);
            this.Ctn_ImageContainer.Controls.Add(this.Txt_Image2);
            this.Ctn_ImageContainer.Controls.Add(this.Txt_Image1);
            this.Ctn_ImageContainer.Controls.Add(this.Img_Diagram);
            this.Ctn_ImageContainer.Location = new System.Drawing.Point(386, 12);
            this.Ctn_ImageContainer.Name = "Ctn_ImageContainer";
            this.Ctn_ImageContainer.Size = new System.Drawing.Size(222, 129);
            this.Ctn_ImageContainer.TabIndex = 2;
            this.Ctn_ImageContainer.TabStop = false;
            // 
            // Txt_Image4
            // 
            this.Txt_Image4.AutoSize = true;
            this.Txt_Image4.Location = new System.Drawing.Point(145, 100);
            this.Txt_Image4.Name = "Txt_Image4";
            this.Txt_Image4.Size = new System.Drawing.Size(35, 13);
            this.Txt_Image4.TabIndex = 4;
            this.Txt_Image4.Text = "label4";
            // 
            // Txt_Image3
            // 
            this.Txt_Image3.AutoSize = true;
            this.Txt_Image3.Location = new System.Drawing.Point(145, 16);
            this.Txt_Image3.Name = "Txt_Image3";
            this.Txt_Image3.Size = new System.Drawing.Size(71, 13);
            this.Txt_Image3.TabIndex = 3;
            this.Txt_Image3.Text = "P1 = 200,900";
            // 
            // Txt_Image2
            // 
            this.Txt_Image2.AutoSize = true;
            this.Txt_Image2.Location = new System.Drawing.Point(6, 16);
            this.Txt_Image2.Name = "Txt_Image2";
            this.Txt_Image2.Size = new System.Drawing.Size(71, 13);
            this.Txt_Image2.TabIndex = 2;
            this.Txt_Image2.Text = "P1 = 200,900";
            // 
            // Txt_Image1
            // 
            this.Txt_Image1.AutoSize = true;
            this.Txt_Image1.Location = new System.Drawing.Point(6, 100);
            this.Txt_Image1.Name = "Txt_Image1";
            this.Txt_Image1.Size = new System.Drawing.Size(35, 13);
            this.Txt_Image1.TabIndex = 1;
            this.Txt_Image1.Text = "label1";
            // 
            // Img_Diagram
            // 
            this.Img_Diagram.Location = new System.Drawing.Point(9, 32);
            this.Img_Diagram.Name = "Img_Diagram";
            this.Img_Diagram.Size = new System.Drawing.Size(207, 65);
            this.Img_Diagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Diagram.TabIndex = 0;
            this.Img_Diagram.TabStop = false;
            // 
            // TxtBox_RunningTotal
            // 
            this.TxtBox_RunningTotal.Location = new System.Drawing.Point(12, 202);
            this.TxtBox_RunningTotal.Name = "TxtBox_RunningTotal";
            this.TxtBox_RunningTotal.Size = new System.Drawing.Size(596, 236);
            this.TxtBox_RunningTotal.TabIndex = 3;
            this.TxtBox_RunningTotal.Text = "";
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Enabled = false;
            this.Btn_Calculate.Font = new System.Drawing.Font("Blackoak Std", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Calculate.Location = new System.Drawing.Point(219, 147);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(161, 49);
            this.Btn_Calculate.TabIndex = 4;
            this.Btn_Calculate.Text = "Calc!";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Btn_Count
            // 
            this.Btn_Count.Font = new System.Drawing.Font("Blackoak Std", 16F, System.Drawing.FontStyle.Bold);
            this.Btn_Count.Location = new System.Drawing.Point(12, 148);
            this.Btn_Count.Name = "Btn_Count";
            this.Btn_Count.Size = new System.Drawing.Size(201, 48);
            this.Btn_Count.TabIndex = 5;
            this.Btn_Count.Text = "Count!";
            this.Btn_Count.UseVisualStyleBackColor = true;
            this.Btn_Count.Click += new System.EventHandler(this.Btn_Count_Click);
            // 
            // Txt_Description
            // 
            this.Txt_Description.Location = new System.Drawing.Point(386, 147);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.ReadOnly = true;
            this.Txt_Description.Size = new System.Drawing.Size(222, 49);
            this.Txt_Description.TabIndex = 6;
            this.Txt_Description.Text = "";
            // 
            // ShapesInheritanceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.Btn_Count);
            this.Controls.Add(this.Btn_Calculate);
            this.Controls.Add(this.TxtBox_RunningTotal);
            this.Controls.Add(this.Ctn_ImageContainer);
            this.Controls.Add(this.Ctn_PointTextBoxes);
            this.Controls.Add(this.Ctn_DropdownContainer);
            this.Name = "ShapesInheritanceApp";
            this.Text = "Shapes Inheritance App";
            this.Ctn_DropdownContainer.ResumeLayout(false);
            this.Ctn_CountContainer.ResumeLayout(false);
            this.Ctn_CountContainer.PerformLayout();
            this.Ctn_PointTextBoxes.ResumeLayout(false);
            this.Ctn_Point4.ResumeLayout(false);
            this.Ctn_Point4.PerformLayout();
            this.Ctn_Point3.ResumeLayout(false);
            this.Ctn_Point3.PerformLayout();
            this.Ctn_Point2.ResumeLayout(false);
            this.Ctn_Point2.PerformLayout();
            this.Ctn_Point1.ResumeLayout(false);
            this.Ctn_Point1.PerformLayout();
            this.Ctn_ImageContainer.ResumeLayout(false);
            this.Ctn_ImageContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Diagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Ctn_DropdownContainer;
        private System.Windows.Forms.ComboBox shapePicker;
        private System.Windows.Forms.GroupBox Ctn_PointTextBoxes;
        private System.Windows.Forms.GroupBox Ctn_Point1;
        private System.Windows.Forms.GroupBox Ctn_Point4;
        private System.Windows.Forms.TextBox P4_X;
        private System.Windows.Forms.TextBox P4_Y;
        private System.Windows.Forms.GroupBox Ctn_Point3;
        private System.Windows.Forms.TextBox P3_X;
        private System.Windows.Forms.TextBox P3_Y;
        private System.Windows.Forms.GroupBox Ctn_Point2;
        private System.Windows.Forms.TextBox P2_X;
        private System.Windows.Forms.TextBox P2_Y;
        private System.Windows.Forms.TextBox P1_Y;
        private System.Windows.Forms.TextBox P1_X;
        private System.Windows.Forms.GroupBox Ctn_ImageContainer;
        private System.Windows.Forms.Label Txt_Image4;
        private System.Windows.Forms.Label Txt_Image3;
        private System.Windows.Forms.Label Txt_Image2;
        private System.Windows.Forms.Label Txt_Image1;
        private System.Windows.Forms.PictureBox Img_Diagram;
        private System.Windows.Forms.RichTextBox TxtBox_RunningTotal;
        private System.Windows.Forms.GroupBox Ctn_CountContainer;
        private System.Windows.Forms.Label Txt_ParlCount;
        private System.Windows.Forms.Label Txt_TrapCount;
        private System.Windows.Forms.Label Txt_RectCount;
        private System.Windows.Forms.Label Txt_SquareCount;
        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.Button Btn_Count;
        private System.Windows.Forms.RichTextBox Txt_Description;
    }
}

