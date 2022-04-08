
namespace hw2q4
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
            this.button_Calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Volume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Area = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Radius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CylinderHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(254, 98);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 13;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Volume";
            // 
            // textBox_Volume
            // 
            this.textBox_Volume.Location = new System.Drawing.Point(616, 99);
            this.textBox_Volume.Name = "textBox_Volume";
            this.textBox_Volume.Size = new System.Drawing.Size(100, 22);
            this.textBox_Volume.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Area";
            // 
            // textBox_Area
            // 
            this.textBox_Area.Location = new System.Drawing.Point(616, 71);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(100, 22);
            this.textBox_Area.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Radius";
            // 
            // textBox_Radius
            // 
            this.textBox_Radius.Location = new System.Drawing.Point(79, 80);
            this.textBox_Radius.Name = "textBox_Radius";
            this.textBox_Radius.Size = new System.Drawing.Size(100, 22);
            this.textBox_Radius.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Height";
            // 
            // textBox_CylinderHeight
            // 
            this.textBox_CylinderHeight.Location = new System.Drawing.Point(79, 108);
            this.textBox_CylinderHeight.Name = "textBox_CylinderHeight";
            this.textBox_CylinderHeight.Size = new System.Drawing.Size(100, 22);
            this.textBox_CylinderHeight.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_CylinderHeight);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Volume);
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

        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Radius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CylinderHeight;
    }
}

