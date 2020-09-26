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
        insertion_sort in_sort;
        selection_sort sl_sort;
        buble_sort bl_sort;
        public Sorting()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (current_cat != null) current_cat.Show();
            insertion_sort.is_run = false;
            buble_sort.is_run = false;
            selection_sort.is_run = false;
            Close();
        }
        public void insertion(List<int> lst)
        {
            if (!insertion_sort.is_run)
            {
                label2.Text = "Algorithm : insertion sort";
                panel1.Controls.Clear();
                in_sort = new insertion_sort(lst);
                in_sort.Shuffle();
                panel1.Controls.Add(in_sort);
            }
        }

        public void selection(List<int> lst)
        {
            if (!selection_sort.is_run)
            {
                label2.Text = "Algorithm : selection sort";
                panel1.Controls.Clear();
                sl_sort = new selection_sort(lst);
                panel1.Controls.Add(sl_sort);
            }
        }

        public void buble(List<int> lst)
        {
            if (!buble_sort.is_run)
            {
                label2.Text = "Algorithm : buble sort";
                panel1.Controls.Clear();
                bl_sort = new buble_sort(lst);
                panel1.Controls.Add(bl_sort);
            }
        }
        private void btn_suffle_Click(object sender, EventArgs e)
        {
            if (selection_sort.current && !selection_sort.is_run) selection(shuffle());
            else if (buble_sort.current && !buble_sort.is_run) buble(shuffle());
            else if (insertion_sort.current && !insertion_sort.is_run) insertion(shuffle());
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
            if (selection_sort.current && !selection_sort.is_run && sl_sort != null) sl_sort.start();
            else if (buble_sort.current && !buble_sort.is_run && bl_sort != null) bl_sort.start();
            else if (insertion_sort.current && !insertion_sort.is_run && in_sort != null) in_sort.start();
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
