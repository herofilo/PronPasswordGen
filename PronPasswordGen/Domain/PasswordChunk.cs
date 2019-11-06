using System;

namespace PronPasswordGen.Domain
{
    public sealed class PasswordChunk
    {
        public string Text { get; set; }

        public PasswordChunkType ChunkType { get; set; }


        public bool CapitalizedFirst => ((Text?.Length ?? 0) >0) && Char.IsUpper(Text[0]);

        public bool CapitalizedLast => ((Text?.Length ?? 0) > 0) && Char.IsUpper(Text[Text.Length - 1]);

    }
}