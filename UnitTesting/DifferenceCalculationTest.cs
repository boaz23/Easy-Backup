using System.IO;
using EasyBackup.DifferenceCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility.Interop.Native;

namespace UnitTesting
{
    [TestClass]
    public class DifferenceCalculationTest
    {
        [TestMethod]
        public void TestPaths()
        {
            string s = @"\\?\H:\My Files\Boaz\Programming\My Projects\Android\!--Backup--!\pinit\bottom-bar\build\tmp\expandedArchives\classes.jar_8wq1z85gt6dc229f4ajc3l3k7\android\support\v4\media\session\MediaControllerCompat$MediaControllerImplApi21$ExtraBinderRequestResultReceiver.class";
            string sf = Path.GetDirectoryName(s);

            string p = @"H:\My Files\Boaz\Programming\My Projects\Android\!--Backup--!\pinit\bottom-bar\build\tmp\expandedArchives\classes.jar_8wq1z85gt6dc229f4ajc3l3k7\android\support\v4\media\session\MediaControllerCompat$MediaControllerImplApi21$ExtraBinderRequestResultReceiver.class";
            string fp = Path.GetFullPath(p);
            string fpnn = @"\\?\" + fp;
            bool peqfp = p == fp;

            bool pep = NativeMethods.PathExists(p);
            bool pefp = NativeMethods.PathExists(fp);
            bool pefpnn = NativeMethods.PathExists(fpnn);
            bool dpep = Utility.IO.FileSystem.DoesPathExist(p);

            try
            {
                FileAttributes fap = File.GetAttributes(p);
            }
            catch
            {
            }
            try
            {
                FileAttributes fafp = File.GetAttributes(fp);
            }
            catch
            {
            }
            FileAttributes fafpnn = File.GetAttributes(fpnn);

            try
            {
                var fip = new FileInfo(p);
            }
            catch
            {
            }
            try
            {
                var fifp = new FileInfo(fp);
            }
            catch
            {
            }
            var fifpnn = new FileInfo(fpnn);
        }

        [TestMethod]
        public void TestDifferencesCalculation_MyBigFolder()
        {
            DifferenceCalculationResults results = DifferenceCalculation.CalculateFileOperations
            (
                new DirectoryInfo(@"H:\My Files\Boaz"),
                new DirectoryInfo(@"G:\My Files\Boaz")
            );
        }

        [TestMethod]
        public void TestDifferencesCalculation_Music0()
        {
            DifferenceCalculationResults results = DifferenceCalculation.CalculateFileOperations
            (
                new DirectoryInfo(@"D:\Music\Music"),
                new DirectoryInfo(@"H:\My Files\Boaz\Music")
            );
        }
    }
}
