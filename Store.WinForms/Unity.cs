using Microsoft.Practices.Unity;
using Store.Services;
using Store.Data;
using Store.NHibernate.Dao;

namespace Store.WinForms
{
    public static class Unity
    {
        private static IUnityContainer _unityContainer;

        public static void BuildUnityContainer()
        {
            _unityContainer = new UnityContainer();

            _unityContainer.RegisterType<IUserService, UserService>();
            _unityContainer.RegisterType<IUserDao, UserDao>();
        }
    }
}
