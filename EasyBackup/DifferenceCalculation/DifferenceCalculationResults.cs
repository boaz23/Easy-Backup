using System.Collections;
using System.Collections.Generic;
using System.IO;

using FileOperation;

namespace EasyBackup.DifferenceCalculation
{
    public class DifferenceCalculationResults : IEnumerable<Operation>
    {
        public DifferenceCalculationResults()
        {
            this.Operations = new List<Operation>();
        }

        public List<Operation> Operations { get; }

        public void AddCopyOperation(string sourceFilePath, string destionationFilePath, OperationError error)
        {
            this.Operations.Add(new Operation
            (
                CreateCopyOperation(sourceFilePath, destionationFilePath),
                error
            ));
        }

        private static CopyFileOperation CreateCopyOperation(string sourceFilePath, string destionationFilePath)
        {
            return new CopyFileOperation
            (
                sourceFilePath,
                Path.GetDirectoryName(destionationFilePath)
            );
        }

        public void AddDeleteOperation(string filePath)
        {
            this.Operations.Add
            (
                new Operation(new DeleteFileOperation(filePath), OperationErrors.Delete)
            );
        }

        public IEnumerator<Operation> GetEnumerator()
        {
            return this.Operations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}