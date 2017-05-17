using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool ValidatePrefix(byte[] encBuffer, int size);
        bool Decode(Stream encStream, Stream decStream, byte[] encBuffer, byte[] decBuffer, uint? offsets);
        int MaxVersion { get; }
    }
}
