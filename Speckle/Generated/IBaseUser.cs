using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public interface IBaseUser
    {
        string Id { get; }

        string Name { get; }

        string Email { get; }
    }
}
