using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class GetMyProfile
        : IGetMyProfile
    {
        public GetMyProfile(
            IUser user)
        {
            User = user;
        }

        public IUser User { get; }
    }
}
