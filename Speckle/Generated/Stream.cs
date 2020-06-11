using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class Stream
        : IStream
    {
        public Stream(
            string name, 
            ICommitCollection commits)
        {
            Name = name;
            Commits = commits;
        }

        public string Name { get; }

        public ICommitCollection Commits { get; }
    }
}
