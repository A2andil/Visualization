using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Visualization
{
    public partial class Categories : Form
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        public Categories()
        {
            InitializeComponent();
            map.Add("Search Algorithms", new List<string>() { "linear search", "binary search" });
            map.Add("Sorting Algoritms", new List<string>() {"insertion sort", "buble sort", "selection sort"});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Sorting Algoritms":
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "insertion sort":
                            insertion_sort.current = true;
                            selection_sort.current = false;
                            buble_sort.current = false;
                            break;
                        case "selection sort":
                            insertion_sort.current = false;
                            selection_sort.current = true;
                            buble_sort.current = false;
                            break;
                        case "buble sort":
                            insertion_sort.current = false;
                            selection_sort.current = false;
                            buble_sort.current = true;
                            break;
                    }
                    Sorting srt = new Sorting();
                    srt.Show();
                    this.Hide();
                    Sorting.current_cat = this;
                    break;
            }
        }

        private void cmbx_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (string x in map[comboBox1.SelectedItem.ToString()])
                comboBox2.Items.Add(x);
        }
    }
}
