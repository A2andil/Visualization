using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Infrastructure.Repositories
{
    public class UserControlNeed : UserControl
    {
        public List<int> list = new List<int>();
        public List<TextBox> listBox = new List<TextBox>();
        public static int period = 100;
        public Thread currentThread = null;

        public TextBox CreateElement(int width, int val, int idx)
        {

            TextBox text = new TextBox();
            text.Multiline = true;
            text.ReadOnly = true;
            text.ForeColor = Color.White;
            text.BackColor = Color.Red;
            text.Text = val.ToString();
            text.Size = new Size(width, val * 10 + 30);
            text.Location = new Point(idx * (width + 5) + 5, 300 - val * 10);
            text.MaxLength = 4;
            //text.Font = new Font(text.Font.FontFamily, 14);
            text.TextAlign = HorizontalAlignment.Center;
            return text;
        }

        public void DrawElements()
        {
            listBox.Clear();
            TextBox text = null;
            for (int i = 0; i < list.Count; i++)
            {
                text = CreateElement(40, list[i], i);
                listBox.Add(text);
                this.Controls.Add(text);
            }
        }

        public void Shuffle()
        {
            this.Controls.Clear();
            Random rand = new Random();
            for (int i = 0; i < list.Count - 1; i++)
            {
                int idx = rand.Next(i + 1, list.Count - 1), x = list[i];
                list[i] = list[idx];
                list[idx] = x;
            }
            DrawElements();
        }
    }
}
