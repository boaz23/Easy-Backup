using System.ComponentModel;

using Utility;

namespace EasyBackup.DifferenceCalculation
{
    public class OperationError
    {
        public OperationError(OperationErrorLevel errorLevel, string message)
            : this(errorLevel, message, GetDefaultCheckState(errorLevel)) { }

        public OperationError(OperationErrorLevel errorLevel, string message, bool defaultCheckState)
        {
            switch (errorLevel)
            {
                case OperationErrorLevel.None:
                case OperationErrorLevel.Information:
                    if (message == null)
                    {
                        message = string.Empty;
                    }
                    break;
                case OperationErrorLevel.Warning:
                case OperationErrorLevel.Error:
                    if (string.IsNullOrWhiteSpace(message))
                    {
                        throw new StringArgumentNullOrWhiteSpaceException(nameof(message));
                    }
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(errorLevel), (int)errorLevel, typeof(OperationErrorLevel));
            }

            this.ErrorLevel = errorLevel;
            this.Message = message;
            this.DefaultCheckState = defaultCheckState;
        }

        public OperationErrorLevel ErrorLevel { get; }
        public string Message { get; }
        public bool DefaultCheckState { get; }

        private static bool GetDefaultCheckState(OperationErrorLevel errorLevel)
        {
            switch (errorLevel)
            {
                case OperationErrorLevel.None:
                case OperationErrorLevel.Information:
                    return true;
                case OperationErrorLevel.Warning:
                case OperationErrorLevel.Error:
                    return false;
                default:
                    throw new InvalidEnumArgumentException(nameof(errorLevel), (int)errorLevel, typeof(OperationErrorLevel));
            }
        }
    }
}