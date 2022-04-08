using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int maxaccount = 5;
        int accountnumber = 0;
        int m = 0;
        float avg = 0;

        public AccData[] Acc_List = new AccData[maxaccount];
        public AccData temp = new AccData();
        public AccData max = new AccData();


        static void Sort(ref AccData[] Acc_List, int N)
        {
            int i, j;
            AccData temp = new AccData();

            for (i = 0; i < N - 1; i++)
            {
                for (j = i; j < N - i - 1; j++)
                {
                    if (Acc_List[j].Acc_No > Acc_List[j + 1].Acc_No)
                    {
                        temp = Acc_List[j];
                        Acc_List[j] = Acc_List[j + 1];
                        Acc_List[j + 1] = temp;
                    }
                }
            }
        }
        void AvgAndMax(AccData[] Acc_List, int N)
        {
            max = Acc_List[0];
            float sum = 0;

            for (int i = 0; i < N; i++)
            {

                sum += Acc_List[i].Balance;
            }
            avg = sum / (float)accountnumber;

            for (int i = 1; i < N; i++)
            {
                if (max.Balance < Acc_List[i].Balance)
                {
                    temp = Acc_List[i];
                    Acc_List[i] = max;
                    max = temp;
                }
            }
        }
        static int SearchAccNum(AccData[] Acc_List, int Acc_Num, int N)
        {
            int var = 0;

            for (int i = 0; i < N; i++)
            {
                if (Acc_Num == Acc_List[i].Acc_No)
                {
                    var = 1;
                }
            }

            return var;
        }
        public class MyDate
        {
            public int DD;
            public int MM;
            public int YY;
        }

        public class AccData
        {
            public string Name;
            public int Acc_No;
            public MyDate DAA;
            public float Balance;

            public AccData()
            {
                DAA = new MyDate();

            }
        }
        public static void Add(ref AccData[] Acc_List, AccData AccNew, int N)
        {
            Acc_List[N] = AccNew;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            while (m == 0)
            {
                for (int i = 0; i < maxaccount; i++)
                {
                    Acc_List[i] = new AccData();
                }
                m++;
            }
            AccData AccNew = new AccData();
            AccNew.Name = textBox_Name.Text;
            int.TryParse(textBox_AccNo.Text, out AccNew.Acc_No);
            int.TryParse(textBox_DD.Text, out AccNew.DAA.DD);
            int.TryParse(textBox_MM.Text, out AccNew.DAA.MM);
            int.TryParse(textBox_YY.Text, out AccNew.DAA.YY);
            float.TryParse(textBox_Balance.Text, out AccNew.Balance);
            if (accountnumber > 4)
            {
                MessageBox.Show("Error: max account number exceeded");
            }
            else
            {
                textBox_MaxAccountNumber.Text = accountnumber.ToString();
                Add(ref Acc_List, AccNew, accountnumber);
                accountnumber++;
            }

        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            Sort(ref Acc_List, accountnumber);
        }

        private void button_AvgAndMax_Click(object sender, EventArgs e)
        {
            AvgAndMax(Acc_List, accountnumber);
            textBox_AVGBalance.Text = avg.ToString();
            textBox_MaxBalance.Text = max.Balance.ToString();
        }

        private void button_SearchAccNum_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_AccNo.Text, out int m);
            textBox_IsAccountExist.Text = SearchAccNum(Acc_List, m, accountnumber).ToString();
        }
    }
}
