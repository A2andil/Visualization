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
    public partial class selection_sort : user_control_sorting
    {
        public static bool is_run = false, current = false;

        public selection_sort(List<int> lst)
        {
            InitializeComponent();
            this.Size = new Size(1190, 377);
            list = lst;
            draw_elements();
        }

        public void start()
        {
            thrd = new Thread(new ThreadStart(update));
            thrd.Start();
            is_run = true;
        }

        private void update()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int min_idx = i, x = list[i];
                lst_bx[i].BackColor = Color.Gold;
                for (int j = i + 1; j < list.Count; j++)
                {
                    lst_bx[j].BackColor = Color.Orange;
                    if (list[j] < x)
                    {
                        lst_bx[min_idx].BackColor = Color.Red;
                        lst_bx[j].BackColor = Color.Gold;
                        x = list[j];
                        min_idx = j;
                    }
                    Thread.Sleep(period);
                    if (lst_bx[j].BackColor != Color.Gold)
                        lst_bx[j].BackColor = Color.Red;
                }
                list[min_idx] = list[i];
                list[i] = x;
                TextBox s = lst_bx[i];
                lst_bx[i] = lst_bx[min_idx];
                lst_bx[min_idx] = s;
                int m_x = lst_bx[i].Location.X, i_x = lst_bx[min_idx].Location.X;
                lst_bx[i].Location = new Point(i_x, lst_bx[i].Location.Y);
                lst_bx[min_idx].Location = new Point(m_x, lst_bx[min_idx].Location.Y);
                Thread.Sleep(period);
                lst_bx[i].BackColor = Color.Green;
            }
            is_run = false;
        }
    }

}
