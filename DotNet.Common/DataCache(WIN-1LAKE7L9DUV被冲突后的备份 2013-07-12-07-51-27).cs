using System;
using System.Web;

namespace LTP.Common
{
	/// <summary>
	/// 缓存相关的操作类
	/// </summary>
	public class DataCache
	{
//绝对过期分钟数
const int _iCacheMinutesAbsolute=20;
//滑动过期分钟数
const int _iCacheMinutesSliding=10;
//滑动失效时间值
static TimeSpan tsExpiration;
static TimeSpan TsExpiration{get{if(tsExpiration==null)
tsExpiration=TimeSpan.FromMinutes(_iCacheMinutesSliding);
return tsExpiration;

		/// <summary>
		/// 获取当前应用程序指定CacheKey的Cache值
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <returns></returns>
		public static object GetCache(string CacheKey)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			return objCache[CacheKey];
		}

}}

		/// <summary>
		/// 设置当前应用程序指定CacheKey的Cache值,绝对时间后失效
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetAbsoluteCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,DateTime.Now.AddMinutes(_iCacheMinutesAbsolute),System.Web.Caching.Cache.NoSlidingExpiration);

		}
		/// <summary>
		/// 设置当前应用程序指定CacheKey的Cache值,滑动时间后失效
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetSlidingCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,System.Web.Caching.Cache.NoAbsoluteExpiration, TsExpiration);
		}

		/// <summary>
		/// 设置当前应用程序指定CacheKey的Cache值，双失效时间
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetExpirationCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,DateTime.Now.AddMinutes(_iCacheMinutesAbsolute),TsExpiration);
		}


		/// <summary>
		/// 设置当前应用程序指定CacheKey的Cache值，系统失效时间
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject);
		}

		/// <summary>
		/// 设置当前应用程序指定CacheKey的Cache值,自定义失效时间 
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetCustomCache(string CacheKey, object objObject, DateTime absoluteExpiration=DateTime.MaxValue,TimeSpan slidingExpiration=TimeSpan.Zero )
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,absoluteExpiration,slidingExpiration);
		}

	}
}
