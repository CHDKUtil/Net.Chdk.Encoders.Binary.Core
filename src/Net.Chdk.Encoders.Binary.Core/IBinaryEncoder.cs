using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryEncoder
    {
        void Encode(Stream decStream, Stream encStream, byte[] decBuffer, byte[] encBuffer, ulong? offsets);
        void Encode(byte[] decBuffer, byte[] encBuffer, ulong? offsets);
        int MaxVersion { get; }
    }
}
