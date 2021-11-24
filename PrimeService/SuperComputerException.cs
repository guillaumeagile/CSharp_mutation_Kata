using System;

namespace PrimeService
{
    [Serializable]
    public class SuperComputerException : ApplicationException
    {
      
        protected SuperComputerException()
        {
        }

        protected SuperComputerException(string message) : base(message)
        {
        }

        protected SuperComputerException(string message, Exception innerException) : base(message, innerException)
        {
        }
  /*
        protected SuperComputerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }*/

        public static SuperComputerException OperationHasFailed(string operation, Exception innerException = null)
        {
            return new SuperComputerException($"Operation {operation} has failed.", innerException);
        }
    }
}