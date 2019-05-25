using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cute_Pazzle
{
    class CutePictureBox:PictureBox
    {
        int index = 0;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        int imageIndex = 0;

        public int ImageIndex
        {
            get { return index; }
            set { index = value; }
        }
        public bool isMuch()
        {
            return (index == imageIndex);
        }
    }
}
