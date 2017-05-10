using System.IO;

namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryEncoder
    {
        void Encode(Stream inStream, Stream outStream, int version);
        int MaxVersion { get; }
    }
}
