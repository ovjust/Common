using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
    public class ImageIO
    {
        public static Image ReadFile(string file)
        {
            return Image.FromFile(file);
        }
    }
}
