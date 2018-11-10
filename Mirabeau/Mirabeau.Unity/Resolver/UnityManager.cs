using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Mirabeau.Unity.Helpers
{
    /// <summary>
    /// UnityManager
    /// </summary>
    public static class UnityManager
    {
        /// <summary>
        /// _container
        /// </summary>
        private static IUnityContainer _container;

        /// <summary>
        /// Container
        /// </summary>
        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    using (IUnityContainer newInstance = new UnityContainer())
                    {
                        UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                        section.Configure(newInstance);
                        _container = newInstance;
                    }
                }
                return _container;
            }
            set
            {
                _container = value;
            }
        }

        /// <summary>
        /// Resolve
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T Resolve<T>(string name)
        {
            return Container.Resolve<T>(name);
        }

        /// <summary>
        /// Resolve
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {            
            return Container.Resolve<T>();
        }
        
    }
}
