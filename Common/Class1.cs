using LibVLCSharp.Shared;

namespace Common
{
    public class Class1
    {
        private readonly LibVLC libvlc;

        Class1 ()
        {
            Core.Initialize();

            libvlc = new LibVLC();
        }
    }
}
