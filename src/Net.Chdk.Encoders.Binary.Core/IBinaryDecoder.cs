using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool Decode(Stream encStream, Stream decStream, int version);
        bool Decode(byte[] encBuffer, byte[] decBuffer, ulong? offsets);
        int MaxVersion { get; }
    }
}
