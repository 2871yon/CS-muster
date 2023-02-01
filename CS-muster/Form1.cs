using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_muster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] num2 = { 11, 12, 13, 14, 15,5,6,7,8,9};

            var list3=from n1 in num1
                       from n2 in num2
                       where n1<n2
                       select (n1,n2);
            var d=list3.ToList();   

        }
    }
}
