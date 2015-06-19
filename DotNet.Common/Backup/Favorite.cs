using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Web.SessionState;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using System.Data;

namespace LTP.Common
{

    public static class Favorite
    {
       
        /// <summary>
        /// 收藏文章
        /// </summary>
        /// <param name="Session"></param>
        /// <param name="news"></param>
        /// <returns></returns>
        //public static bool FavoriteArticle(HttpSessionState Session, ChuangDa.Model.news news)
        //{

        //    if (Session["CurrentUser"] == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        ChuangDa.Model.userinfo userinfo = Session["CurrentUser"] as ChuangDa.Model.userinfo;

        //        if (userinfo.seq == 0)
        //        {
        //            return false;

        //        }
        //        else
        //        {
        //            if (Exists(userinfo.seq,news.seq,0))//如果已经收藏
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                ChuangDa.Model.Favorite favorite = new ChuangDa.Model.Favorite();
        //                favorite.user_seq = userinfo.seq;
        //                favorite.favorite_type = "0";
        //                favorite.favorite_seq = news.seq;
        //                favorite.favorite_info = "";

        //                if (Add(favorite))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 收藏项目
        ///// </summary>
        ///// <param name="Session"></param>
        ///// <param name="project"></param>
        ///// <returns></returns>
        //public static bool FavoriteArticle(HttpSessionState Session, ChuangDa.Model.project project)
        //{
        //    if (Session["CurrentUser"] == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        ChuangDa.Model.userinfo userinfo = Session["CurrentUser"] as ChuangDa.Model.userinfo;

        //        if (userinfo.seq == 0)
        //        {
        //            return false;

        //        }
        //        else
        //        {
        //            if (Exists(userinfo.seq, project.seq, 0))//如果已经收藏
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                ChuangDa.Model.Favorite favorite = new ChuangDa.Model.Favorite();
        //                favorite.user_seq = userinfo.seq;
        //                favorite.favorite_type = "1";
        //                favorite.favorite_seq = project.seq;
        //                favorite.favorite_info = "";

        //                if (Add(favorite))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //}


        ///// <summary>
        ///// 收藏专利
        ///// </summary>
        ///// <param name="Session"></param>
        ///// <param name="project"></param>
        ///// <returns></returns>
        //public static bool FavoriteArticle(HttpSessionState Session, ChuangDa.Model.patent model)
        //{
        //    if (Session["CurrentUser"] == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        ChuangDa.Model.userinfo userinfo = Session["CurrentUser"] as ChuangDa.Model.userinfo;

        //        if (userinfo.seq == 0)
        //        {
        //            return false;

        //        }
        //        else
        //        {
        //            if (Exists(userinfo.seq, model.seq, 3))//如果已经收藏
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                ChuangDa.Model.Favorite favorite = new ChuangDa.Model.Favorite();
        //                favorite.user_seq = userinfo.seq;
        //                favorite.favorite_type = "3";
        //                favorite.favorite_seq = model.seq;
        //                favorite.favorite_info = "";

        //                if (Add(favorite))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 收藏投资信息需求

        ///// </summary>
        ///// <param name="Session"></param>
        ///// <param name="project"></param>
        ///// <returns></returns>
        //public static bool FavoriteArticle(HttpSessionState Session, ChuangDa.Model.needs model)
        //{
        //    if (Session["CurrentUser"] == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        ChuangDa.Model.userinfo userinfo = Session["CurrentUser"] as ChuangDa.Model.userinfo;

        //        if (userinfo.seq == 0)
        //        {
        //            return false;

        //        }
        //        else
        //        {
        //            if (Exists(userinfo.seq, model.seq, 2))//如果已经收藏
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                ChuangDa.Model.Favorite favorite = new ChuangDa.Model.Favorite();
        //                favorite.user_seq = userinfo.seq;
        //                favorite.favorite_type = "2";
        //                favorite.favorite_seq = model.seq;
        //                favorite.favorite_info = "";

        //                if (Add(favorite))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //}


        ///// <summary>
        ///// 收藏企业融资需求

        ///// </summary>
        ///// <param name="Session"></param>
        ///// <param name="project"></param>
        ///// <returns></returns>
        //public static bool FavoriteArticle(HttpSessionState Session, ChuangDa.Model.financing model)
        //{
        //    if (Session["CurrentUser"] == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        ChuangDa.Model.userinfo userinfo = Session["CurrentUser"] as ChuangDa.Model.userinfo;

        //        if (userinfo.seq == 0)
        //        {
        //            return false;

        //        }
        //        else
        //        {
        //            if (Exists(userinfo.seq, model.seq, 4))//如果已经收藏
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                ChuangDa.Model.Favorite favorite = new ChuangDa.Model.Favorite();
        //                favorite.user_seq = userinfo.seq;
        //                favorite.favorite_type = "4";
        //                favorite.favorite_seq = model.seq;
        //                favorite.favorite_info = "";

        //                if (Add(favorite))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 判断是否已经收藏过

        /// </summary>
        /// <param name="userSeq">用户seq</param>
        /// <param name="favorite_seq">收藏资料的seq</param>
        /// <param name="articleType">收藏资料的类型 0为文档，1为项目</param>
        /// <returns>返回false（没有收藏过），返回ture（已收藏过）</returns>
        public static bool Exists(decimal userSeq, decimal favorite_seq, decimal articleType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from favorite");
            strSql.Append(" where user_seq=@userSeq ");
            strSql.Append(" and favorite_type=@favorite_type");
            strSql.Append(" and favorite_seq=@favorite_seq");
            SqlParameter[] parameters = {
					new SqlParameter("@userSeq", SqlDbType.Decimal),
                    new SqlParameter("@favorite_type", SqlDbType.Char,1),
                    new SqlParameter("@favorite_seq", SqlDbType.Decimal)
                                        };
            parameters[0].Value = userSeq;
            parameters[1].Value = articleType;
            parameters[2].Value = favorite_seq;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        ///// <summary>
        ///// 增加一条数据

        ///// </summary>
        //public static bool Add(ChuangDa.Model.Favorite model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("insert into favorite(");
        //    strSql.Append("user_seq,favorite_type,favorite_seq,favorite_info)");
        //    strSql.Append(" values (");
        //    strSql.Append("@user_seq,@favorite_type,@favorite_seq,@favorite_info)");
        //    strSql.Append(";select @@IDENTITY");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@user_seq", SqlDbType.Decimal,9),
        //            new SqlParameter("@favorite_type", SqlDbType.Char,1),
        //            new SqlParameter("@favorite_seq", SqlDbType.Decimal,9),
        //            new SqlParameter("@favorite_info", SqlDbType.NVarChar,200)};
        //    parameters[0].Value = model.user_seq;
        //    parameters[1].Value = model.favorite_type;
        //    parameters[2].Value = model.favorite_seq;
        //    parameters[3].Value = model.favorite_info;

        //    object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
