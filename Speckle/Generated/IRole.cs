using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public interface IRole
    {
        string Name { get; }

        string Description { get; }
    }
}
