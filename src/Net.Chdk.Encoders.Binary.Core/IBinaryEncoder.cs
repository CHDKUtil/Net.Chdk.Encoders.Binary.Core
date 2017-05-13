using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryEncoder
    {
        void Encode(Stream inStream, Stream outStream, int version);
        void Encode(byte[] decBuffer, byte[] encBuffer, int version);
        int MaxVersion { get; }
    }
}
