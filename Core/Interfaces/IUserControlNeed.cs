using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Core.Interfaces
{
    public interface IUserControlNeed
    {
        public void Shuffle();

        public void DrawElements();

        public TextBox CreateElement(int width, int val, int idx);
    }
}
