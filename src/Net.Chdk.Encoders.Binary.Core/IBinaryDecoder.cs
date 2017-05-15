using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool Decode(Stream encStream, Stream decStream, byte[] encBuffer, byte[] decBuffer, uint? offsets);
        bool Decode(byte[] encBuffer, byte[] decBuffer, ulong[] ulBuffer, uint? offsets);
        int MaxVersion { get; }
    }
}
