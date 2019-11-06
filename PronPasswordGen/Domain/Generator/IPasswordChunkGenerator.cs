using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PronPasswordGen.Domain.Generator
{
    public interface IPasswordChunkGenerator
    {

        void SetCharacterSet(string pCharacterSet);

        PasswordChunk Get(PasswordChunk pReferenceChunk);

    }
}
