namespace SlopeAreaCalc
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
            this.btnSlope = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtx3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcY3 = new System.Windows.Forms.Button();
            this.txty3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.btnArea2 = new System.Windows.Forms.Button();
            this.txtArea2 = new System.Windows.Forms.TextBox();
            this.txtArea3 = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSlope
            // 
            this.btnSlope.Location = new System.Drawing.Point(55, 81);
            this.btnSlope.Name = "btnSlope";
            this.btnSlope.Size = new System.Drawing.Size(75, 23);
            this.btnSlope.TabIndex = 4;
            this.btnSlope.Text = "Slope";
            this.btnSlope.UseVisualStyleBackColor = true;
            this.btnSlope.Click += new System.EventHandler(this.btnSlope_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(55, 13);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 0;
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(231, 39);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(100, 20);
            this.txty2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y2";
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(231, 13);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(100, 20);
            this.txty1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y1";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(55, 39);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 20);
            this.txtx2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X2";
            // 
            // txtSlope
            // 
            this.txtSlope.Location = new System.Drawing.Point(55, 125);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(100, 20);
            this.txtSlope.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Slope";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(231, 125);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Area";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(149, 81);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 330);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Error";
            // 
            // txtx3
            // 
            this.txtx3.Location = new System.Drawing.Point(55, 168);
            this.txtx3.Name = "txtx3";
            this.txtx3.Size = new System.Drawing.Size(100, 20);
            this.txtx3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "X3";
            // 
            // btnCalcY3
            // 
            this.btnCalcY3.Location = new System.Drawing.Point(84, 203);
            this.btnCalcY3.Name = "btnCalcY3";
            this.btnCalcY3.Size = new System.Drawing.Size(75, 23);
            this.btnCalcY3.TabIndex = 18;
            this.btnCalcY3.Text = "Calc Y3";
            this.btnCalcY3.UseVisualStyleBackColor = true;
            this.btnCalcY3.Click += new System.EventHandler(this.btnCalcY3_Click);
            // 
            // txty3
            // 
            this.txty3.Location = new System.Drawing.Point(231, 168);
            this.txty3.Name = "txty3";
            this.txty3.Size = new System.Drawing.Size(100, 20);
            this.txty3.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Y3";
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(19, 252);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(59, 17);
            this.cbx1.TabIndex = 21;
            this.cbx1.Text = "Point 1";
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(84, 252);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(59, 17);
            this.cbx2.TabIndex = 22;
            this.cbx2.Text = "Point 2";
            this.cbx2.UseVisualStyleBackColor = true;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Location = new System.Drawing.Point(149, 252);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(59, 17);
            this.cbx3.TabIndex = 23;
            this.cbx3.Text = "Point 3";
            this.cbx3.UseVisualStyleBackColor = true;
            this.cbx3.Visible = false;
            // 
            // btnArea2
            // 
            this.btnArea2.Location = new System.Drawing.Point(192, 203);
            this.btnArea2.Name = "btnArea2";
            this.btnArea2.Size = new System.Drawing.Size(75, 23);
            this.btnArea2.TabIndex = 24;
            this.btnArea2.Text = "Area2";
            this.btnArea2.UseVisualStyleBackColor = true;
            this.btnArea2.Click += new System.EventHandler(this.btnArea2_Click);
            // 
            // txtArea2
            // 
            this.txtArea2.Location = new System.Drawing.Point(19, 296);
            this.txtArea2.Name = "txtArea2";
            this.txtArea2.Size = new System.Drawing.Size(100, 20);
            this.txtArea2.TabIndex = 25;
            // 
            // txtArea3
            // 
            this.txtArea3.Location = new System.Drawing.Point(149, 296);
            this.txtArea3.Name = "txtArea3";
            this.txtArea3.Size = new System.Drawing.Size(100, 20);
            this.txtArea3.TabIndex = 26;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(246, 81);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 27;
            this.btnCopy.Text = "P3 -> P2";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 371);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtArea3);
            this.Controls.Add(this.txtArea2);
            this.Controls.Add(this.btnArea2);
            this.Controls.Add(this.cbx3);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.txty3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcY3);
            this.Controls.Add(this.txtx3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSlope);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txty1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txty2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSlope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Slope & Area Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlope;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSlope;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtx3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcY3;
        private System.Windows.Forms.TextBox txty3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.CheckBox cbx3;
        private System.Windows.Forms.Button btnArea2;
        private System.Windows.Forms.TextBox txtArea2;
        private System.Windows.Forms.TextBox txtArea3;
        private System.Windows.Forms.Button btnCopy;
    }
}

