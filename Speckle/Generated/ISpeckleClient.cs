﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BerryClient
{
    public interface ISpeckleClient
    {
        Task<IOperationResult<IGetServerInfo>> GetServerInfoAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetServerInfo>> GetServerInfoAsync(
            GetServerInfoOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetMyProfile>> GetMyProfileAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetMyProfile>> GetMyProfileAsync(
            GetMyProfileOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetStream>> GetStreamAsync(
            Optional<string> id = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetStream>> GetStreamAsync(
            GetStreamOperation operation,
            CancellationToken cancellationToken = default);
    }
}
