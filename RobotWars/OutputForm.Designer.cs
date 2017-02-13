namespace RobotWars
{
    partial class OutputForm
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
            this.textBoxRobot1 = new System.Windows.Forms.TextBox();
            this.textBoxRobot2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRobot1
            // 
            this.textBoxRobot1.BackColor = System.Drawing.Color.Lime;
            this.textBoxRobot1.Location = new System.Drawing.Point(543, 113);
            this.textBoxRobot1.Name = "textBoxRobot1";
            this.textBoxRobot1.Size = new System.Drawing.Size(100, 38);
            this.textBoxRobot1.TabIndex = 0;
            // 
            // textBoxRobot2
            // 
            this.textBoxRobot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxRobot2.Location = new System.Drawing.Point(543, 253);
            this.textBoxRobot2.Name = "textBoxRobot2";
            this.textBoxRobot2.Size = new System.Drawing.Size(100, 38);
            this.textBoxRobot2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRobot1);
            this.groupBox1.Controls.Add(this.textBoxRobot2);
            this.groupBox1.Location = new System.Drawing.Point(80, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location of Robot Irona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location of Robot Defender";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 839);
            this.Controls.Add(this.groupBox1);
            this.Name = "OutputForm";
            this.Text = "OutputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRobot1;
        private System.Windows.Forms.TextBox textBoxRobot2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}