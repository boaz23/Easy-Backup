using System;
using System.Collections.Generic;
using FileOperation;

namespace UnitTesting
{
    internal class EmptyFileOperation : IFileOperation
    {
        public EmptyFileOperation()
        {
            this.OwnerWindowHandle = IntPtr.Zero;
            this.OperationsFlags = FileOperationFlags.None;
            this.FileOperations = new List<FileOperationItem>();
        }

        public void AddOperation(FileOperationItem operation)
        {
            this.FileOperations.Add(operation);
        }
        public void ClearAllOperations()
        {
            this.FileOperations.Clear();
        }
        public bool GetAnyOperationsAborted()
        {
            return false;
        }
        public void PerformOperations()
        {
        }

        public IList<FileOperationItem> FileOperations { get; }
        public FileOperationFlags OperationsFlags { get; set; }
        public IntPtr OwnerWindowHandle { get; }

        public event EventHandler<FinishOperaionsEventArgs> OnOperationsFinish;
        public event EventHandler<EventArgs> OnOperationsStart;
        public event EventHandler<PostMoveCopyEventArgs> OnPostCopy;
        public event EventHandler<PostDeleteEventArgs> OnPostDelete;
        public event EventHandler<PostMoveCopyEventArgs> OnPostMove;
        public event EventHandler<PostNewEventArgs> OnPostNew;
        public event EventHandler<PostRenameEventArgs> OnPostRename;
        public event EventHandler<PreMoveCopyEventArgs> OnPreCopy;
        public event EventHandler<PreDeleteEventArgs> OnPreDelete;
        public event EventHandler<PreMoveCopyEventArgs> OnPreMove;
        public event EventHandler<PreNewEventArgs> OnPreNew;
        public event EventHandler<PreRenameEventArgs> OnPreRename;
    }
}