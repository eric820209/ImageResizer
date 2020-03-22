using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    public class BitMapPathBindingModel
    {
        public Task<Bitmap> Job { get; set; }
        public string FilePath { get; set; }
    }
}
