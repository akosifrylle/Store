using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Store.Data;
using Store.NHibernate;
using Store.NHibernate.Dao;
using Store.Services;
using Store.WinForms.Views;

namespace Store.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoMapperConfig.Initialize();

            //TODO : Refactor - Add to seperate class
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IUserService, UserService>();
            unityContainer.RegisterType<IUserDao, UserDao>();
            unityContainer.RegisterType<IProductService, ProductService>();
            unityContainer.RegisterType<IProductDao, ProductDao>();

            Unity.BuildUnityContainer();

            //Application.Run(new Login(Unity.UnityContainer.Resolve<UserService>()));
            Application.Run(new ProductMaintenance(unityContainer.Resolve<ProductService>()));
        }
    }
}
