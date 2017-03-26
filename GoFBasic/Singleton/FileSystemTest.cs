using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoFBasic.Singleton
{
    [TestClass]
    public class FileSystemTest
    {
        [TestMethod]
        public void default_instance_is_not_null()
        {
            var fs1 = FileSystem.getInstance();
            Assert.IsNotNull(fs1);
        }
    }
}
