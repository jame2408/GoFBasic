using System;

namespace GoFBasic.Singleton
{
    public class FileSystem
    {
        private FileSystem() { }

        private static readonly FileSystem mFileSystem = new FileSystem();

        public static FileSystem getInstance()
        {
            return mFileSystem;
        }
    }
}