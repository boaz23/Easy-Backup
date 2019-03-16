using System;

using FileOperation;

namespace EasyBackup.DifferenceCalculation
{
    public class Operation
    {
        public Operation(FileOperationItem fileOperationItem, OperationError operationError)
        {
            if (fileOperationItem == null)
            {
                throw new ArgumentNullException(nameof(fileOperationItem));
            }
            if (operationError == null)
            {
                throw new ArgumentNullException(nameof(operationError));
            }

            this.FileOperationItem = fileOperationItem;
            this.OperationError = operationError;
        }

        public FileOperationItem FileOperationItem { get; }
        public OperationError OperationError { get; }
    }
}