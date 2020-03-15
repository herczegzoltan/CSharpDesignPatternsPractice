using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Adapter
{
    class VgaGraphicsCardAdapter
    {
        private VgaGraphicsCard _vgaGraphicsCard;

        public VgaGraphicsCardAdapter(VgaGraphicsCard vgaGraphicsCard)
        {
            _vgaGraphicsCard = vgaGraphicsCard;

        }

        public DviStream GetDviStream()
        {
            byte[] data = _vgaGraphicsCard.GetVgaStream().GetData();
            //process and convert the vga video into the dvi video data
            byte[] dviVideoData = ConvertFromVgdToDvi(data);

            DviStream dviStream = new DviStream();
            dviStream.SetData(dviVideoData);
            return dviStream;
        }

        private byte[] ConvertFromVgdToDvi(byte[] input)
        {
            Console.WriteLine("Converted VGD Video to DVI video");

            return new byte[] { };
        }
    }
}
