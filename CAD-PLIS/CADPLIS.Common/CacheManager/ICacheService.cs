using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.CacheManager
{
    public interface ICacheService : IDisposable
    {
        /// <summary>
        /// Verify that the cache entry exists
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        bool Exists(string key);
        /// <summary>
        /// The List in the head
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val"></param>
        void LPush(string key, string val);

        void RPush(string key, string val);
        /// <summary>
        ///List out the lpop
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object ListDequeue(string key);

        /// <summary>
        /// List out the lpop
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T ListDequeue<T>(string key) where T : class;

        /// <summary>
        /// To remove data from a list, keepIndex is reserved to the last element such as list element 1.2.3..... 100
        /// We need to remove the first three, so keepindex should be 4
        /// </summary>
        /// <param name="key"></param>
        /// <param name="keepIndex"></param>
        void ListRemove(string key, int keepIndex);

        /// <summary>
        /// Add the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <param name="value">The cache Value</param>
        /// <param name="expiresIn">The cache time</param>
        /// <param name="isSliding">Whether to slide expiration (if there is an operation within the expiration time, extend the expiration time at the current point in time) //new TimeSpan(0, 60, 0);</param>
        /// <returns></returns>
        bool AddObject(string key, object value, int expireSeconds = -1, bool isSliding = false);

        bool Add(string key, string value, int expireSeconds = -1, bool isSliding = false);

        /// <summary>
        /// Delete the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        bool Remove(string key);


        /// <summary>
        /// Batch Deleting Caches
        /// </summary>
        /// <param name="key">Cache Key set</param>
        /// <returns></returns>
        void RemoveAll(IEnumerable<string> keys);




        /// <summary>
        /// Access to the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        T Get<T>(string key) where T : class;



        /// <summary>
        /// Access to the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        string Get(string key);
    }
}
