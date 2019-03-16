using System.IO;

using static Utility.Numbers;
using static Utility.Strings;

namespace EasyBackup
{
    public static class FileSystem
    {
        public static string GetRelativePath
        (
            FileSystemInfo fileSystemInfo,
            DirectoryInfo parentDirectoryInfo
        )
        {
            string directoryFullPath = parentDirectoryInfo.FullName;
            int removeCount = directoryFullPath.Length;
            if (!directoryFullPath.EndsWith(Path.PathSeparator))
            {
                removeCount++;
            }

            return fileSystemInfo.FullName.Remove(0, removeCount);
        }

        public static FileSystemInfo GetOtherFolderMatchingFileSystemInfo
        (
            FileSystemInfo fileSystemInfo,
            DirectoryInfo sourceDirectoryInfo,
            DirectoryInfo destinationDirectoryInfo
        )
        {
            string destFilePath = GetOtherFolderMatchingFileSystemPath(fileSystemInfo, sourceDirectoryInfo, destinationDirectoryInfo);
            return GetFileSystemInfo(destFilePath);
        }

        public static string GetOtherFolderMatchingFileSystemPath
        (
            FileSystemInfo fileSystemInfo,
            DirectoryInfo sourceDirectoryInfo,
            DirectoryInfo destinationDirectoryInfo
        )
        {
            return Utility.IO.FileSystem.GetFullPath(Path.Combine
            (
                destinationDirectoryInfo.FullName,
                GetRelativePath(fileSystemInfo, sourceDirectoryInfo)
            ));
        }

        public static FileSystemInfo GetFileSystemInfo(string destFilePath)
        {
            if (!Utility.IO.FileSystem.DoesPathExist(destFilePath))
            {
                return null;
            }

            if (File.GetAttributes(destFilePath).HasAnyOfFlags(FileAttributes.Directory))
            {
                return new DirectoryInfo(destFilePath);
            }

            return new FileInfo(destFilePath);
        }
    }
}