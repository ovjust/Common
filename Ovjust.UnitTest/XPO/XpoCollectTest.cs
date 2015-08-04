using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovjust.DbXpoProvider;
using DevExpress.Xpo;
using System.Linq;

namespace Ovjust.UnitTest.XPO
{
    [TestClass]
    public class XpoCollectTest
    {
        /// <summary>
        /// XPCollection.Reload 虽然查数据库，但不更新数据集
        /// </summary>
        [TestMethod]
        public void TestColl()
        {
            XpoHelper.Init();
            //var m1 = new XpoModel() { Name = "ee" };
            //XpoHelper.Sess.Save(m1);

            //Reload 没有更新集合
            var coll = new XPCollection<XpoModel>(XpoHelper.Sess, null, null, null);
            //coll.LoadingEnabled = false;
            coll.Load();
            //var m1 = new XpoModel() { Name = "e1" };
            //XpoHelper.Sess.Save(m1);
            XpoHelper.Sess.DropIdentityMap();
            coll.Reload();

            //XPCollection.Reload() 会查询数据库并添加新项，但已有项不更新。只有sess.DropIdentityMap()再load或Reload才能更新原有项
            
            var coll2 = new XPCollection<XpoModel>(XpoHelper.Sess, null, null, null);
            coll2.Load();
            //var m2 = new XpoModel() { Name = "e2" };
            //XpoHelper.Sess.Save(m2);[YGSMSBig].[dbo].[Fct_SendMsg]表 我们已经清空了，麻烦你开一下短信服务，我们再实际测几条 看下去重的结果
            XpoHelper.Sess.DropIdentityMap();
            coll2.Reload();
            //XpoHelper.Sess.Reload(coll2);
            //XpoHelper.Sess.Reload(coll2,true);
        }


        [TestMethod]
        public void TestLinq()
        {
            XpoHelper.Init();
            //var m1 = new XpoModel() { Name = "ee" };
            //XpoHelper.Sess.Save(m1);
            var query = new XPQuery<XpoModel>(XpoHelper.Sess);
            var m1= query.Single(p => p.Oid == 1);
         var m2=   XpoHelper.Sess.GetObjectByKey<XpoModel>(1);
         var m3 = XpoHelper.Sess.GetObjectByKey<XpoModel>(1,true);
            m1.Reload();
            m1.Reload();


            //XpoHelper.Sess.Reload(coll2);
            //XpoHelper.Sess.Reload(coll2,true);
        }
    }
}
