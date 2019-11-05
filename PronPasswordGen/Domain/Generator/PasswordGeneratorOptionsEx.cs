namespace PronPasswordGen.Domain.Generator
{
    public sealed class PasswordGeneratorOptionsEx
    {
        public PasswordGeneratorOptions Options { get; set; } = PasswordGeneratorOptions.None;

        public int CapitalsMinimum { get; set; } = PasswordGenerator.CapitalsMinimumDefault;

        public int SpecialGroupsMax { get; set; } = PasswordGenerator.SpecialGroupsMaxDefault;

        public string SpecialGroupSymbols { get; set; } = PasswordChunkGeneratorBase.SpecialsDefault;

        public char FixedSeparatorChar { get; set; } = PasswordGenerator.FixedSeparatorDefault;

        public string RotatingSeparators { get; set; } = PasswordGenerator.SeparatorsDefault;
    }
}