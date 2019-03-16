using EasyBackup.Properties;

namespace EasyBackup.DifferenceCalculation
{
    public class OperationErrors
    {
        public static OperationError Delete { get; } = new OperationError
        (
            OperationErrorLevel.Information,
            Resources.OperarionError_Delete
        );

        public static OperationError DestFileDoesNotExists { get; } = new OperationError
        (
            OperationErrorLevel.Information,
            Resources.OperarionError_DestFileDoesNotExists
        );

        public static OperationError DestFileLaterLastWriteTime { get; } = new OperationError
        (
            OperationErrorLevel.Information,
            Resources.OperarionError_DestFileLaterLastWriteTime
        );

        public static OperationError DestFileDifferentDirAttr { get; } = new OperationError
        (
            OperationErrorLevel.Error,
            Resources.OperarionError_DestFileDifferentDirAttr
        );

        public static OperationError DestFileSameWriteTimeDifferentLength { get; } = new OperationError
        (
            OperationErrorLevel.Warning,
            Resources.OperarionError_DestFileSameWriteTimeDifferentLength
        );

        public static OperationError DestFileBeforeWriteTime { get; } = new OperationError
        (
            OperationErrorLevel.Warning,
            Resources.OperarionError_DestFileBeforeWriteTime
        );
    }
}