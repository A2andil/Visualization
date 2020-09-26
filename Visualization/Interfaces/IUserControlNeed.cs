using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization.Interfaces
{
    public interface IUserControlNeed
    {
        void DrawElements();

        TextBox CreateElement(int width, int val, int idx);

        void Shuffle();
    }
}
