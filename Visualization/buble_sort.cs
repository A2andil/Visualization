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
    public partial class buble_sort : user_control_need
    {
        public static bool is_run = false, current = false;

        public buble_sort(List<int> lst)
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
            bool swap = false;
            int z = list.Count - 1;
            do
            {
                swap = false;
                for (int j = 0; j < z; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int x = list[j], j_x = lst_bx[j].Location.X, j_xp = lst_bx[j + 1].Location.X;
                        list[j] = list[j + 1];
                        list[j + 1] = x;
                        TextBox s = lst_bx[j];
                        lst_bx[j] = lst_bx[j + 1];
                        lst_bx[j + 1] = s;
                        lst_bx[j + 1].Location = new Point(j_xp, lst_bx[j + 1].Location.Y);
                        lst_bx[j].Location = new Point(j_x, lst_bx[j].Location.Y);
                        swap = true;
                    }
                    lst_bx[j].BackColor = Color.Orange;
                    Thread.Sleep(period);
                    lst_bx[j].BackColor = Color.Red;
                }
                lst_bx[z].BackColor = Color.Green;
                z--;
            } while (swap && is_run);
            Thread.Sleep(period);
            for (int i = z; i >= 0; i--)
                lst_bx[i].BackColor = Color.Green;
            is_run = false;
        }
    }
}
