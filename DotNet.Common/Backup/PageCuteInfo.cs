using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LTP.Common
{
    public class PageCuteInfo
    {
        #region 属性
        private int pagesize = 10;
        private int pageindex = 1;
        private int alldatacount=0;
        private int allpagecount=1;
        private string strwhere;
        private object bll;
        private bool isfirst;
        private bool islast;

        /// <summary>
        /// 分页大小
        /// </summary>
        public int pageSize
        {
            get { return pagesize; }
            set { pagesize = value; }
        }

        /// <summary>
        /// 当前页索引
        /// </summary>
        public int pageIndex
        {
            get { return pageindex; }
            set { pageindex = value; }
        }

        /// <summary>
        /// 数据总条数
        /// </summary>
        public int allDataCount
        {
            get { return alldatacount; }
            set { alldatacount = value; }
        }

        /// <summary>
        /// 分页总数 
        /// </summary>
        public int allPageCount
        {
            get { return allpagecount; }
            set { allpagecount = value; }
        }
        /// <summary>
        /// 业务层对象
        /// </summary>
        public object Bll_obj
        {
            get { return bll; }
            set { bll = value; }
        }
        /// <summary>
        /// 查询条件
        /// </summary>
        public string strWhere
        {
            get { return strwhere; }
            set { strwhere = value; }
        }
        /// <summary>
        /// 是否是第一页
        /// </summary>
        public bool isFirst
        {
            get { return isfirst; }
            set { isfirst = value; }
        }
        /// <summary>
        /// 是否是最后一页
        /// </summary>
        public bool isLast
        {
            get { return islast; }
            set { islast = value; }
        }


        #endregion

        //构造函数
        public PageCuteInfo()
        {

        }
        //构造函数
        public PageCuteInfo(int size,int index)
        {
            this.pageindex = index;
            this.pagesize = size;
        }

        public DataTable getDataByPageCute()
        {
            getCount();
            DataTable dt = null;
            if (Bll_obj!=null)
            {
                System.Reflection.MethodInfo mi = Bll_obj.GetType().GetMethod("GetListCute");
                object[] p_obj = new object[3];
                p_obj[0] = pageSize;
                p_obj[1] = pageIndex;
                p_obj[2] = strWhere;//******************
                DataSet ds = (DataSet)mi.Invoke(Bll_obj, p_obj);
                dt = ds.Tables[0];
            }

            if (pageindex==1)
            {
                return dt;
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    pageindex = pageindex - 1;
                    return getDataByPageCute();
                }
            } 
        }

        /// <summary>
        /// 获取总数据数和总页数
        /// </summary>
        public void getCount()
        {
            if (Bll_obj!=null)
            {
                System.Reflection.MethodInfo mi2 = Bll_obj.GetType().GetMethod("getAllDataCount");
                object[] p_obj2 = new object[1];
                p_obj2[0] = strWhere;

                this.allDataCount = (int)mi2.Invoke(Bll_obj, p_obj2); //获取总条数 
                this.allPageCount = allDataCount / pageSize;
                if (allDataCount % pageSize>0)
                {
                    allPageCount++;
                }

                if (pageIndex==1)
                {
                    isfirst = true;
                }
                else
                {
                    isfirst = false;
                }
                if (pageIndex==allpagecount)
                {
                    islast = true;
                }
                else
                {
                    islast = false;
                }
            }
        }

    }
}
