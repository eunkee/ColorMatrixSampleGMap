namespace TestGMap
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPos2 = new System.Windows.Forms.Button();
            this.buttonPos1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(483, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(896, 719);
            this.gMapControl1.TabIndex = 4;
            this.gMapControl1.Zoom = 0D;
            // 
            // comboBox25
            // 
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Location = new System.Drawing.Point(362, 293);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(68, 20);
            this.comboBox25.TabIndex = 24;
            this.comboBox25.Text = "0.00";
            this.comboBox25.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox24
            // 
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Location = new System.Drawing.Point(277, 293);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(68, 20);
            this.comboBox24.TabIndex = 23;
            this.comboBox24.Text = "0.00";
            this.comboBox24.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox23
            // 
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Location = new System.Drawing.Point(192, 293);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(68, 20);
            this.comboBox23.TabIndex = 22;
            this.comboBox23.Text = "0.00";
            this.comboBox23.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox22
            // 
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(107, 293);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(68, 20);
            this.comboBox22.TabIndex = 21;
            this.comboBox22.Text = "0.00";
            this.comboBox22.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox21
            // 
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(22, 293);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(68, 20);
            this.comboBox21.TabIndex = 20;
            this.comboBox21.Text = "0.00";
            this.comboBox21.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox20
            // 
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(362, 228);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(68, 20);
            this.comboBox20.TabIndex = 19;
            this.comboBox20.Text = "0.00";
            this.comboBox20.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox19
            // 
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(277, 228);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(68, 20);
            this.comboBox19.TabIndex = 18;
            this.comboBox19.Text = "0.00";
            this.comboBox19.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(192, 228);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(68, 20);
            this.comboBox18.TabIndex = 17;
            this.comboBox18.Text = "0.00";
            this.comboBox18.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(107, 228);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(68, 20);
            this.comboBox17.TabIndex = 16;
            this.comboBox17.Text = "0.00";
            this.comboBox17.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(22, 228);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(68, 20);
            this.comboBox16.TabIndex = 15;
            this.comboBox16.Text = "0.00";
            this.comboBox16.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(362, 163);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(68, 20);
            this.comboBox15.TabIndex = 14;
            this.comboBox15.Text = "0.00";
            this.comboBox15.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonPos2);
            this.panel1.Controls.Add(this.buttonPos1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 719);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(356, 698);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ColorMatrix Class";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(391, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 45);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(310, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 45);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox25);
            this.groupBox1.Controls.Add(this.comboBox24);
            this.groupBox1.Controls.Add(this.comboBox23);
            this.groupBox1.Controls.Add(this.comboBox22);
            this.groupBox1.Controls.Add(this.comboBox21);
            this.groupBox1.Controls.Add(this.comboBox20);
            this.groupBox1.Controls.Add(this.comboBox19);
            this.groupBox1.Controls.Add(this.comboBox18);
            this.groupBox1.Controls.Add(this.comboBox17);
            this.groupBox1.Controls.Add(this.comboBox16);
            this.groupBox1.Controls.Add(this.comboBox15);
            this.groupBox1.Controls.Add(this.comboBox14);
            this.groupBox1.Controls.Add(this.comboBox13);
            this.groupBox1.Controls.Add(this.comboBox12);
            this.groupBox1.Controls.Add(this.comboBox11);
            this.groupBox1.Controls.Add(this.comboBox10);
            this.groupBox1.Controls.Add(this.comboBox9);
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(277, 163);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(68, 20);
            this.comboBox14.TabIndex = 13;
            this.comboBox14.Text = "0.00";
            this.comboBox14.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(192, 163);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(68, 20);
            this.comboBox13.TabIndex = 12;
            this.comboBox13.Text = "0.00";
            this.comboBox13.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(107, 163);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(68, 20);
            this.comboBox12.TabIndex = 11;
            this.comboBox12.Text = "0.00";
            this.comboBox12.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(22, 163);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(68, 20);
            this.comboBox11.TabIndex = 10;
            this.comboBox11.Text = "0.00";
            this.comboBox11.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(362, 98);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(68, 20);
            this.comboBox10.TabIndex = 9;
            this.comboBox10.Text = "0.00";
            this.comboBox10.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(277, 98);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(68, 20);
            this.comboBox9.TabIndex = 8;
            this.comboBox9.Text = "0.00";
            this.comboBox9.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(192, 98);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(68, 20);
            this.comboBox8.TabIndex = 7;
            this.comboBox8.Text = "0.00";
            this.comboBox8.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(107, 98);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(68, 20);
            this.comboBox7.TabIndex = 6;
            this.comboBox7.Text = "0.00";
            this.comboBox7.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(22, 98);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(68, 20);
            this.comboBox6.TabIndex = 5;
            this.comboBox6.Text = "0.00";
            this.comboBox6.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(362, 33);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(68, 20);
            this.comboBox5.TabIndex = 4;
            this.comboBox5.Text = "0.00";
            this.comboBox5.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(277, 33);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(68, 20);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.Text = "0.00";
            this.comboBox4.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(192, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(68, 20);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "0.00";
            this.comboBox3.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "0.00";
            this.comboBox2.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "0.00";
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // buttonPos2
            // 
            this.buttonPos2.Enabled = false;
            this.buttonPos2.Location = new System.Drawing.Point(93, 12);
            this.buttonPos2.Name = "buttonPos2";
            this.buttonPos2.Size = new System.Drawing.Size(75, 45);
            this.buttonPos2.TabIndex = 2;
            this.buttonPos2.Text = "before";
            this.buttonPos2.UseVisualStyleBackColor = true;
            this.buttonPos2.Click += new System.EventHandler(this.ButtonPos2_Click);
            // 
            // buttonPos1
            // 
            this.buttonPos1.Location = new System.Drawing.Point(12, 12);
            this.buttonPos1.Name = "buttonPos1";
            this.buttonPos1.Size = new System.Drawing.Size(75, 45);
            this.buttonPos1.TabIndex = 1;
            this.buttonPos1.Text = "pos 1";
            this.buttonPos1.UseVisualStyleBackColor = true;
            this.buttonPos1.Click += new System.EventHandler(this.ButtonPos1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reference:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 719);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TestGMap: Search ColorMatrix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPos2;
        private System.Windows.Forms.Button buttonPos1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

