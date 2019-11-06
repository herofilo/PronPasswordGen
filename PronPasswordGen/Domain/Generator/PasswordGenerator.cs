using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PronPasswordGen.Util;

namespace PronPasswordGen.Domain.Generator
{
    public sealed class PasswordGenerator
    {

        public const int PasswordMinLength = 6;

        public const int PasswordDefaultLength = 8;

        public const char FixedSeparatorDefault = '.';

        public const int CapitalsMinimumDefault = 1;

        public const int CapitalsMaximumDefault = 99;

        public const int SpecialGroupsMinDefault = 1;

        public const int SpecialGroupsMaxDefault = 1;


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

        private Dictionary<PasswordChunkType, int> _chunkTypeProbability = PasswordChunkTypeWeight.ChunkTypeProbabilityDefault;

        private List<PasswordChunkType> _typeValuesGeneral, _typeValuesAfterDirectDip, _typeValuesAfterDirect;

        private Random _random = new Random();


        // -----------------------------------------------------------------------------------------------------------------------------

        public PasswordGenerator()
        {
            CreateChunkGenerators();

            PopulateTypeLists();

        }

        #region Initialization
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


        public List<PasswordChunkTypeWeight> GetChunkTypeWeights()
        {
            return PasswordChunkTypeWeight.GetChunkTypeWeights(_chunkTypeProbability);
        }



        public bool SetChunkTypeWeights(List<PasswordChunkTypeWeight> pWeights)
        {
            Dictionary<PasswordChunkType, int> newProbabilities = PasswordChunkTypeWeight.ChunkTypeWeightsToProbabilities(pWeights);
            if (newProbabilities == null)
                return false;

            _chunkTypeProbability = newProbabilities;

            PopulateTypeLists();

            return true;
        }



        private void PopulateTypeLists()
        {
            _typeValuesGeneral = new List<PasswordChunkType>();
            _typeValuesAfterDirect = new List<PasswordChunkType>();
            _typeValuesAfterDirectDip = new List<PasswordChunkType>();

            foreach (KeyValuePair<PasswordChunkType, int> item in _chunkTypeProbability)
            {
                bool appendAfterDirect = (item.Key != PasswordChunkType.InvertedDiphtongue);
                bool appendAfterDirectDip = (item.Key != PasswordChunkType.Inverted ||
                                          item.Key != PasswordChunkType.InvertedDiphtongue);

                for (int count = 0; count < item.Value; ++count)
                {
                    _typeValuesGeneral.Add(item.Key);
                    if (appendAfterDirect)
                        _typeValuesAfterDirect.Add(item.Key);
                    if (appendAfterDirectDip)
                        _typeValuesAfterDirectDip.Add(item.Key);
                }
            }
        }

        #endregion Initialization

        // .................................................................................................

        public string Generate(int pLength, PasswordGeneratorOptionsEx pOptions)
        {

            if (pLength < PasswordMinLength)
                pLength = PasswordMinLength;

            Password password = new Password();
            while (password.PasswordLength < pLength)
            {
                PasswordChunk chunk = GenerateNextChunk(password);
                password.AppendChunk(chunk);
            }

            bool capitalsRandom = false;
            if (pOptions.Options.HasFlag(PasswordGeneratorOptions.Capitals))
            {
                if (pOptions.Options.HasFlag(PasswordGeneratorOptions.CapitalsFirstInChunks) ||
                    pOptions.Options.HasFlag(PasswordGeneratorOptions.CapitalsLastInChunks))
                    CapitalizeChunks(password, pOptions.Options);
                else
                    capitalsRandom = true;
            }

            if (pOptions.Options.HasFlag(PasswordGeneratorOptions.Specials))
                InsertSpecialChunk(password, pOptions.SpecialGroupSymbols, !pOptions.Options.HasFlag(PasswordGeneratorOptions.SpecialsNotBlank), pOptions.SpecialGroupsMin, pOptions.SpecialGroupsMax);

            if (capitalsRandom)
                CapitalizeRandomPassword(password, pOptions.CapitalsMinimum, pOptions.CapitalsMaximum);

            if (pOptions.Options.HasFlag(PasswordGeneratorOptions.Separators))
                InsertSeparators(password, pOptions.Options.HasFlag(PasswordGeneratorOptions.SeparatorRotation), pOptions.FixedSeparatorChar);

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


            List<PasswordChunkType> list;
            switch (pPassword.LastChunkType)
            {
                case PasswordChunkType.Direct: list = _typeValuesAfterDirect; break;
                case PasswordChunkType.DirectDiphtongue: list = _typeValuesAfterDirectDip; break;
                default: list = _typeValuesGeneral; break;
            }

            return list[_random.Next(list.Count)];
        }

        // ----------------------------------------------------------------------------------------------------------------------------

        private void CapitalizeChunks(Password pPassword, PasswordGeneratorOptions pOptions)
        {
            bool capitalFirst = pOptions.HasFlag(PasswordGeneratorOptions.CapitalsFirstInChunks);

            for (int index = 0; index < pPassword.ChunkCount; ++index)
            {
                string text = pPassword.Chunks[index].Text;
                text = (capitalFirst)
                    ? text.Substring(0, 1).ToUpper() + text.Substring(1)
                    : text.Substring(0, text.Length - 1) + text.Substring(text.Length - 1, 1).ToUpper();
                pPassword.Chunks[index].Text = text;
            }
        }



        private void InsertSpecialChunk(Password pPassword, string pSpecialSymbols, bool pAcceptBlanks, int pMinimum, int pMaximum)
        {
            if (pSpecialSymbols.Contains(" ") && !pAcceptBlanks)
            {
                pSpecialSymbols = pSpecialSymbols.Replace(" ", "");
            }

            pMaximum = (pMaximum <= (pPassword.ChunkCount / 2)) ? pMaximum : (pPassword.ChunkCount / 2);

            _chunkGenerators[PasswordChunkType.Special].SetCharacterSet(pSpecialSymbols);

            int index = _random.Next(pPassword.ChunkCount);

            PasswordChunk specialChunk = _chunkGenerators[PasswordChunkType.Special].Get(pPassword.Chunks[index]);

            pPassword.ReplaceChunk(specialChunk, index);

            if (pMaximum == 1)
                return;

            List<int> validChunks = new List<int>();
            for (int count = 0; count < pPassword.ChunkCount; ++count)
                validChunks.Add(count);

            SpecialChunkRemoveValid(validChunks, index);
            for (int count = 1; count < pMaximum; ++count)
            {
                if (validChunks.Count == 0)
                    break;
                if (_random.Next(100) < 20)
                {
                    int validIndex = _random.Next(validChunks.Count);
                    index = validChunks[validIndex];
                    specialChunk = _chunkGenerators[PasswordChunkType.Special].Get(pPassword.Chunks[index]);
                    pPassword.ReplaceChunk(specialChunk, index);
                    SpecialChunkRemoveValid(validChunks, index);
                }
            }
        }

        private void SpecialChunkRemoveValid(List<int> validChunks, int pIndex)
        {
            if (validChunks.Contains(pIndex))
                validChunks.Remove(pIndex);
            if (validChunks.Contains(pIndex - 1))
                validChunks.Remove(pIndex - 1);
            if (validChunks.Contains(pIndex + 1))
                validChunks.Remove(pIndex + 1);

        }


        // ----------------------------------------------------------------------------------------------------------------------------

        private void CapitalizeRandomPassword(Password pPassword, int pMinimum, int pMaximum)
        {
            int capitalized = 0;

            do
            {
                int probability = 50;
                for (int index = 0; index < pPassword.ChunkCount; ++index)
                {
                    PasswordChunk chunk = pPassword.Chunks[index];
                    if (chunk.ChunkType == PasswordChunkType.Special)
                        continue;

                    if (_random.Next(100) < probability)
                    {
                        bool lastLetter;
                        if (chunk.CapitalizedFirst && chunk.CapitalizedLast)
                            continue;
                        if (chunk.CapitalizedFirst)
                            lastLetter = true;
                        else
                            lastLetter = !chunk.CapitalizedLast && Utils.Coin();

                        if (pPassword.CapitalizeChunk(index, lastLetter))
                        {
                            capitalized++;
                            probability -= 20;
                            if (probability <= 0)
                                break;
                            if (capitalized > pMaximum)
                                return;
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
}