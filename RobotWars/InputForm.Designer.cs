namespace RobotWars
{
    partial class InputForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblArena = new System.Windows.Forms.Label();
            this.lblArenaLength = new System.Windows.Forms.Label();
            this.lblArenaBreadth = new System.Windows.Forms.Label();
            this.txtBoxLengthofArena = new System.Windows.Forms.TextBox();
            this.txtBoxBreadthofArena = new System.Windows.Forms.TextBox();
            this.lblRobot1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbBoxRobot2 = new System.Windows.Forms.ComboBox();
            this.cmbBoxRobot1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMovesRobot2 = new System.Windows.Forms.TextBox();
            this.txtMovesRobot1 = new System.Windows.Forms.TextBox();
            this.lblMovesRobot1 = new System.Windows.Forms.Label();
            this.lblMovesRobot2 = new System.Windows.Forms.Label();
            this.lblOrientationRobot2 = new System.Windows.Forms.Label();
            this.txtYaxisRobot2 = new System.Windows.Forms.TextBox();
            this.lblYAxisRobot2 = new System.Windows.Forms.Label();
            this.txtXaxisRobot2 = new System.Windows.Forms.TextBox();
            this.lblXAxisRobot2 = new System.Windows.Forms.Label();
            this.txtColorRobot2 = new System.Windows.Forms.TextBox();
            this.lblRobot2 = new System.Windows.Forms.Label();
            this.lblOrientationRobot1 = new System.Windows.Forms.Label();
            this.txtYaxisRobot1 = new System.Windows.Forms.TextBox();
            this.lblYAxisRobot1 = new System.Windows.Forms.Label();
            this.txtXaxisRobot1 = new System.Windows.Forms.TextBox();
            this.lblXaxisRobot1 = new System.Windows.Forms.Label();
            this.txtColorRobot1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(265, 59);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(663, 63);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to Robot Wars!!";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArena
            // 
            this.lblArena.AutoSize = true;
            this.lblArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArena.Location = new System.Drawing.Point(62, 183);
            this.lblArena.Name = "lblArena";
            this.lblArena.Size = new System.Drawing.Size(397, 39);
            this.lblArena.TabIndex = 1;
            this.lblArena.Text = "Enter the area of Arena :-";
            // 
            // lblArenaLength
            // 
            this.lblArenaLength.AutoSize = true;
            this.lblArenaLength.Location = new System.Drawing.Point(151, 268);
            this.lblArenaLength.Name = "lblArenaLength";
            this.lblArenaLength.Size = new System.Drawing.Size(103, 32);
            this.lblArenaLength.TabIndex = 2;
            this.lblArenaLength.Text = "Length";
            // 
            // lblArenaBreadth
            // 
            this.lblArenaBreadth.AutoSize = true;
            this.lblArenaBreadth.Location = new System.Drawing.Point(600, 267);
            this.lblArenaBreadth.Name = "lblArenaBreadth";
            this.lblArenaBreadth.Size = new System.Drawing.Size(115, 32);
            this.lblArenaBreadth.TabIndex = 3;
            this.lblArenaBreadth.Text = "Breadth";
            // 
            // txtBoxLengthofArena
            // 
            this.txtBoxLengthofArena.Location = new System.Drawing.Point(384, 267);
            this.txtBoxLengthofArena.Name = "txtBoxLengthofArena";
            this.txtBoxLengthofArena.Size = new System.Drawing.Size(100, 38);
            this.txtBoxLengthofArena.TabIndex = 4;
            this.txtBoxLengthofArena.TextChanged += new System.EventHandler(this.textBoxLengthofArena_TextChanged);
            // 
            // txtBoxBreadthofArena
            // 
            this.txtBoxBreadthofArena.Location = new System.Drawing.Point(801, 267);
            this.txtBoxBreadthofArena.Name = "txtBoxBreadthofArena";
            this.txtBoxBreadthofArena.Size = new System.Drawing.Size(100, 38);
            this.txtBoxBreadthofArena.TabIndex = 5;
            this.txtBoxBreadthofArena.TextChanged += new System.EventHandler(this.textBoxBreadthofArena_TextChanged);
            // 
            // lblRobot1
            // 
            this.lblRobot1.AutoSize = true;
            this.lblRobot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobot1.Location = new System.Drawing.Point(75, 371);
            this.lblRobot1.Name = "lblRobot1";
            this.lblRobot1.Size = new System.Drawing.Size(392, 39);
            this.lblRobot1.TabIndex = 7;
            this.lblRobot1.Text = "Position of Robot Irona :-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.cmbBoxRobot2);
            this.groupBox1.Controls.Add(this.cmbBoxRobot1);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtMovesRobot2);
            this.groupBox1.Controls.Add(this.txtMovesRobot1);
            this.groupBox1.Controls.Add(this.lblMovesRobot1);
            this.groupBox1.Controls.Add(this.lblMovesRobot2);
            this.groupBox1.Controls.Add(this.lblOrientationRobot2);
            this.groupBox1.Controls.Add(this.txtYaxisRobot2);
            this.groupBox1.Controls.Add(this.lblYAxisRobot2);
            this.groupBox1.Controls.Add(this.txtXaxisRobot2);
            this.groupBox1.Controls.Add(this.lblXAxisRobot2);
            this.groupBox1.Controls.Add(this.txtColorRobot2);
            this.groupBox1.Controls.Add(this.lblRobot2);
            this.groupBox1.Controls.Add(this.lblOrientationRobot1);
            this.groupBox1.Controls.Add(this.txtYaxisRobot1);
            this.groupBox1.Controls.Add(this.lblYAxisRobot1);
            this.groupBox1.Controls.Add(this.txtXaxisRobot1);
            this.groupBox1.Controls.Add(this.lblXaxisRobot1);
            this.groupBox1.Controls.Add(this.txtColorRobot1);
            this.groupBox1.Controls.Add(this.lblRobot1);
            this.groupBox1.Controls.Add(this.txtBoxBreadthofArena);
            this.groupBox1.Controls.Add(this.txtBoxLengthofArena);
            this.groupBox1.Controls.Add(this.lblArenaBreadth);
            this.groupBox1.Controls.Add(this.lblArenaLength);
            this.groupBox1.Controls.Add(this.lblArena);
            this.groupBox1.Controls.Add(this.lblHeading);
            this.groupBox1.Location = new System.Drawing.Point(34, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 1331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(42, 1210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 76);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "ClearAll";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.Location = new System.Drawing.Point(937, 646);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(136, 87);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbBoxRobot2
            // 
            this.cmbBoxRobot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxRobot2.Enabled = false;
            this.cmbBoxRobot2.FormattingEnabled = true;
            this.cmbBoxRobot2.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "W"});
            this.cmbBoxRobot2.Location = new System.Drawing.Point(393, 959);
            this.cmbBoxRobot2.Name = "cmbBoxRobot2";
            this.cmbBoxRobot2.Size = new System.Drawing.Size(100, 39);
            this.cmbBoxRobot2.TabIndex = 17;
            // 
            // cmbBoxRobot1
            // 
            this.cmbBoxRobot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxRobot1.FormattingEnabled = true;
            this.cmbBoxRobot1.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "W"});
            this.cmbBoxRobot1.Location = new System.Drawing.Point(393, 572);
            this.cmbBoxRobot1.Name = "cmbBoxRobot1";
            this.cmbBoxRobot1.Size = new System.Drawing.Size(100, 39);
            this.cmbBoxRobot1.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(465, 1210);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(263, 76);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Play";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMovesRobot2
            // 
            this.txtMovesRobot2.Enabled = false;
            this.txtMovesRobot2.Location = new System.Drawing.Point(393, 1096);
            this.txtMovesRobot2.Name = "txtMovesRobot2";
            this.txtMovesRobot2.Size = new System.Drawing.Size(490, 38);
            this.txtMovesRobot2.TabIndex = 19;
            this.txtMovesRobot2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMovesRobot2_KeyPress);
            this.txtMovesRobot2.Leave += new System.EventHandler(this.txtMovesRobot2_Leave);
            // 
            // txtMovesRobot1
            // 
            this.txtMovesRobot1.Location = new System.Drawing.Point(393, 665);
            this.txtMovesRobot1.Name = "txtMovesRobot1";
            this.txtMovesRobot1.Size = new System.Drawing.Size(508, 38);
            this.txtMovesRobot1.TabIndex = 14;
            this.txtMovesRobot1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMovesRobot1_KeyPress);
            this.txtMovesRobot1.Leave += new System.EventHandler(this.txtMovesRobot1_Leave);
            // 
            // lblMovesRobot1
            // 
            this.lblMovesRobot1.AutoSize = true;
            this.lblMovesRobot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesRobot1.Location = new System.Drawing.Point(114, 668);
            this.lblMovesRobot1.Name = "lblMovesRobot1";
            this.lblMovesRobot1.Size = new System.Drawing.Size(221, 35);
            this.lblMovesRobot1.TabIndex = 23;
            this.lblMovesRobot1.Text = "Desired Moves";
            // 
            // lblMovesRobot2
            // 
            this.lblMovesRobot2.AutoSize = true;
            this.lblMovesRobot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesRobot2.Location = new System.Drawing.Point(106, 1096);
            this.lblMovesRobot2.Name = "lblMovesRobot2";
            this.lblMovesRobot2.Size = new System.Drawing.Size(229, 35);
            this.lblMovesRobot2.TabIndex = 24;
            this.lblMovesRobot2.Text = "Desired  Moves";
            // 
            // lblOrientationRobot2
            // 
            this.lblOrientationRobot2.AutoSize = true;
            this.lblOrientationRobot2.Location = new System.Drawing.Point(160, 959);
            this.lblOrientationRobot2.Name = "lblOrientationRobot2";
            this.lblOrientationRobot2.Size = new System.Drawing.Size(156, 32);
            this.lblOrientationRobot2.TabIndex = 21;
            this.lblOrientationRobot2.Text = "Orientation";
            // 
            // txtYaxisRobot2
            // 
            this.txtYaxisRobot2.Enabled = false;
            this.txtYaxisRobot2.Location = new System.Drawing.Point(393, 897);
            this.txtYaxisRobot2.Name = "txtYaxisRobot2";
            this.txtYaxisRobot2.Size = new System.Drawing.Size(100, 38);
            this.txtYaxisRobot2.TabIndex = 16;
            this.txtYaxisRobot2.TextChanged += new System.EventHandler(this.txtYaxisRobot2_TextChanged);
            // 
            // lblYAxisRobot2
            // 
            this.lblYAxisRobot2.AutoSize = true;
            this.lblYAxisRobot2.Location = new System.Drawing.Point(160, 898);
            this.lblYAxisRobot2.Name = "lblYAxisRobot2";
            this.lblYAxisRobot2.Size = new System.Drawing.Size(97, 32);
            this.lblYAxisRobot2.TabIndex = 19;
            this.lblYAxisRobot2.Text = "Y-Axis";
            // 
            // txtXaxisRobot2
            // 
            this.txtXaxisRobot2.Enabled = false;
            this.txtXaxisRobot2.Location = new System.Drawing.Point(393, 839);
            this.txtXaxisRobot2.Name = "txtXaxisRobot2";
            this.txtXaxisRobot2.Size = new System.Drawing.Size(100, 38);
            this.txtXaxisRobot2.TabIndex = 15;
            this.txtXaxisRobot2.TextChanged += new System.EventHandler(this.txtXaxisRobot2_TextChanged);
            // 
            // lblXAxisRobot2
            // 
            this.lblXAxisRobot2.AutoSize = true;
            this.lblXAxisRobot2.Location = new System.Drawing.Point(160, 840);
            this.lblXAxisRobot2.Name = "lblXAxisRobot2";
            this.lblXAxisRobot2.Size = new System.Drawing.Size(97, 32);
            this.lblXAxisRobot2.TabIndex = 17;
            this.lblXAxisRobot2.Text = "X-Axis";
            // 
            // txtColorRobot2
            // 
            this.txtColorRobot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtColorRobot2.Enabled = false;
            this.txtColorRobot2.Location = new System.Drawing.Point(587, 761);
            this.txtColorRobot2.Name = "txtColorRobot2";
            this.txtColorRobot2.Size = new System.Drawing.Size(43, 38);
            this.txtColorRobot2.TabIndex = 16;
            // 
            // lblRobot2
            // 
            this.lblRobot2.AutoSize = true;
            this.lblRobot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobot2.Location = new System.Drawing.Point(75, 758);
            this.lblRobot2.Name = "lblRobot2";
            this.lblRobot2.Size = new System.Drawing.Size(454, 39);
            this.lblRobot2.TabIndex = 15;
            this.lblRobot2.Text = "Position of Robot Defender :-";
            // 
            // lblOrientationRobot1
            // 
            this.lblOrientationRobot1.AutoSize = true;
            this.lblOrientationRobot1.Location = new System.Drawing.Point(160, 572);
            this.lblOrientationRobot1.Name = "lblOrientationRobot1";
            this.lblOrientationRobot1.Size = new System.Drawing.Size(156, 32);
            this.lblOrientationRobot1.TabIndex = 13;
            this.lblOrientationRobot1.Text = "Orientation";
            // 
            // txtYaxisRobot1
            // 
            this.txtYaxisRobot1.Location = new System.Drawing.Point(393, 510);
            this.txtYaxisRobot1.Name = "txtYaxisRobot1";
            this.txtYaxisRobot1.Size = new System.Drawing.Size(100, 38);
            this.txtYaxisRobot1.TabIndex = 12;
            this.txtYaxisRobot1.TextChanged += new System.EventHandler(this.txtYaxisRobot1_TextChanged);
            // 
            // lblYAxisRobot1
            // 
            this.lblYAxisRobot1.AutoSize = true;
            this.lblYAxisRobot1.Location = new System.Drawing.Point(160, 511);
            this.lblYAxisRobot1.Name = "lblYAxisRobot1";
            this.lblYAxisRobot1.Size = new System.Drawing.Size(97, 32);
            this.lblYAxisRobot1.TabIndex = 11;
            this.lblYAxisRobot1.Text = "Y-Axis";
            // 
            // txtXaxisRobot1
            // 
            this.txtXaxisRobot1.Location = new System.Drawing.Point(393, 452);
            this.txtXaxisRobot1.Name = "txtXaxisRobot1";
            this.txtXaxisRobot1.Size = new System.Drawing.Size(100, 38);
            this.txtXaxisRobot1.TabIndex = 10;
            this.txtXaxisRobot1.TextChanged += new System.EventHandler(this.txtXaxisRobot1_TextChanged);
            // 
            // lblXaxisRobot1
            // 
            this.lblXaxisRobot1.AutoSize = true;
            this.lblXaxisRobot1.Location = new System.Drawing.Point(160, 453);
            this.lblXaxisRobot1.Name = "lblXaxisRobot1";
            this.lblXaxisRobot1.Size = new System.Drawing.Size(97, 32);
            this.lblXaxisRobot1.TabIndex = 9;
            this.lblXaxisRobot1.Text = "X-Axis";
            // 
            // txtColorRobot1
            // 
            this.txtColorRobot1.BackColor = System.Drawing.Color.Lime;
            this.txtColorRobot1.Enabled = false;
            this.txtColorRobot1.Location = new System.Drawing.Point(587, 374);
            this.txtColorRobot1.Name = "txtColorRobot1";
            this.txtColorRobot1.Size = new System.Drawing.Size(43, 38);
            this.txtColorRobot1.TabIndex = 8;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 1420);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblArena;
        private System.Windows.Forms.Label lblArenaLength;
        private System.Windows.Forms.Label lblArenaBreadth;
        private System.Windows.Forms.TextBox txtBoxLengthofArena;
        private System.Windows.Forms.TextBox txtBoxBreadthofArena;
        private System.Windows.Forms.Label lblRobot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColorRobot1;
        private System.Windows.Forms.Label lblOrientationRobot2;
        private System.Windows.Forms.TextBox txtYaxisRobot2;
        private System.Windows.Forms.Label lblYAxisRobot2;
        private System.Windows.Forms.TextBox txtXaxisRobot2;
        private System.Windows.Forms.Label lblXAxisRobot2;
        private System.Windows.Forms.TextBox txtColorRobot2;
        private System.Windows.Forms.Label lblRobot2;
        private System.Windows.Forms.Label lblOrientationRobot1;
        private System.Windows.Forms.TextBox txtYaxisRobot1;
        private System.Windows.Forms.Label lblYAxisRobot1;
        private System.Windows.Forms.TextBox txtXaxisRobot1;
        private System.Windows.Forms.Label lblXaxisRobot1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMovesRobot2;
        private System.Windows.Forms.TextBox txtMovesRobot1;
        private System.Windows.Forms.Label lblMovesRobot1;
        private System.Windows.Forms.Label lblMovesRobot2;
        private System.Windows.Forms.ComboBox cmbBoxRobot1;
        private System.Windows.Forms.ComboBox cmbBoxRobot2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
    }
}