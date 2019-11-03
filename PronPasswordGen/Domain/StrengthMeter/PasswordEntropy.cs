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

            int cardinality = 0;
            if (pPassword.IndexOfAny(letters.ToCharArray()) >= 0)
                cardinality += letters.Length;

            if (pPassword.IndexOfAny(letters.ToUpper().ToCharArray()) >= 0)
                cardinality += letters.Length;

            if (pPassword.IndexOfAny(PasswordChunkGeneratorBase.Numbers.ToCharArray()) >= 0)
                cardinality += PasswordChunkGeneratorBase.Numbers.Length;

            if (pPassword.IndexOfAny(PasswordChunkGeneratorBase.SpecialsDefault.ToCharArray()) >= 0)
                cardinality += PasswordChunkGeneratorBase.SpecialsDefault.Length;

            // double combinations = Math.Pow(cardinality, pPassword.Length);
            pCardinality = cardinality;

            return pPassword.Length * Math.Log(cardinality, 2.0);
        }
    }
}
