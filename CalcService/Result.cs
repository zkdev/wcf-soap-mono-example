using System;
using System.Runtime.Serialization;
namespace Service
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public double Value { get; set; }
    }
}

