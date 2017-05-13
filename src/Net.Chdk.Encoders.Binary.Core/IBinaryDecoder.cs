using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool Decode(Stream inStream, Stream outStream, int version);
        bool Decode(byte[] encBuffer, byte[] decBuffer, int version);
        int MaxVersion { get; }
    }
}
