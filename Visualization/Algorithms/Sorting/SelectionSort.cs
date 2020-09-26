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
    public partial class selection_sort : UserControlNeed
    {
        public static bool is_run = false, current = false;

        public selection_sort(List<int> lst)
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
            for (int i = 0; i < list.Count && is_run; i++)
            {
                int min_idx = i, x = list[i];
                listBox[i].BackColor = Color.Gold;
                for (int j = i + 1; j < list.Count; j++)
                {
                    listBox[j].BackColor = Color.Orange;
                    if (list[j] < x)
                    {
                        listBox[min_idx].BackColor = Color.Red;
                        listBox[j].BackColor = Color.Gold;
                        x = list[j];
                        min_idx = j;
                    }
                    Thread.Sleep(period);
                    if (listBox[j].BackColor != Color.Gold)
                        listBox[j].BackColor = Color.Red;
                }
                list[min_idx] = list[i];
                list[i] = x;
                TextBox s = listBox[i];
                listBox[i] = listBox[min_idx];
                listBox[min_idx] = s;
                int m_x = listBox[i].Location.X, i_x = listBox[min_idx].Location.X;
                listBox[i].Location = new Point(i_x, listBox[i].Location.Y);
                listBox[min_idx].Location = new Point(m_x, listBox[min_idx].Location.Y);
                Thread.Sleep(period);
                listBox[i].BackColor = Color.Green;
            }
            is_run = false;
        }
    }

}
