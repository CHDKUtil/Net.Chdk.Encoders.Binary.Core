using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryEncoder
    {
        void Encode(Stream decStream, Stream encStream, byte[] decBuffer, byte[] encBuffer, uint? offsets);
        int MaxVersion { get; }
    }
}
