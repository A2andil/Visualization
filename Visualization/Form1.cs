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
    public partial class Form1 : Form
    {
        List<int> lst = new List<int>();
        insertion_sort in_sort;
        selection_sort sl_sort;
        buble_sort bl_sort;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        void insertion()
        {
            if (!insertion_sort.is_run)
            {
                label2.Text = "Algorithm : insertion sort sort";
                panel1.Controls.Clear();
                in_sort = new insertion_sort(lst);
                in_sort.random();
                panel1.Controls.Add(in_sort);
            }
        }

        void selection()
        {
            if (!selection_sort.is_run)
            {
                label2.Text = "Algorithm : selection sort";
                panel1.Controls.Clear();
                sl_sort = new selection_sort(lst);
                sl_sort.random();
                panel1.Controls.Add(sl_sort);
            }
        }

        void buble()
        {
            if (!buble_sort.is_run)
            {
                label2.Text = "Algorithm : buble sort";
                panel1.Controls.Clear();
                bl_sort = new buble_sort(lst);
                bl_sort.random();
                panel1.Controls.Add(bl_sort);
            }
        }
        private void btn_suffle_Click(object sender, EventArgs e)
        {
            buble();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 25; i >= 0; i--) lst.Add(i);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            bl_sort.start();
        }
    }
}
