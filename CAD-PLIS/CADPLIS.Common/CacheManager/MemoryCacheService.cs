﻿using CADPLIS.Common.CacheManager;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.CacheManager
{
    public class MemoryCacheService : ICacheService
    {
        protected IMemoryCache _cache;
        public MemoryCacheService(IMemoryCache cache)
        {
            _cache = cache;
        }
        /// <summary>
        /// Verify that the cache entry exists
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        public bool Exists(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            return _cache.Get(key) != null;
        }

        /// <summary>
        /// Add the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <param name="value">The cache Value</param>
        /// <returns></returns>
        public bool Add(string key, object value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            _cache.Set(key, value);
            return Exists(key);
        }

        public bool AddObject(string key, object value, int expireSeconds = -1, bool isSliding = false)
        {
            if (expireSeconds != -1)
            {
                _cache.Set(key,
                    value,
                    new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(new TimeSpan(0, 0, expireSeconds))
                    );
            }
            else
            {
                _cache.Set(key, value);
            }

            return true;
        }
        public bool Add(string key, string value, int expireSeconds = -1, bool isSliding = false)
        {
            return AddObject(key, value, expireSeconds, isSliding);
        }
        public void LPush(string key, string val)
        {
        }
        public void RPush(string key, string val)
        {
        }
        public T ListDequeue<T>(string key) where T : class
        {
            return null;
        }
        public object ListDequeue(string key)
        {
            return null;
        }
        public void ListRemove(string key, int keepIndex)
        {
        }
        /// <summary>
        /// Add the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <param name="value">The cache Value</param>
        /// <param name="expiresSliding">Sliding expiration time (if there is an operation within the expiration time, extend the expiration time at the current point in time)</param>
        /// <param name="expiressAbsoulte">Absolute expiration period</param>
        /// <returns></returns>
        public bool Add(string key, object value, TimeSpan expiresSliding, TimeSpan expiressAbsoulte)
        {
            _cache.Set(key, value,
                    new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(expiresSliding)
                    .SetAbsoluteExpiration(expiressAbsoulte)
                    );

            return Exists(key);
        }
        /// <summary>
        /// Add the cache 
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <param name="value">The cache Value</param>
        /// <param name="expiresIn">The cache time</param>
        /// <param name="isSliding">Whether to slide expiration (if there is an operation within the expiration time, extend the expiration time at the current point in time)</param>
        /// <returns></returns>
        public bool Add(string key, object value, TimeSpan expiresIn, bool isSliding = false)
        {
            if (isSliding)
                _cache.Set(key, value,
                    new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(expiresIn)
                    );
            else
                _cache.Set(key, value,
                new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(expiresIn)
                );

            return Exists(key);
        }



        /// <summary>
        /// Delete the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            _cache.Remove(key);

            return !Exists(key);
        }
        /// <summary>
        /// Batch Deleting Caches
        /// </summary>
        /// <param name="key">Cache Key set</param>
        /// <returns></returns>
        public void RemoveAll(IEnumerable<string> keys)
        {
            if (keys == null)
            {
                throw new ArgumentNullException(nameof(keys));
            }

            keys.ToList().ForEach(item => _cache.Remove(item));
        }
        public string Get(string key)
        {
            return _cache.Get(key)?.ToString();
        }
        /// <summary>
        /// Access to the cache
        /// </summary>
        /// <param name="key">The cache Key</param>
        /// <returns></returns>
        public T Get<T>(string key) where T : class
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            return _cache.Get(key) as T;
        }

        public void Dispose()
        {
            if (_cache != null)
                _cache.Dispose();
            GC.SuppressFinalize(this);
        }


    }
}
