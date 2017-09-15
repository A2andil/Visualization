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
    public partial class insertion_sort : user_control_need

    {
        public static bool is_run = false, current = false;

        public insertion_sort(List<int> lst)
        {
            InitializeComponent();
            this.Size = new Size(1190, 377); is_run = false;
            for (int j = 0; j < lst.Count; j++) list.Add(lst[j]);
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
            lst_bx[0].BackColor = Color.Green;
            for (int i = 1; i < list.Count && is_run; i++)
            {
                lst_bx[i].BackColor = Color.Green;
                int x = list[i], j = i - 1;
                TextBox bx = lst_bx[i];
                while (j >= 0 && x < list[j])
                {
                    list[j + 1] = list[j];
                    lst_bx[j + 1] = lst_bx[j];
                    lst_bx[j + 1].Location = new Point((j + 1) * 45 + 5, lst_bx[j + 1].Location.Y);
                    j = j - 1;
                    Thread.Sleep(period);
                }
                list[j + 1] = x;
                lst_bx[j + 1] = bx;
                lst_bx[j + 1].Location = new Point((j + 1) * 45 + 5, lst_bx[j + 1].Location.Y);
                Thread.Sleep(period);
            }
            is_run = false;
        }
    }
}
