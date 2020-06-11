using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public interface IStream
    {
        string Name { get; }

        ICommitCollection Commits { get; }
    }
}
