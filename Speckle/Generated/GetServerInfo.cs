using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class GetServerInfo
        : IGetServerInfo
    {
        public GetServerInfo(
            IServerInfo serverInfo)
        {
            ServerInfo = serverInfo;
        }

        public IServerInfo ServerInfo { get; }
    }
}
