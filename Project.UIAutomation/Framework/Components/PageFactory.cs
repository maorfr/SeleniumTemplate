using Framework.Interfaces;

namespace Framework.Components
{
    public class PageFactory
    {
        public static T GetPage<T>() where T : class, IPageObject
        {
            var type = typeof(T);

            return (T)type.Assembly.CreateInstance(type.FullName);
        }
    }
}
