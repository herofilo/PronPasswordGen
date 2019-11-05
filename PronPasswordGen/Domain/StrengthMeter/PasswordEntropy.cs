using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PronPasswordGen.Domain.Generator;

namespace PronPasswordGen.Domain.StrengthMeter
{
    public static class PasswordEntropy
    {
        public static double Compute(string pPassword, out int pCardinality)
        {
            pCardinality = 0;
            if (String.IsNullOrEmpty(pPassword))
                return 0.0;

            string letters = $"{PasswordChunkGeneratorBase.Consonants}{PasswordChunkGeneratorBase.Vowels}";
            StringBuilder charSet = new StringBuilder();

            int cardinality = 0;
            if (pPassword.IndexOfAny(letters.ToCharArray()) >= 0)
            {
                cardinality += letters.Length;
                charSet.Append(letters);
            }

            if (pPassword.IndexOfAny(letters.ToUpper().ToCharArray()) >= 0)
            {
                cardinality += letters.Length;
                charSet.Append(letters.ToUpper());
            }

            if (pPassword.IndexOfAny(PasswordChunkGeneratorBase.Numbers.ToCharArray()) >= 0)
            {
                cardinality += PasswordChunkGeneratorBase.Numbers.Length;
                charSet.Append(PasswordChunkGeneratorBase.Numbers);
            }

            if (pPassword.IndexOfAny(PasswordChunkGeneratorBase.SpecialsDefault.ToCharArray()) >= 0)
            {
                cardinality += PasswordChunkGeneratorBase.SpecialsDefault.Length;
                charSet.Append(PasswordChunkGeneratorBase.SpecialsDefault.Length);
            }

            List<char> alienChars = new List<char>();
            string charSetString = charSet.ToString();
            foreach(char c in pPassword)
                if (!charSetString.Contains(c) && !alienChars.Contains(c))
                {
                    alienChars.Add(c);
                }
            
            pCardinality = cardinality + alienChars.Count;

            return pPassword.Length * Math.Log(cardinality, 2.0);
        }
    }
}
