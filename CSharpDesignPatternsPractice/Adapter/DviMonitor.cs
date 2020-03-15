namespace CSharpDesignPatternsPractice.Adapter
{
    class DviMonitor
    {
        private byte[] _inputStream;
        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }
    }
}
