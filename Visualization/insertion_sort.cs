using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace Visualization
{
    public partial class insertion_sort : UserControlNeed

    {
        
        public static bool is_run = false, current = false;

        public insertion_sort(List<int> lst)
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
            listBox[0].BackColor = Color.Green;
            for (int i = 1; i < list.Count && is_run; i++)
            {
                listBox[i].BackColor = Color.Green;
                int x = list[i], j = i - 1;
                TextBox bx = listBox[i];
                listBox[i].BackColor = Color.Orange;
                while (j >= 0 && x < list[j])
                { 
                    Thread.Sleep(period);
                    list[j + 1] = list[j];
                    listBox[j + 1] = listBox[j];
                    listBox[j + 1].Location = new Point((j + 1) * 45 + 5, listBox[j + 1].Location.Y);
                    j = j - 1;
                }
                list[j + 1] = x;
                listBox[j + 1] = bx;
                listBox[j + 1].Location = new Point((j + 1) * 45 + 5, listBox[j + 1].Location.Y);
                Thread.Sleep(period);
                bx.BackColor = Color.Green;
            }
            is_run = false;
        }
    }
}
