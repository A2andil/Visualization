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
    public partial class selection_sort : UserControl
    {
        public List<int> list = null;
        public List<TextBox> lst_bx = new List<TextBox>();
        public static int period = 100;
        public Thread thrd = null;
        public static bool is_run = false;

        public selection_sort(List<int> lst)
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
            for (int i = 0; i < list.Count; i++)
            {
                int min_idx = i, x = list[i];
                lst_bx[i].BackColor = Color.Orange;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < x)
                    {
                        lst_bx[min_idx].BackColor = Color.Red;
                        lst_bx[j].BackColor = Color.Orange;
                        x = list[j];
                        min_idx = j;
                        Thread.Sleep(period);
                    }
                    Thread.Sleep(period / 4);
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
