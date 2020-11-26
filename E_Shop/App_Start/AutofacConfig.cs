using Autofac;
using Autofac.Integration.Mvc;
using E_Shop.BLL;
using E_Shop.DAL;
using E_Shop.IBLL;
using E_Shop.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            //配置Autofac
            //1、创建容器
            var builder = new ContainerBuilder();

            //2、依赖注入
            //builder.RegisterType<CustomerDal>().As<ICustomerDal>();
            //builder.RegisterType<CustomerService>().As<ICustomerService>();
            //2、通过反射配置 程序集 注入所有
            Assembly dal = Assembly.Load("E_Shop.DAL");
            //通过容器注册反射得到类型实例，并且与接口关联
            builder.RegisterAssemblyTypes(dal).AsImplementedInterfaces();
            Assembly service = Assembly.Load("E_Shop.BLL");
            //通过容器注册反射得到类型实例，并且与接口关联
            builder.RegisterAssemblyTypes(service).AsImplementedInterfaces();

            //3、注册控制器
            builder.RegisterControllers(typeof(AutofacConfig).Assembly);

            //4、构建
            var container = builder.Build();

            //5、实现
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}