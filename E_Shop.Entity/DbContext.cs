using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Entity
{
    public class DbContext<T> where T : class, new()
    {
        //用来处理复杂操作
        public SqlSugarClient Db;
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString,
                 DbType= DbType.SqlServer,
                  IsAutoCloseConnection=true,
                  InitKeyType= InitKeyType.Attribute,
            });
        }

        //简单操作
        public SimpleClient<T> SimpleDb => new SimpleClient<T>(Db);


    }
}
