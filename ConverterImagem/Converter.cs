using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConverterImagem
{
    //[ComSourceInterfaces(typeof(IConverterImagem))]
    [ClassInterface(ClassInterfaceType.None)]
    public class Converter : IConverterImagem
    {

        public void ConvertTo24bpp(string filePath)
        {
            var img = Image.FromFile(filePath);

            var bmp = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height));

            img.Dispose();
            bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
