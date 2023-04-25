using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfService
{
    [DataContract]
    public class OperationException : FaultException
    {
        public OperationException(string message) : base(message)
        {
        }
    }
}
