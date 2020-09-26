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
    public partial class BubleSort : UserControlNeed
    {
        public static bool is_run = false, current = false;

        public BubleSort(List<int> lst)
        {
            InitializeComponent();
            this.Size = new Size(1190, 377); is_run = false;
            for (int j = 0; j < lst.Count; j++) list.Add(lst[j]);
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
            bool swap = false;
            int z = list.Count - 1;
            do
            {
                swap = false;
                for (int j = 0; j < z; j++)
                {
                    if (j == 0)
                    {
                        listBox[0].BackColor = Color.Orange;
                        Thread.Sleep(period);
                        listBox[0].BackColor = Color.Red;
                    }
                    int idx = j + 1;
                    if (list[j] > list[j + 1])
                    {
                        int x = list[j], j_x = listBox[j].Location.X, j_xp = listBox[j + 1].Location.X;
                        list[j] = list[j + 1];
                        list[j + 1] = x;
                        TextBox s = listBox[j];
                        listBox[j] = listBox[j + 1];
                        listBox[j + 1] = s;
                        listBox[j + 1].Location = new Point(j_xp, listBox[j + 1].Location.Y);
                        listBox[j].Location = new Point(j_x, listBox[j].Location.Y);
                        swap = true;
                    }
                    listBox[idx].BackColor = Color.Orange;
                    Thread.Sleep(period);
                    listBox[idx].BackColor = Color.Red;
                }
                listBox[z].BackColor = Color.Green;
                z--;
            } while (swap && is_run);
            Thread.Sleep(period);
            for (int i = z; i >= 0; i--)
                listBox[i].BackColor = Color.Green;
            is_run = false;
        }
    }
}
