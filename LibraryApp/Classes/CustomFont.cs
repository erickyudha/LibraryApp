using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace LibraryApp.Classes
{
    class CustomFont
    {
        PrivateFontCollection pfcReg = new PrivateFontCollection();
        PrivateFontCollection pfcSB = new PrivateFontCollection();
        PrivateFontCollection pfcXB = new PrivateFontCollection();
        PrivateFontCollection pfcBlack = new PrivateFontCollection();

        public CustomFont()
        {
            int fontLen = Properties.Resources.Montserrat_Regular.Length;
            byte[] fontData = Properties.Resources.Montserrat_Regular;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLen);
            Marshal.Copy(fontData, 0, data, fontLen);
            pfcReg.AddMemoryFont(data, fontLen);

            fontLen = Properties.Resources.Montserrat_SemiBold.Length;
            fontData = Properties.Resources.Montserrat_SemiBold;
            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLen);
            Marshal.Copy(fontData, 0, data2, fontLen);
            pfcSB.AddMemoryFont(data2, fontLen);

            fontLen = Properties.Resources.Montserrat_ExtraBold.Length;
            fontData = Properties.Resources.Montserrat_ExtraBold;
            System.IntPtr data3 = Marshal.AllocCoTaskMem(fontLen);
            Marshal.Copy(fontData, 0, data3, fontLen);
            pfcXB.AddMemoryFont(data3, fontLen);

            fontLen = Properties.Resources.Montserrat_Black.Length;
            fontData = Properties.Resources.Montserrat_Black;
            System.IntPtr data4 = Marshal.AllocCoTaskMem(fontLen);
            Marshal.Copy(fontData, 0, data4, fontLen);
            pfcBlack.AddMemoryFont(data4, fontLen);
        }

        public void useRegular(Control label) 
        {
            label.Font = new Font(pfcReg.Families[0], label.Font.Size);
        }

        public void useSemiBold(Control label)
        {
            label.Font = new Font(pfcSB.Families[0], label.Font.Size);
        }

        public void useExtraBold(Control label)
        {
            label.Font = new Font(pfcXB.Families[0], label.Font.Size);
        }

        public void useBlack(Control label)
        {
            label.Font = new Font(pfcBlack.Families[0], label.Font.Size);
        }
    }
}
