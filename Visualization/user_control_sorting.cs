using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
    public class user_control_sorting : UserControl
    {
        public List<int> list = null;
        public List<TextBox> lst_bx = new List<TextBox>();
        public static int period = 100;
        public Thread thrd = null;

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

    }
}
