﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Helpers.Abstract
{
    public interface IHttpClientHelper<T>
    {
        Task<T> GetSingleItemRequest(string apiUrl, CancellationToken token = default(CancellationToken));
        Task<T[]> GetMultipleItemsRequest(string apiUrl, CancellationToken token = default(CancellationToken));
        Task<T> PostRequest(string apiUrl, T postObject, CancellationToken token = default(CancellationToken));
        Task PutRequest(string apiUrl, T putObject, CancellationToken token = default(CancellationToken));
        Task DeleteRequest(string apiUrl, CancellationToken token = default(CancellationToken));

    }
}
