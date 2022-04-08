
namespace hw2q2
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
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Balance = new System.Windows.Forms.TextBox();
            this.textBox_YY = new System.Windows.Forms.TextBox();
            this.textBox_MM = new System.Windows.Forms.TextBox();
            this.textBox_DD = new System.Windows.Forms.TextBox();
            this.textBox_AccNo = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaxBalance = new System.Windows.Forms.TextBox();
            this.button_AvgAndMax = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_AVGBalance = new System.Windows.Forms.TextBox();
            this.button_SearchAccNum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_IsAccountExist = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MaxAccountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(365, 135);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(148, 30);
            this.button_Sort.TabIndex = 23;
            this.button_Sort.Text = "Sort";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(365, 105);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(148, 23);
            this.button_Add.TabIndex = 22;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "DAA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Acc No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // textBox_Balance
            // 
            this.textBox_Balance.Location = new System.Drawing.Point(220, 164);
            this.textBox_Balance.Name = "textBox_Balance";
            this.textBox_Balance.Size = new System.Drawing.Size(100, 22);
            this.textBox_Balance.TabIndex = 17;
            // 
            // textBox_YY
            // 
            this.textBox_YY.Location = new System.Drawing.Point(308, 136);
            this.textBox_YY.Name = "textBox_YY";
            this.textBox_YY.Size = new System.Drawing.Size(38, 22);
            this.textBox_YY.TabIndex = 16;
            // 
            // textBox_MM
            // 
            this.textBox_MM.Location = new System.Drawing.Point(264, 136);
            this.textBox_MM.Name = "textBox_MM";
            this.textBox_MM.Size = new System.Drawing.Size(38, 22);
            this.textBox_MM.TabIndex = 15;
            // 
            // textBox_DD
            // 
            this.textBox_DD.Location = new System.Drawing.Point(220, 136);
            this.textBox_DD.Name = "textBox_DD";
            this.textBox_DD.Size = new System.Drawing.Size(38, 22);
            this.textBox_DD.TabIndex = 14;
            // 
            // textBox_AccNo
            // 
            this.textBox_AccNo.Location = new System.Drawing.Point(220, 108);
            this.textBox_AccNo.Name = "textBox_AccNo";
            this.textBox_AccNo.Size = new System.Drawing.Size(100, 22);
            this.textBox_AccNo.TabIndex = 13;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(220, 80);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Max Balance";
            // 
            // textBox_MaxBalance
            // 
            this.textBox_MaxBalance.Location = new System.Drawing.Point(626, 166);
            this.textBox_MaxBalance.Name = "textBox_MaxBalance";
            this.textBox_MaxBalance.Size = new System.Drawing.Size(100, 22);
            this.textBox_MaxBalance.TabIndex = 24;
            // 
            // button_AvgAndMax
            // 
            this.button_AvgAndMax.Location = new System.Drawing.Point(365, 171);
            this.button_AvgAndMax.Name = "button_AvgAndMax";
            this.button_AvgAndMax.Size = new System.Drawing.Size(148, 46);
            this.button_AvgAndMax.TabIndex = 26;
            this.button_AvgAndMax.Text = "Fin Max and AVG Balance";
            this.button_AvgAndMax.UseVisualStyleBackColor = true;
            this.button_AvgAndMax.Click += new System.EventHandler(this.button_AvgAndMax_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "AVG Balance";
            // 
            // textBox_AVGBalance
            // 
            this.textBox_AVGBalance.Location = new System.Drawing.Point(626, 130);
            this.textBox_AVGBalance.Name = "textBox_AVGBalance";
            this.textBox_AVGBalance.Size = new System.Drawing.Size(100, 22);
            this.textBox_AVGBalance.TabIndex = 27;
            // 
            // button_SearchAccNum
            // 
            this.button_SearchAccNum.Location = new System.Drawing.Point(365, 223);
            this.button_SearchAccNum.Name = "button_SearchAccNum";
            this.button_SearchAccNum.Size = new System.Drawing.Size(148, 46);
            this.button_SearchAccNum.TabIndex = 29;
            this.button_SearchAccNum.Text = "SearchAccNum";
            this.button_SearchAccNum.UseVisualStyleBackColor = true;
            this.button_SearchAccNum.Click += new System.EventHandler(this.button_SearchAccNum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "IsAccountExist";
            // 
            // textBox_IsAccountExist
            // 
            this.textBox_IsAccountExist.Location = new System.Drawing.Point(626, 206);
            this.textBox_IsAccountExist.Name = "textBox_IsAccountExist";
            this.textBox_IsAccountExist.Size = new System.Drawing.Size(100, 22);
            this.textBox_IsAccountExist.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "MaxAccountNumber";
            // 
            // textBox_MaxAccountNumber
            // 
            this.textBox_MaxAccountNumber.Enabled = false;
            this.textBox_MaxAccountNumber.Location = new System.Drawing.Point(220, 362);
            this.textBox_MaxAccountNumber.Name = "textBox_MaxAccountNumber";
            this.textBox_MaxAccountNumber.Size = new System.Drawing.Size(100, 22);
            this.textBox_MaxAccountNumber.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_MaxAccountNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_IsAccountExist);
            this.Controls.Add(this.button_SearchAccNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_AVGBalance);
            this.Controls.Add(this.button_AvgAndMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_MaxBalance);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Balance);
            this.Controls.Add(this.textBox_YY);
            this.Controls.Add(this.textBox_MM);
            this.Controls.Add(this.textBox_DD);
            this.Controls.Add(this.textBox_AccNo);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Balance;
        private System.Windows.Forms.TextBox textBox_YY;
        private System.Windows.Forms.TextBox textBox_MM;
        private System.Windows.Forms.TextBox textBox_DD;
        private System.Windows.Forms.TextBox textBox_AccNo;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MaxBalance;
        private System.Windows.Forms.Button button_AvgAndMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_AVGBalance;
        private System.Windows.Forms.Button button_SearchAccNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_IsAccountExist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_MaxAccountNumber;
    }
}

