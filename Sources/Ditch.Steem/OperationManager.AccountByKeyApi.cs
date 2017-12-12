﻿using System.Threading;
using Ditch.Core.JsonRpc;

namespace Ditch.Steem
{
    /// <summary>
    /// account_by_key_api
    /// \libraries\plugins\account_by_key\include\steemit\account_by_key\account_by_key_api.hpp
    /// </summary>\ 
    public partial class OperationManager
    {
        ///// <summary>
        ///// API name: on_api_startup
        ///// 
        ///// </summary>
        ///// <param name="token">Throws a <see cref="T:System.OperationCanceledException" /> if this token has had cancellation requested.</param>
        ///// <returns>API type: void</returns>
        ///// <exception cref="T:System.OperationCanceledException">The token has had cancellation requested.</exception>
        //public JsonRpcResponse OnApiStartup(CancellationToken token)
        //{
        //    return CustomGetRequest("on_api_startup", token);
        //}

        /// <summary>
        /// API name: get_key_references
        /// 
        /// </summary>
        /// <param name="keys">API type: vector&lt;public_key_type></param>
        /// <param name="token">Throws a <see cref="T:System.OperationCanceledException" /> if this token has had cancellation requested.</param>
        /// <returns>API type: account_name_type</returns>
        /// <exception cref="T:System.OperationCanceledException">The token has had cancellation requested.</exception>
        public JsonRpcResponse<string[][]> GetKeyReferences(string[] keys, CancellationToken token)
        {
            return CustomGetRequest<string[][]>("call", token, KnownApiNames.AccountByKeyApi, "get_key_references", new object[] { keys });
        }
    }
}
