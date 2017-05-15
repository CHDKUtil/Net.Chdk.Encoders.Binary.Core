using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool Decode(Stream encStream, Stream decStream, ulong? offsets);
        bool Decode(byte[] encBuffer, byte[] decBuffer, ulong[] ulBuffer, ulong? offsets);
        int MaxVersion { get; }
    }
}
