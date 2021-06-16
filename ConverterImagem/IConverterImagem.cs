using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConverterImagem
{
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IConverterImagem
    {
        [DispId(1)]
        void ConvertTo24bpp(string filePath);
    }
}
