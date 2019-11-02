using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PronPasswordGen.Domain
{
    public class PasswordChunkGeneratorBase 
    {

        public const string Consonants = "bcdfghjklmnpqrstvwxyz";

        protected readonly int ConsonantsLength = Consonants.Length;

        public const string Vowels = "aeiou";

        protected readonly int VowelsLength = Vowels.Length;

        public const string LiquidCompanions = "bcdfgkptvw";

        public const string LiquidCompanionsRestricted = "dtw";

        protected readonly int LiquidCompanionsLength = LiquidCompanions.Length;

        public const string Numbers = "0123456789";

        protected readonly int NumbersLenght = Numbers.Length;


        private const string SpecialsDefault = "!+.,:;-_@$|#?><";

        public static string Specials
        {
            get { return _specials; }
            set
            {
                if (value == null)
                {
                    _specials = SpecialsDefault;
                    return;
                }

                string newSpecials = "";
                foreach (char c in value)
                {
                    if(Char.IsLetterOrDigit(c) || Char.IsControl(c))
                        continue;
                    newSpecials += c;
                }

                if (string.IsNullOrEmpty(newSpecials))
                    newSpecials = SpecialsDefault;

                _specials = newSpecials;
            }
        }

        private static string _specials = SpecialsDefault;


        protected Random Random = new Random();

        // --------------------------------------------------------------------------------

        protected string GetDiphtongue()
        {
            char vowel0 = Vowels[Random.Next(VowelsLength)];
            char vowel1;
            do
            {
                vowel1 = Vowels[Random.Next(VowelsLength)];
            } while (vowel0 == vowel1);

            return $"{vowel0}{vowel1}";
        }



    }
}
