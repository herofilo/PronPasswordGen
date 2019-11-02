using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PronPasswordGen.Domain
{
    public sealed class PasswordGenerator
    {

        public const int PasswordMinLength = 6;

        public const string SeparatorsDefault = ".,;:-_";

        public static string Separators
        {
            get { return _separators; }
            set
            {
                if (value == null)
                {
                    _separators = SeparatorsDefault;
                    return;
                }
                string newSeparators = "";
                foreach (char c in value)
                {
                    if (Char.IsLetterOrDigit(c) || Char.IsControl(c))
                        continue;
                    newSeparators += c;
                }

                if (string.IsNullOrEmpty(newSeparators))
                    newSeparators = SeparatorsDefault;

                _separators = newSeparators;
            }
        }

        private static string _separators = SeparatorsDefault;

        public Password LastPassword { get; private set; }

        // Dictionary tipo -> gen
        private Dictionary<PasswordChunkType, IPasswordChunkGenerator> _chunkGenerators;

        private Dictionary<PasswordChunkType, int> _chunkTypeProbability = new Dictionary<PasswordChunkType, int>()
        {
            {PasswordChunkType.Direct, 50 },
            {PasswordChunkType.DirectDiphtongue, 10 },
            {PasswordChunkType.Inverted, 10 },
            {PasswordChunkType.InvertedDiphtongue, 5 },
            {PasswordChunkType.Mixed, 20 },
            {PasswordChunkType.Liquidified, 20 }
        };

        private List<PasswordChunkType> _typeValuesGeneral, _typeValuesAftedDirectDip;

        private Random _random = new Random();
        


        // -----------------------------------------------------------------------------------------------------------------------------

        public PasswordGenerator()
        {
            CreateChunkGenerators();

            PopulateTypeLists();

        }


        private void CreateChunkGenerators()
        {
            _chunkGenerators = new Dictionary<PasswordChunkType, IPasswordChunkGenerator>();

            _chunkGenerators.Add(PasswordChunkType.Direct, new ChunkDirectGenerator());
            _chunkGenerators.Add(PasswordChunkType.DirectDiphtongue, new ChunkDirectDipGenerator());

            _chunkGenerators.Add(PasswordChunkType.Inverted, new ChunkInvertedGenerator());
            _chunkGenerators.Add(PasswordChunkType.InvertedDiphtongue, new ChunkInvertedDipGenerator());
            _chunkGenerators.Add(PasswordChunkType.Mixed, new ChunkMixedGenerator());
            _chunkGenerators.Add(PasswordChunkType.Liquidified, new ChunkLiquidGenerator());
            _chunkGenerators.Add(PasswordChunkType.Special, new ChunkSpecialGenerator());

        }


        private void PopulateTypeLists()
        {
            _typeValuesGeneral = new List<PasswordChunkType>();
            _typeValuesAftedDirectDip = new List<PasswordChunkType>();

            foreach (KeyValuePair<PasswordChunkType, int> item in _chunkTypeProbability)
            {
                bool appendAlternative = (item.Key != PasswordChunkType.Inverted ||
                                          item.Key != PasswordChunkType.InvertedDiphtongue);

                for (int count = 0; count < item.Value; ++count)
                {
                    _typeValuesGeneral.Add(item.Key);
                    if (appendAlternative)
                        _typeValuesAftedDirectDip.Add(item.Key);
                }
            }
        }


        // .................................................................................................

        public string Generate(int pLength, PasswordGeneratorOptions pOptions = PasswordGeneratorOptions.None, char pFixedSeparator = '.')
        {
            if (pLength < PasswordMinLength)
                pLength = PasswordMinLength;

            Password password = new Password();
            while (password.PasswordLength < pLength)
            {
                PasswordChunk chunk = GenerateNextChunk(password);
                password.AppendChunk(chunk);
            }

            if (pOptions.HasFlag(PasswordGeneratorOptions.Specials))
                InsertSpecialChunk(password);

            if (pOptions.HasFlag(PasswordGeneratorOptions.Capitals))
                CapitalizePassword(password);

            if (pOptions.HasFlag(PasswordGeneratorOptions.Separators))
                InsertSeparators(password, pOptions.HasFlag(PasswordGeneratorOptions.SeparatorRotation), pFixedSeparator);

            LastPassword = password;

            return password.Text;
        }




        private PasswordChunk GenerateNextChunk(Password pPassword)
        {
            PasswordChunkType type = ChooseNextChunkType(pPassword);

            IPasswordChunkGenerator generator = _chunkGenerators[type];

            return generator.Get(null);
        }




        private PasswordChunkType ChooseNextChunkType(Password pPassword)
        {


            List<PasswordChunkType> list = (pPassword.LastChunkType == PasswordChunkType.DirectDiphtongue)
                ? _typeValuesAftedDirectDip
                : _typeValuesGeneral;

            return list[_random.Next(list.Count)];
        }

        // ----------------------------------------------------------------------------------------------------------------------------

        private void InsertSpecialChunk(Password pPassword)
        {
            int index = _random.Next(pPassword.ChunkCount);

            PasswordChunk specialChunk = _chunkGenerators[PasswordChunkType.Special].Get(pPassword.Chunks[index]);

            pPassword.ReplaceChunk(specialChunk, index);
        }

        // ----------------------------------------------------------------------------------------------------------------------------

        private void CapitalizePassword(Password pPassword)
        {
            int capitalized = 0;

            do
            {
                int probability = 50;
                for (int index = 0; index < pPassword.ChunkCount; ++index)
                {
                    if (_random.Next(100) < probability)
                    {
                        bool lastLetter = Utils.Coin();
                        if (pPassword.CapitalizeChunk(index, lastLetter))
                        {
                            capitalized++;
                            probability -= 20;
                            if (probability <= 0)
                                break;
                        }
                    }
                }
            } while (capitalized == 0);
        }



        private void InsertSeparators(Password pPassword, bool pRotatory, char pFixedSeparator)
        {
            int chunksCount = pPassword.ChunkCount;


            string set = GetSeparatorsSet(chunksCount, pRotatory, $"{pFixedSeparator}");

            for (int index = 0; index < (chunksCount - 1); ++index)
            {
                pPassword.Chunks[index].Text += set[index];
            }
        }



        private string GetSeparatorsSet(int pCount, bool pRotatory, string pFixed)
        {
            StringBuilder builder = new StringBuilder();
            if (!pRotatory)
            {
                for (int count = 0; count < pCount; ++count)
                    builder.Append(pFixed);
                return builder.ToString();
            }

            int separatorsMaxIndex = Separators.Length - 1;
            int index = (separatorsMaxIndex == 0) ? 0 : _random.Next(Separators.Length);
            for (int count = 0; count < pCount; ++count)
            {
                char c = Separators[index];
                builder.Append(c);
                index++;
                if (index > separatorsMaxIndex)
                    index = 0;
            }

            return builder.ToString();
        }
    }

    [Flags]
    public enum PasswordGeneratorOptions
    {
        None = 0,
        Capitals = 0x1000,
        Specials = 0x2000,
        Separators = 0x4000,
        SeparatorRotation = 0x0002
    }


}
