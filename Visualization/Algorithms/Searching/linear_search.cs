using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Visualization
{
    public partial class linear_search : UserControlNeed
    {
        public static bool is_run = false, current = false;
        public int key = 0; 

        public linear_search(List<int> lst, int key)
        {
            InitializeComponent();
            for (int i = 0; i < lst.Count; i++) list.Add(lst[i]);
            is_run = false; this.key = key;
            DrawElements();
        }

        public void start()
        {
            thread = new Thread(new ThreadStart(update));
            thread.Start();
            is_run = true;
        }

        private void update()
        {
            for (int i = 0; i < list.Count; i++)
            {
                listBox[i].BackColor = Color.Gold;
                if (key == list[i])
                {
                    MessageBox.Show("searched value is in " + i.ToString());
                    is_run = false;
                    return;
                }
                Thread.Sleep(period);
                listBox[i].BackColor = Color.Red;
            }
            is_run = false;
            MessageBox.Show("value is not found");
        }


    }
}
