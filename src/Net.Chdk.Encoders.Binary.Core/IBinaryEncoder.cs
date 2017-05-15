using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryEncoder
    {
        void Encode(Stream decStream, Stream encStream, ulong? offsets);
        void Encode(byte[] decBuffer, byte[] encBuffer, ulong[] ulBuffer, ulong? offsets);
        int MaxVersion { get; }
    }
}
