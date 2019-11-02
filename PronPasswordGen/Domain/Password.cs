using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PronPasswordGen.Domain
{
    public sealed class Password
    {
        public List<PasswordChunk> Chunks { get; set; }

        public string Text
        {
            get
            {
                if ((Chunks == null) || (Chunks.Count == 0))
                    return null;

                StringBuilder builder = new StringBuilder();
                foreach (PasswordChunk chunk in Chunks)
                    builder.Append(chunk.Text);
                return builder.ToString();
            }
        }


        public string TextDelimited
        {
            get
            {
                if ((Chunks == null) || (Chunks.Count == 0))
                    return null;

                StringBuilder builder = new StringBuilder();
                foreach (PasswordChunk chunk in Chunks)
                    builder.Append($"{chunk.Text}\t");

                return builder.ToString();
            }
        }



        public PasswordChunkType LastChunkType
        {
            get
            {
                if ((Chunks == null) || (Chunks.Count == 0))
                    return PasswordChunkType.None;
                return Chunks[Chunks.Count - 1].ChunkType;
            }
        }

        public int ChunkCount => Chunks?.Count ?? 0;

        public int PasswordLength => Text?.Length ?? 0;



        // .................................................

        public Password()
        {
            Chunks = new List<PasswordChunk>();
        }


        public void AppendChunk(PasswordChunk pChunk)
        {
            if((pChunk != null) && (pChunk.ChunkType != PasswordChunkType.None) && (!string.IsNullOrEmpty(pChunk.Text)))
                Chunks.Add(pChunk);
        }

        public void AppendChunk(PasswordChunk pChunk, int pIndex)
        {
            if ((pChunk == null) || (pChunk.ChunkType == PasswordChunkType.None) || (string.IsNullOrEmpty(pChunk.Text)))
                return;
            if ((pIndex < 0))
                return;

            if(pIndex >= Chunks.Count - 1)
                Chunks.Add(pChunk);

            Chunks.Insert(pIndex, pChunk);
        }


        public void ReplaceChunk(PasswordChunk pChunk, int pIndex)
        {
            if ((pChunk == null) || (pChunk.ChunkType == PasswordChunkType.None) || (string.IsNullOrEmpty(pChunk.Text)))
                return;
            if ((pIndex < 0))
                return;

            if (pIndex >= Chunks.Count - 1)
            {
                pIndex = Chunks.Count - 1;
            }

            Chunks[pIndex] = pChunk;
        }



        public string GetTextTrimmed(int pMaxLen)
        {
            if ((Chunks == null) || (Chunks.Count == 0))
                return null;

            StringBuilder builder = new StringBuilder();

            int len = 0;
            foreach (PasswordChunk chunk in Chunks)
            {
                if ((len + chunk.Text.Length) > pMaxLen)
                    break;

                builder.Append(chunk.Text);
            }

            return builder.ToString();
        }


        public string GetTextChunks(int pNumChunks)
        {
            if ((Chunks == null) || (Chunks.Count == 0))
                return null;

            StringBuilder builder = new StringBuilder();

            if (Chunks.Count < pNumChunks)
                pNumChunks = Chunks.Count;

            for (int count = 0; count < pNumChunks; ++count)
                builder.Append(Chunks[count].Text);

            return builder.ToString();
        }


        
        public bool CapitalizeChunk(int pIndex, bool pLastCharacter = false)
        {
            if ((Chunks == null) || (pIndex >= Chunks.Count))
                return false;

            if ((Chunks[pIndex].ChunkType == PasswordChunkType.None) ||
                (Chunks[pIndex].ChunkType == PasswordChunkType.Special))
                return false;

            string text = Chunks[pIndex].Text;
            
            if (pLastCharacter)
            {
                // TODO sss
                int chunkLen = text.Length;
                char c = text[chunkLen - 1];
                Chunks[pIndex].Text = text.Substring(0, chunkLen - 1) + Char.ToUpper(c);
                return true;
            }

            Chunks[pIndex].Text = Char.ToUpper(text[0]) + text.Substring(1);
            return true;
        }


    }
}
