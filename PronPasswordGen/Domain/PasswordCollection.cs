﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PronPasswordGen.Domain.StrengthMeter;

namespace PronPasswordGen.Domain
{
    public sealed class PasswordCollection
    {
        public List<PasswordCollectionItem> Passwords { get; set; }


        // -----------------------------------------------

        public void Append(Password pPassword)
        {
            if(Passwords == null)
                Passwords = new List<PasswordCollectionItem>();

            Passwords.Add(new PasswordCollectionItem(pPassword));

            Passwords = Passwords.OrderBy(o => -1 * o.CombinedStrength).ToList();

            for (int index = 0; index < Passwords.Count; ++index)
                Passwords[index].Rank = index + 1;
        }
    }



    public sealed class PasswordCollectionItem
    {

        private static PasswordStrength _passwordStrengthMeter;

        public string Password { get; private set; }

        public int Length { get; private set; }

        public string Strength { get; private set; }

        public int StrengthValue { get; private set; }

        public int Cardinality { get; private set; }

        public double Entropy { get; private set; }

        public long CombinedStrength { get; private set; }

        public int Rank { get; set; }

        public string SepText { get; private set; }



        public PasswordCollectionItem(Password pPassword)
        {
            Password = pPassword.Text;
            if(_passwordStrengthMeter == null)
                _passwordStrengthMeter = new PasswordStrength();

            Length = Password.Length;

            _passwordStrengthMeter.SetPassword(Password);
            StrengthValue = _passwordStrengthMeter.GetPasswordScore();
            Strength = _passwordStrengthMeter.GetPasswordStrength();

            int cardinality;
            Entropy = PasswordEntropy.Compute(Password, out cardinality);

            CombinedStrength = (long) (100.0 * Entropy + StrengthValue);

            Cardinality = cardinality;

            SepText = pPassword.TextDelimited.Replace("\t", " ");

        }

        
    }


}
