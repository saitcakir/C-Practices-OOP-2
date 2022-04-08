
namespace hw2q1
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
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CirclePerimeter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CircleArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(66, 79);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(100, 22);
            this.textBox_R.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "R";
            // 
            // button_Calc
            // 
            this.button_Calc.Location = new System.Drawing.Point(213, 79);
            this.button_Calc.Name = "button_Calc";
            this.button_Calc.Size = new System.Drawing.Size(75, 23);
            this.button_Calc.TabIndex = 4;
            this.button_Calc.Text = "Calculate";
            this.button_Calc.UseVisualStyleBackColor = true;
            this.button_Calc.Click += new System.EventHandler(this.button_Calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "CirclePerimeter";
            // 
            // textBox_CirclePerimeter
            // 
            this.textBox_CirclePerimeter.Location = new System.Drawing.Point(495, 80);
            this.textBox_CirclePerimeter.Name = "textBox_CirclePerimeter";
            this.textBox_CirclePerimeter.Size = new System.Drawing.Size(100, 22);
            this.textBox_CirclePerimeter.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CircleArea";
            // 
            // textBox_CircleArea
            // 
            this.textBox_CircleArea.Location = new System.Drawing.Point(495, 52);
            this.textBox_CircleArea.Name = "textBox_CircleArea";
            this.textBox_CircleArea.Size = new System.Drawing.Size(100, 22);
            this.textBox_CircleArea.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CircleArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CirclePerimeter);
            this.Controls.Add(this.button_Calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_R);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CirclePerimeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CircleArea;
    }
}

