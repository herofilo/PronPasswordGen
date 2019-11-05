using System;

namespace PronPasswordGen.Domain.Generator
{
    [Flags]
    public enum PasswordGeneratorOptions
    {
        None = 0,
        Capitals = 0x1000,
        Specials = 0x2000,
        SpecialsNotBlank = 0x0001,
        Separators = 0x4000,
        SeparatorRotation = 0x0002
    }
}
