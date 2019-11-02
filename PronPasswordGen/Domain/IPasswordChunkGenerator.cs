using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PronPasswordGen.Domain
{
    public interface IPasswordChunkGenerator
    {

        PasswordChunk Get(PasswordChunk pReferenceChunk);

    }
}
