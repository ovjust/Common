using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Ovjust.DbXpoProvider
{
    public class ConnectionString
    {

        bool? isOpenShift;
        public bool IsOpenShift
        {
            get
            {
                if (isOpenShift == null)
                    isOpenShift = ConfigurationManager.AppSettings["isOpenShift"] == "true";
                return isOpenShift.Value;
            }
        }
        string dbServer;
        public string DbServer
        {
            get
            {
                if (dbServer == null)
                {
                    if (IsOpenShift)
                    {
                        if (DbType == EDbType.MySql)
                            dbServer = Environment.GetEnvironmentVariable("OPENSHIFT_MYSQL_DB_HOST");
                    }
                    else
                        dbServer = ConfigurationManager.AppSettings["dbServer"];
                    if (dbType == EDbType.MsSql)
                    {
                        if (!string.IsNullOrEmpty(DbPort))
                            dbServer += "," + DbPort;
                    }
                }
                return dbServer;
            }
        }
        string dbUser;

        public string DbUser
        {
            get
            {
                if (dbUser == null)
                {
                    dbUser = ConfigurationManager.AppSettings["dbUser"];
                }
                return dbUser;
            }
        }
        string dbPwd;

        public string DbPwd
        {
            get
            {
                if (dbPwd == null)
                {
                    dbPwd = ConfigurationManager.AppSettings["dbPwd"];
                }
                return dbPwd;
            }
        }

        string dbName;

        public string DbName
        {
            get
            {
                if (dbName == null)
                {
                    dbName = ConfigurationManager.AppSettings["dbName"];
                }
                return dbName;
            }
        }

        string dbPort;
        public string DbPort
        {
            get
            {
                if (dbPort == null)
                {
                    if (IsOpenShift)
                    {
                        if (DbType == EDbType.MySql)
                            dbPort = Environment.GetEnvironmentVariable("OPENSHIFT_MYSQL_DB_PORT");
                    }
                    else
                        dbPort = ConfigurationManager.AppSettings["dbPort"];
                }
                return dbPort;
            }
        }
        EDbType dbType;

        public EDbType DbType
        {
            get
            {
                if (dbType == EDbType.None)
                    dbType = (EDbType)Enum.Parse(typeof(EDbType), ConfigurationManager.AppSettings["dbType"]);
                return dbType;
            }
        }
        public static string GetString()
        {
            string strConn = null;
            var connObj = new ConnectionString();

            switch (connObj.DbType)
            {
                case EDbType.MySql:
                    strConn = MySqlConnectionProvider.GetConnectionString(connObj.DbServer, connObj.DbUser, connObj.DbPwd, connObj.DbName);
                    if (!string.IsNullOrEmpty(connObj.DbPort) && connObj.DbPort != "3306")
                        strConn += string.Format("port={0};", connObj.DbPort);
                    break;

                case EDbType.MsSql:
                    strConn = MSSqlConnectionProvider.GetConnectionString(connObj.dbServer, connObj.dbUser, connObj.dbPwd, connObj.dbName);
                    break;
            }
            return strConn;
        }
    }

    public enum EDbType { None, MsSql, MySql, Access }
}
