using System.Collections.Generic;
using System.IO;

using Utility.IO;

namespace EasyBackup.DifferenceCalculation
{
    public static class DifferenceCalculation
    {
        public static DifferenceCalculationResults CalculateFileOperations
        (
            DirectoryInfo sourceDirectory,
            DirectoryInfo destDirectory
        )
        {
            var results = new DifferenceCalculationResults();

            CalculateCopyFileOperations(results, sourceDirectory, destDirectory);
            CalculateDeleteFileOperations(results, sourceDirectory, destDirectory);

            return results;
        }

        public static void CalculateCopyFileOperations
        (
            DifferenceCalculationResults results,
            DirectoryInfo sourceDirectory,
            DirectoryInfo destDirectory
        )
        {
            CalculateCopyFileOperations
            (
                results,
                sourceDirectory,
                destDirectory,
                sourceDirectory
            );
        }

        public static void CalculateCopyFileOperations
        (
            DifferenceCalculationResults results,
            DirectoryInfo sourceDirectory,
            DirectoryInfo destDirectory,
            DirectoryInfo parentDirectory
        )
        {
#if DEBUG
            IEnumerable<FileSystemInfo> fileSystemInfos = parentDirectory.GetFileSystemInfos();
#else
            IEnumerable<FileSystemInfo> fileSystemInfos = parentDirectory.EnumerateFileSystemInfos();
#endif
            foreach (FileSystemInfo fileSystemInfo in fileSystemInfos)
            {
                string matchingFilePath = FileSystem.GetOtherFolderMatchingFileSystemPath
                (
                    fileSystemInfo,
                    sourceDirectory,
                    destDirectory
                );
                FileSystemInfo matchingFileSystemInfo = FileSystem.GetFileSystemInfo
                (
                    matchingFilePath
                );
#if DEBUG
                bool isFolder = fileSystemInfo.IsFolder();
                bool? matchingFileIsFolder = matchingFileSystemInfo?.IsFolder();
#endif

                if (matchingFileSystemInfo == null)
                {
                    // The matching file in the destination directory does not exists,
                    // we can safely copy this file (or folder) there.

                    results.AddCopyOperation
                    (
                        fileSystemInfo.FullName,
                        matchingFilePath,
                        OperationErrors.DestFileDoesNotExists
                    );
                }
                else
                {
#if !DEBUG
                    bool isFolder = fileSystemInfo.IsFolder();
#endif
                    if (isFolder != matchingFileSystemInfo.IsFolder())
                    {
                        /*
                        If the matching file's "kind" (is file or is folder) is different
                        from the "kind" of this file, we have to delete it first in order to override it
                        and then copy this file there once it can be done with no errors.
                        */

                        results.AddCopyOperation
                        (
                            fileSystemInfo.FullName,
                            matchingFileSystemInfo.FullName,
                            OperationErrors.DestFileDifferentDirAttr
                        );
                    }
                    else
                    {
                        if (isFolder)
                        {
                            // If both are directories, then we need to keep calculating the differences.
                            CalculateCopyFileOperations
                            (
                                results,
                                sourceDirectory,
                                destDirectory,
                                (DirectoryInfo)fileSystemInfo
                            );
                        }
                        else
                        {
                            // If the file exists, then we need to compare them.
                            OperationError error = null;
                            var fileInfo = (FileInfo)fileSystemInfo;
                            var matchingFileInfo = (FileInfo)matchingFileSystemInfo;

                            if (fileInfo.LastWriteTime > matchingFileInfo.LastWriteTime)
                            {
                                error = OperationErrors.DestFileLaterLastWriteTime;
                            }
                            else if (fileInfo.LastWriteTime == matchingFileInfo.LastWriteTime)
                            {
                                if (fileInfo.Length != matchingFileInfo.Length)
                                {
                                    error = OperationErrors.DestFileSameWriteTimeDifferentLength;
                                }
                            }
                            else // fileInfo.LastWriteTime < matchingFileInfo.LastWriteTime
                            {
                                error = OperationErrors.DestFileBeforeWriteTime;
                            }

                            if (error != null)
                            {
                                results.AddCopyOperation
                                (
                                    fileSystemInfo.FullName,
                                    matchingFileSystemInfo.FullName,
                                    error
                                );
                            }
                        }
                    }
                }
            }
        }

        public static void CalculateDeleteFileOperations
        (
            DifferenceCalculationResults results,
            DirectoryInfo sourceDirectory,
            DirectoryInfo destDirectory
        )
        {
            CalculateDeleteFileOperations
            (
                results,
                sourceDirectory,
                destDirectory,
                destDirectory
            );
        }

        public static void CalculateDeleteFileOperations
        (
            DifferenceCalculationResults results,
            DirectoryInfo sourceDirectory,
            DirectoryInfo destDirectory,
            DirectoryInfo parentDirectory
        )
        {
#if DEBUG
            IEnumerable<FileSystemInfo> fileSystemInfos = parentDirectory.GetFileSystemInfos();
#else
            IEnumerable<FileSystemInfo> fileSystemInfos = parentDirectory.EnumerateFileSystemInfos();
#endif
            foreach (FileSystemInfo fileSystemInfo in fileSystemInfos)
            {
#if DEBUG
                FileSystemInfo matchingFileSystemInfo = FileSystem.GetOtherFolderMatchingFileSystemInfo
                (
                    fileSystemInfo,
                    destDirectory,
                    sourceDirectory
                );

                bool isFolder = fileSystemInfo.IsFolder();
                bool? matchingFileIsFolder = matchingFileSystemInfo?.IsFolder();

                if (matchingFileSystemInfo == null)
#else
                string matchingFilePath = FileSystem.GetOtherFolderMatchingFileSystemPath
                (
                    fileSystemInfo,
                    sourceDirectory,
                    destDirectory
                );
                if (!Utility.IO.FileSystem.DoesPathExist(matchingFilePath))
#endif
                {
                    results.AddDeleteOperation(fileSystemInfo.FullName);
                }
                else
                {
                    if (fileSystemInfo.IsFolder())
                    {
                        CalculateDeleteFileOperations
                        (
                            results,
                            sourceDirectory,
                            destDirectory,
                            (DirectoryInfo)fileSystemInfo
                        );
                    }
                }
            }
        }
    }
}