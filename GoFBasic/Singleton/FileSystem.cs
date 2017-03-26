using System;

namespace GoFBasic.Singleton
{
    public class FileSystem
    {
        public static object getInstance()
        {
            return new FileSystem();
        }
    }
}