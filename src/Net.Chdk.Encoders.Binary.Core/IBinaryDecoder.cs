using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool Decode(Stream encStream, Stream decStream, byte[] encBuffer, byte[] decBuffer, ulong? offsets);
        bool Decode(byte[] encBuffer, byte[] decBuffer, ulong? offsets);
        int MaxVersion { get; }
    }
}
