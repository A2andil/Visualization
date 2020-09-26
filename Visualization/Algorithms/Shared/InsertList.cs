using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
    public partial class InsertList : Form
    {
        public static Sorting current_sort = null;
        public InsertList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current_sort.Enabled = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sorting.s_lst.Clear();
            try
            {
                string[] list = textBox1.Text.Split(' ');
                for (int i = 0; i < list.Length; i++)
                {
                    int x = int.Parse(list[i]);
                    if (x < 26) Sorting.s_lst.Add(x);
                    else if (x >= 26 || Sorting.s_lst.Count > 26)
                    {
                        MessageBox.Show("each element value should be < 26");
                        Sorting.s_lst.Clear();
                        return;
                    }
                }
                if (selection_sort.current && !selection_sort.is_run) current_sort.selection(Sorting.s_lst);
                else if (BubleSort.current && !BubleSort.is_run) current_sort.buble(Sorting.s_lst);
                else if (InsertionSort.current && !InsertionSort.is_run) current_sort.insertion(Sorting.s_lst);
            }
            catch
            {
                MessageBox.Show("invalid input");
            }
            current_sort.Enabled = true;
            Close();
        }


    }
}
