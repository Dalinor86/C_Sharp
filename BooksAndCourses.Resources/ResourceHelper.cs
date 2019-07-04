using System.IO;
using System.Linq;
using System.Reflection;

namespace BooksAndCourses.Resources
{
    public static class ResourceHelper
    {
        private static readonly Assembly _assembly;
        private static readonly string[] _resourceNames;

        static ResourceHelper()
        {
            _assembly = Assembly.GetExecutingAssembly();
            _resourceNames = _assembly.GetManifestResourceNames();
        }

        public static Stream GetResource(string resourcePath)
        {
            string path = resourcePath.Replace(@"/", ".").Replace(@"\", ".");
            string assemblyPath = _assembly.GetName().Name + "." + path;
            if (!_resourceNames.Contains(assemblyPath)) return null;

            var resource = _assembly.GetManifestResourceStream(assemblyPath);
            return resource;
        }
    }
}
