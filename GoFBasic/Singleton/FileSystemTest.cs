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

        [TestMethod]
        public void call_getInstance_twice_get_the_smae_instance()
        {
            Assert.AreSame(FileSystem.getInstance(), FileSystem.getInstance());
        }
    }
}
