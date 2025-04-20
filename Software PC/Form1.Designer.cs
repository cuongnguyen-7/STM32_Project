namespace DLCN_DEMO
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btnOPEN = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBOX = new System.Windows.Forms.TextBox();
            this.btnREAD = new System.Windows.Forms.Button();
            this.btnSET = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(344, 22);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(813, 576);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // btnOPEN
            // 
            this.btnOPEN.BackColor = System.Drawing.Color.Gold;
            this.btnOPEN.Location = new System.Drawing.Point(183, 122);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(83, 48);
            this.btnOPEN.TabIndex = 2;
            this.btnOPEN.Text = "Connect";
            this.btnOPEN.UseVisualStyleBackColor = false;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {
            "COM10"});
            this.comboBoxCOM.Location = new System.Drawing.Point(159, 53);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(116, 24);
            this.comboBoxCOM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection Panel";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.DropDownWidth = 130;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(159, 92);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(116, 24);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.btnREAD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxBaud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOPEN);
            this.panel1.Controls.Add(this.comboBoxCOM);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 242);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "COM";
            // 
            // textBOX
            // 
            this.textBOX.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBOX.Location = new System.Drawing.Point(6, 38);
            this.textBOX.Multiline = true;
            this.textBOX.Name = "textBOX";
            this.textBOX.Size = new System.Drawing.Size(283, 196);
            this.textBOX.TabIndex = 6;
            // 
            // btnREAD
            // 
            this.btnREAD.BackColor = System.Drawing.Color.OliveDrab;
            this.btnREAD.Location = new System.Drawing.Point(183, 176);
            this.btnREAD.Name = "btnREAD";
            this.btnREAD.Size = new System.Drawing.Size(83, 48);
            this.btnREAD.TabIndex = 2;
            this.btnREAD.Text = "Read";
            this.btnREAD.UseVisualStyleBackColor = false;
            this.btnREAD.Click += new System.EventHandler(this.btnREAD_Click);
            // 
            // btnSET
            // 
            this.btnSET.BackColor = System.Drawing.Color.Moccasin;
            this.btnSET.Location = new System.Drawing.Point(206, 24);
            this.btnSET.Name = "btnSET";
            this.btnSET.Size = new System.Drawing.Size(69, 48);
            this.btnSET.TabIndex = 2;
            this.btnSET.Text = "Set";
            this.btnSET.UseVisualStyleBackColor = false;
            this.btnSET.Click += new System.EventHandler(this.btnSET_Click);
            // 
            // txta
            // 
            this.txta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txta.Location = new System.Drawing.Point(60, 21);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(116, 22);
            this.txta.TabIndex = 7;
            // 
            // txtb
            // 
            this.txtb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtb.Location = new System.Drawing.Point(60, 49);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(116, 22);
            this.txtb.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.textBOX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 242);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "b";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.txta);
            this.groupBox2.Controls.Add(this.btnSET);
            this.groupBox2.Controls.Add(this.txtb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(295, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBOX;
        private System.Windows.Forms.Button btnREAD;
        private System.Windows.Forms.Button btnSET;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

