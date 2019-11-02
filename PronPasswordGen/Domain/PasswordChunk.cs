namespace PronPasswordGen.Domain
{
    public sealed class PasswordChunk
    {
        public string Text { get; set; }

        public PasswordChunkType ChunkType { get; set; }
    }
}