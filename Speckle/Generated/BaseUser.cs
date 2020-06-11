using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class BaseUser
        : IBaseUser
    {
        public BaseUser(
            string id, 
            string name, 
            string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public string Id { get; }

        public string Name { get; }

        public string Email { get; }
    }
}
