using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public interface IColor
    {
        bool GetColor(int x, int y);
    }
}
