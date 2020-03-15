using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Adapter
{
    class VgaStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
        }

        public byte[] GetData()
        {
            return _stream;
        }
    }
}
