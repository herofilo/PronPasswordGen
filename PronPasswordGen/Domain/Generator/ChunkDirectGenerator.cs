using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PronPasswordGen.Util;

namespace PronPasswordGen.Domain.Generator
{
    public class ChunkDirectGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {

        // ------------------------------------------------------------------------------------------------------------------

        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.Direct;

            chunk.Text = $"{Consonants[Random.Next(ConsonantsLength)]}{Vowels[Random.Next(VowelsLength)]}";

            return chunk;
        }
    }


    public class ChunkDirectDipGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {


        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.DirectDiphtongue;

            chunk.Text = $"{Consonants[Random.Next(ConsonantsLength)]}{GetDiphtongue()}";

            return chunk;
        }
    }



    public class ChunkInvertedGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {


        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.Inverted;

            chunk.Text = $"{Vowels[Random.Next(VowelsLength)]}{Consonants[Random.Next(ConsonantsLength)]}";

            return chunk;
        }
    }


    public class ChunkInvertedDipGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {


        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.InvertedDiphtongue;

            chunk.Text = $"{GetDiphtongue()}{Consonants[Random.Next(ConsonantsLength)]}";

            return chunk;
        }
    }



    public class ChunkMixedGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {


        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.Mixed;

            chunk.Text = $"{Consonants[Random.Next(ConsonantsLength)]}{Vowels[Random.Next(VowelsLength)]}{Consonants[Random.Next(ConsonantsLength)]}";

            return chunk;
        }
    }


    public class ChunkLiquidGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {


        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.Liquidified;

            char liquidCompanion = LiquidCompanions[Random.Next(LiquidCompanionsLength)];

            string liquid = 
            (LiquidCompanionsRestricted.Contains(liquidCompanion)) 
                ? "r"
                : Utils.Coin() ? "l" : "r";

            chunk.Text = $"{liquidCompanion}{liquid}{Vowels[Random.Next(VowelsLength)]}";

            return chunk;
        }
    }


    public class ChunkSpecialGenerator : PasswordChunkGeneratorBase, IPasswordChunkGenerator
    {


        public new PasswordChunk Get(PasswordChunk pReferenceChunk)
        {
            PasswordChunk chunk = new PasswordChunk();
            chunk.ChunkType = PasswordChunkType.Special;

            int referenceChunkLength = pReferenceChunk.Text.Length;

            int length = referenceChunkLength + ((Utils.Coin() || Utils.Coin()) ? 0 : 1);

            string text = "";
            for (int count = 1; count < length; ++count)
            {
                text += Numbers[Random.Next(NumbersLength)];
            }

            bool specialFirst = Utils.Coin();
            char special = Specials[Random.Next(Specials.Length)];

            chunk.Text = specialFirst
                ? chunk.Text = $"{special}{text}"
                : text + special;

            return chunk;
        }
    }


}
