namespace Net.Chdk.Encoders.Binary
{
    public interface IBinaryDecoder
    {
        bool ValidatePrefix(byte[] encBuffer, int size);
        void Decode(byte[] encBuffer, byte[] decBuffer, uint offsets);
        int MaxVersion { get; }
    }
}
