
namespace hw2q3
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
            this.textBox_Radius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Circumference = new System.Windows.Forms.TextBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Radius
            // 
            this.textBox_Radius.Location = new System.Drawing.Point(169, 58);
            this.textBox_Radius.Name = "textBox_Radius";
            this.textBox_Radius.Size = new System.Drawing.Size(100, 22);
            this.textBox_Radius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // textBox_Area
            // 
            this.textBox_Area.Location = new System.Drawing.Point(706, 49);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(100, 22);
            this.textBox_Area.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Circumference";
            // 
            // textBox_Circumference
            // 
            this.textBox_Circumference.Location = new System.Drawing.Point(706, 77);
            this.textBox_Circumference.Name = "textBox_Circumference";
            this.textBox_Circumference.Size = new System.Drawing.Size(100, 22);
            this.textBox_Circumference.TabIndex = 4;
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(344, 76);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 6;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 450);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Circumference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Area);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Radius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Radius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Circumference;
        private System.Windows.Forms.Button button_Calculate;
    }
}

