using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLibrary
{

	[Serializable]
	public class BusFullException : Exception
	{
		public BusFullException() { }
		public BusFullException(string message) : base(message) { }
		public BusFullException(string message, Exception inner) : base(message, inner) { }
		protected BusFullException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
