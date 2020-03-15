using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Adapter
{
    class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        {
            VgaStream vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });
            return vgaStream;
        }
    }
}
