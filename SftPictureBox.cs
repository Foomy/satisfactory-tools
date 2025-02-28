using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Tools
{
    internal class SftPictureBox : PictureBox
    {
        public SftPictureBox  Clone()
        {
            var newPb = new SftPictureBox()
            {
                Image = this.Image,
                Width = this.Width,
                Height = this.Height,
                Margin = this.Margin
            };

            return newPb;
        }
    }
}
