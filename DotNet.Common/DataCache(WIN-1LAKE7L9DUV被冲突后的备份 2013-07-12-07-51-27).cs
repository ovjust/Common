using System;
using System.Web;

namespace LTP.Common
{
	/// <summary>
	/// ������صĲ�����
	/// </summary>
	public class DataCache
	{
//���Թ��ڷ�����
const int _iCacheMinutesAbsolute=20;
//�������ڷ�����
const int _iCacheMinutesSliding=10;
//����ʧЧʱ��ֵ
static TimeSpan tsExpiration;
static TimeSpan TsExpiration{get{if(tsExpiration==null)
tsExpiration=TimeSpan.FromMinutes(_iCacheMinutesSliding);
return tsExpiration;

		/// <summary>
		/// ��ȡ��ǰӦ�ó���ָ��CacheKey��Cacheֵ
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
		/// ���õ�ǰӦ�ó���ָ��CacheKey��Cacheֵ,����ʱ���ʧЧ
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetAbsoluteCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,DateTime.Now.AddMinutes(_iCacheMinutesAbsolute),System.Web.Caching.Cache.NoSlidingExpiration);

		}
		/// <summary>
		/// ���õ�ǰӦ�ó���ָ��CacheKey��Cacheֵ,����ʱ���ʧЧ
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetSlidingCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,System.Web.Caching.Cache.NoAbsoluteExpiration, TsExpiration);
		}

		/// <summary>
		/// ���õ�ǰӦ�ó���ָ��CacheKey��Cacheֵ��˫ʧЧʱ��
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetExpirationCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,DateTime.Now.AddMinutes(_iCacheMinutesAbsolute),TsExpiration);
		}


		/// <summary>
		/// ���õ�ǰӦ�ó���ָ��CacheKey��Cacheֵ��ϵͳʧЧʱ��
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject);
		}

		/// <summary>
		/// ���õ�ǰӦ�ó���ָ��CacheKey��Cacheֵ,�Զ���ʧЧʱ�� 
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
