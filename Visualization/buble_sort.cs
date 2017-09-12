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
    public partial class buble_sort : UserControl
    {
        public List<int> list = null;
        public List<TextBox> lst_bx = new List<TextBox>();
        public static int period = 100;
        public Thread thrd = null;
        public static bool is_run = false;

        public buble_sort(List<int> lst)
        {
            InitializeComponent();
            this.Size = new Size(1190, 377);
            list = lst;
            draw_elements();
        }


        public void draw_elements()
        {
            lst_bx.Clear();
            TextBox txt = null;
            for (int i = 0; i < list.Count; i++)
            {
                txt = create_element(40, list[i], i);
                lst_bx.Add(txt);
                this.Controls.Add(txt);
            }
        }

        public void start()
        {
            thrd = new Thread(new ThreadStart(update));
            thrd.Start();
            is_run = true;
        }

        public TextBox create_element(int width, int val, int idx)
        {
            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.ReadOnly = true;
            txt.ForeColor = Color.White;
            txt.BackColor = Color.Red;
            txt.Text = val.ToString();
            txt.Size = new Size(width, val * 10 + 30);
            txt.Location = new Point(idx * (width + 5) + 5, 300 - val * 10);
            txt.MaxLength = 4;
            txt.Font = new Font(txt.Font.FontFamily, 14);
            txt.TextAlign = HorizontalAlignment.Center;
            return txt;
        }

        public void random()
        {
            this.Controls.Clear();
            Random rand = new Random();
            for (int i = 0; i < list.Count - 1; i++)
            {
                int idx = rand.Next(i + 1, list.Count - 1), x = list[i];
                list[i] = list[idx];
                list[idx] = x;
            }
            draw_elements();
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
                        Thread.Sleep(period);
                    }
                }
                lst_bx[z].BackColor = Color.Green;
                z--;
            } while (swap);
            for (int i = 0; i <= z; i++) lst_bx[i].BackColor = Color.Green;
            is_run = false;
        }
    }
}
