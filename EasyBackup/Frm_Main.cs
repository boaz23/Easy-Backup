using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EasyBackup.DifferenceCalculation;
using FileOperation;

namespace EasyBackup
{
    internal sealed partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            bool flag;

            flag = CheckDirectoryExists(
                Bf_SourceDirectory,
                "Source",
                out DirectoryInfo sourceDirectory
            );
            if (!flag)
            {
                return;
            }

            flag = CheckDirectoryExists(
                Bf_DestinationDirectory,
                "Destination",
                out DirectoryInfo destDirectory
            );
            if (!flag)
            {
                return;
            }

            DifferenceCalculationResults results = DifferenceCalculation.DifferenceCalculation.CalculateFileOperations
            (
                sourceDirectory,
                destDirectory
            );

            ExecuteOperations
            (
                sourceDirectory,
                destDirectory,
                results
            );
        }

        private bool CheckDirectoryExists(BrowseFolder browseFolder, string dirErrorName, out DirectoryInfo directory)
        {
            return CheckDirectoryExists(browseFolder.SelectedPath, dirErrorName, out directory);
        }
        private bool CheckDirectoryExists(string dirPath, string dirErrorName, out DirectoryInfo directory)
        {
            directory = new DirectoryInfo(Path.GetFullPath(dirPath));
            if (!directory.Exists)
            {
                _ = MessageBox.Show(
                    this,
                    $"{dirErrorName} directory does not exsists.",
                    "Not Found!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                directory = null;
                return false;
            }

            return true;
        }

        private void ExecuteOperations(DirectoryInfo sourceDirectory, DirectoryInfo destDirectory, DifferenceCalculationResults results)
        {
            IEnumerable<FileOperationItem> operations = results
                .Where(x => x.OperationError.ErrorLevel <= OperationErrorLevel.Information)
                .Select(x => x.FileOperationItem);
#if DEBUG
            List<FileOperationItem> operationsList = operations.ToList();
            operations = operationsList;
#endif

            if (!operations.Any())
            {
                MessageBox.Show(this, "No differences were detected, No action is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(this, "Are you sure you want to start the operations?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            FileOperation.FileOperation fileOperation = null;
            try
            {
                fileOperation = new FileOperation.FileOperation(Handle)
                {
                    OperationsFlags = FileOperationFlags.NoConfirmDirectoryCreation |
                                      FileOperationFlags.NoConfirmation
                };
                foreach (FileOperationItem operation in operations)
                {
                    fileOperation.AddOperation(operation);
                }

                fileOperation.PerformOperations();

                MessageBox.Show(this, "Done.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Btn_Ok.Enabled = false;
            }
            finally
            {
                fileOperation?.Dispose();
            }
        }
    }
}