namespace ArdupilotMega
{
    partial class Form1
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
            this.BUT_save = new ArdupilotMega.Controls.MyButton();
            this.CMB_camera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_distacflphotos = new System.Windows.Forms.TextBox();
            this.TXT_distflphotos = new System.Windows.Forms.TextBox();
            this.CHK_camdirection = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.num_sidelap = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_overlap = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_sensheight = new System.Windows.Forms.TextBox();
            this.TXT_senswidth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_imgheight = new System.Windows.Forms.TextBox();
            this.TXT_imgwidth = new System.Windows.Forms.TextBox();
            this.TXT_cmpixel = new System.Windows.Forms.TextBox();
            this.TXT_fovAV = new System.Windows.Forms.TextBox();
            this.TXT_fovAH = new System.Windows.Forms.TextBox();
            this.TXT_fovV = new System.Windows.Forms.TextBox();
            this.TXT_fovH = new System.Windows.Forms.TextBox();
            this.num_focallength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num_agl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_sidelap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_overlap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_focallength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_agl)).BeginInit();
            this.SuspendLayout();
            // 
            // BUT_save
            // 
            this.BUT_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_save.Location = new System.Drawing.Point(237, 9);
            this.BUT_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BUT_save.Name = "BUT_save";
            this.BUT_save.Size = new System.Drawing.Size(112, 35);
            this.BUT_save.TabIndex = 77;
            this.BUT_save.Text = "Save";
            this.BUT_save.UseVisualStyleBackColor = true;
            // 
            // CMB_camera
            // 
            this.CMB_camera.FormattingEnabled = true;
            this.CMB_camera.Location = new System.Drawing.Point(13, 14);
            this.CMB_camera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_camera.Name = "CMB_camera";
            this.CMB_camera.Size = new System.Drawing.Size(212, 28);
            this.CMB_camera.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(385, 299);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Across Flight line";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(385, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 74;
            this.label11.Text = "Flight line distance";
            // 
            // TXT_distacflphotos
            // 
            this.TXT_distacflphotos.Location = new System.Drawing.Point(535, 294);
            this.TXT_distacflphotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_distacflphotos.Name = "TXT_distacflphotos";
            this.TXT_distacflphotos.Size = new System.Drawing.Size(148, 26);
            this.TXT_distacflphotos.TabIndex = 73;
            // 
            // TXT_distflphotos
            // 
            this.TXT_distflphotos.Location = new System.Drawing.Point(535, 252);
            this.TXT_distflphotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_distflphotos.Name = "TXT_distflphotos";
            this.TXT_distflphotos.Size = new System.Drawing.Size(148, 26);
            this.TXT_distflphotos.TabIndex = 72;
            // 
            // CHK_camdirection
            // 
            this.CHK_camdirection.AutoSize = true;
            this.CHK_camdirection.Checked = true;
            this.CHK_camdirection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_camdirection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_camdirection.Location = new System.Drawing.Point(13, 374);
            this.CHK_camdirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CHK_camdirection.Name = "CHK_camdirection";
            this.CHK_camdirection.Size = new System.Drawing.Size(222, 24);
            this.CHK_camdirection.TabIndex = 71;
            this.CHK_camdirection.Text = "Camera top facing forward";
            this.CHK_camdirection.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(116, 343);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 70;
            this.label15.Text = "Sidelap";
            // 
            // num_sidelap
            // 
            this.num_sidelap.DecimalPlaces = 1;
            this.num_sidelap.Location = new System.Drawing.Point(11, 332);
            this.num_sidelap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_sidelap.Name = "num_sidelap";
            this.num_sidelap.Size = new System.Drawing.Size(96, 26);
            this.num_sidelap.TabIndex = 69;
            this.num_sidelap.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(116, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Overlap";
            // 
            // num_overlap
            // 
            this.num_overlap.DecimalPlaces = 1;
            this.num_overlap.Location = new System.Drawing.Point(11, 292);
            this.num_overlap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_overlap.Name = "num_overlap";
            this.num_overlap.Size = new System.Drawing.Size(96, 26);
            this.num_overlap.TabIndex = 67;
            this.num_overlap.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(116, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Sensor Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(116, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Sensor Width";
            // 
            // TXT_sensheight
            // 
            this.TXT_sensheight.Location = new System.Drawing.Point(11, 252);
            this.TXT_sensheight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_sensheight.Name = "TXT_sensheight";
            this.TXT_sensheight.Size = new System.Drawing.Size(94, 26);
            this.TXT_sensheight.TabIndex = 64;
            this.TXT_sensheight.Text = "4.62";
            // 
            // TXT_senswidth
            // 
            this.TXT_senswidth.Location = new System.Drawing.Point(11, 212);
            this.TXT_senswidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_senswidth.Name = "TXT_senswidth";
            this.TXT_senswidth.Size = new System.Drawing.Size(94, 26);
            this.TXT_senswidth.TabIndex = 63;
            this.TXT_senswidth.Text = "6.16";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(116, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Pixel Height";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(116, 137);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "Pixel Width";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(441, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "CM/Pixel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(441, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "FOV V (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(443, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Angle V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(441, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Angle H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(440, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "FOV H (m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(116, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Focal Length";
            // 
            // TXT_imgheight
            // 
            this.TXT_imgheight.Location = new System.Drawing.Point(11, 172);
            this.TXT_imgheight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_imgheight.Name = "TXT_imgheight";
            this.TXT_imgheight.Size = new System.Drawing.Size(94, 26);
            this.TXT_imgheight.TabIndex = 54;
            this.TXT_imgheight.Text = "3456";
            // 
            // TXT_imgwidth
            // 
            this.TXT_imgwidth.Location = new System.Drawing.Point(11, 132);
            this.TXT_imgwidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_imgwidth.Name = "TXT_imgwidth";
            this.TXT_imgwidth.Size = new System.Drawing.Size(94, 26);
            this.TXT_imgwidth.TabIndex = 53;
            this.TXT_imgwidth.Text = "4608";
            // 
            // TXT_cmpixel
            // 
            this.TXT_cmpixel.Location = new System.Drawing.Point(535, 176);
            this.TXT_cmpixel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_cmpixel.Name = "TXT_cmpixel";
            this.TXT_cmpixel.Size = new System.Drawing.Size(148, 26);
            this.TXT_cmpixel.TabIndex = 52;
            // 
            // TXT_fovAV
            // 
            this.TXT_fovAV.Location = new System.Drawing.Point(535, 136);
            this.TXT_fovAV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_fovAV.Name = "TXT_fovAV";
            this.TXT_fovAV.Size = new System.Drawing.Size(148, 26);
            this.TXT_fovAV.TabIndex = 51;
            // 
            // TXT_fovAH
            // 
            this.TXT_fovAH.Location = new System.Drawing.Point(535, 94);
            this.TXT_fovAH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_fovAH.Name = "TXT_fovAH";
            this.TXT_fovAH.Size = new System.Drawing.Size(148, 26);
            this.TXT_fovAH.TabIndex = 50;
            // 
            // TXT_fovV
            // 
            this.TXT_fovV.Location = new System.Drawing.Point(535, 54);
            this.TXT_fovV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_fovV.Name = "TXT_fovV";
            this.TXT_fovV.Size = new System.Drawing.Size(148, 26);
            this.TXT_fovV.TabIndex = 49;
            // 
            // TXT_fovH
            // 
            this.TXT_fovH.Location = new System.Drawing.Point(535, 12);
            this.TXT_fovH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_fovH.Name = "TXT_fovH";
            this.TXT_fovH.Size = new System.Drawing.Size(148, 26);
            this.TXT_fovH.TabIndex = 48;
            // 
            // num_focallength
            // 
            this.num_focallength.DecimalPlaces = 1;
            this.num_focallength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_focallength.Location = new System.Drawing.Point(11, 92);
            this.num_focallength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_focallength.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_focallength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_focallength.Name = "num_focallength";
            this.num_focallength.Size = new System.Drawing.Size(96, 26);
            this.num_focallength.TabIndex = 47;
            this.num_focallength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(116, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Height m (agl)";
            // 
            // num_agl
            // 
            this.num_agl.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_agl.Location = new System.Drawing.Point(11, 52);
            this.num_agl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_agl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_agl.Name = "num_agl";
            this.num_agl.Size = new System.Drawing.Size(96, 26);
            this.num_agl.TabIndex = 45;
            this.num_agl.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 426);
            this.Controls.Add(this.BUT_save);
            this.Controls.Add(this.CMB_camera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_distacflphotos);
            this.Controls.Add(this.TXT_distflphotos);
            this.Controls.Add(this.CHK_camdirection);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.num_sidelap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_overlap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_sensheight);
            this.Controls.Add(this.TXT_senswidth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_imgheight);
            this.Controls.Add(this.TXT_imgwidth);
            this.Controls.Add(this.TXT_cmpixel);
            this.Controls.Add(this.TXT_fovAV);
            this.Controls.Add(this.TXT_fovAH);
            this.Controls.Add(this.TXT_fovV);
            this.Controls.Add(this.TXT_fovH);
            this.Controls.Add(this.num_focallength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_agl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_sidelap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_overlap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_focallength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_agl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton BUT_save;
        private System.Windows.Forms.ComboBox CMB_camera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_distacflphotos;
        private System.Windows.Forms.TextBox TXT_distflphotos;
        private System.Windows.Forms.CheckBox CHK_camdirection;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown num_sidelap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_overlap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_sensheight;
        private System.Windows.Forms.TextBox TXT_senswidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_imgheight;
        private System.Windows.Forms.TextBox TXT_imgwidth;
        private System.Windows.Forms.TextBox TXT_cmpixel;
        private System.Windows.Forms.TextBox TXT_fovAV;
        private System.Windows.Forms.TextBox TXT_fovAH;
        private System.Windows.Forms.TextBox TXT_fovV;
        private System.Windows.Forms.TextBox TXT_fovH;
        private System.Windows.Forms.NumericUpDown num_focallength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_agl;
    }
}