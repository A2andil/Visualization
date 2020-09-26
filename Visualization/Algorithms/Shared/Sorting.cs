using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
    public partial class Sorting : Form
    {
        public static List<int> s_lst = new List<int>();
        public static Categories current_cat = null;
        InsertionSort in_sort;
        SelectionSort sl_sort;
        BubleSort bl_sort;
        public Sorting()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (current_cat != null) current_cat.Show();
            InsertionSort.is_run = false;
            BubleSort.is_run = false;
            SelectionSort.is_run = false;
            Close();
        }
        public void insertion(List<int> lst)
        {
            if (!InsertionSort.is_run)
            {
                label2.Text = "Algorithm : insertion sort";
                panel1.Controls.Clear();
                in_sort = new InsertionSort(lst);
                in_sort.Shuffle();
                panel1.Controls.Add(in_sort);
            }
        }

        public void selection(List<int> lst)
        {
            if (!SelectionSort.is_run)
            {
                label2.Text = "Algorithm : selection sort";
                panel1.Controls.Clear();
                sl_sort = new SelectionSort(lst);
                panel1.Controls.Add(sl_sort);
            }
        }

        public void buble(List<int> lst)
        {
            if (!BubleSort.is_run)
            {
                label2.Text = "Algorithm : buble sort";
                panel1.Controls.Clear();
                bl_sort = new BubleSort(lst);
                panel1.Controls.Add(bl_sort);
            }
        }
        private void btn_suffle_Click(object sender, EventArgs e)
        {
            if (SelectionSort.current && !SelectionSort.is_run) selection(shuffle());
            else if (BubleSort.current && !BubleSort.is_run) buble(shuffle());
            else if (InsertionSort.current && !InsertionSort.is_run) insertion(shuffle());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            period.Value = UserControlNeed.period;
        }

        List<int> shuffle()
        {
            List<int> tmp_lst = new List<int>();
            Random rand = new Random();
            int x = rand.Next(10, 26);
            for (int i = 0; i <= x; i++)
                tmp_lst.Add(rand.Next(0, 26));
            return tmp_lst;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (SelectionSort.current && !SelectionSort.is_run && sl_sort != null) sl_sort.start();
            else if (BubleSort.current && !BubleSort.is_run && bl_sort != null) bl_sort.start();
            else if (InsertionSort.current && !InsertionSort.is_run && in_sort != null) in_sort.start();
        }

        private void period_ValueChanged(object sender, EventArgs e)
        {
            UserControlNeed.period = int.Parse(period.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertList in_lst = new InsertList();
            in_lst.Show();
            InsertList.current_sort = this;
            this.Enabled = false;
        }
    }
}
