using System;
using System.Runtime.Serialization;
namespace Service
{
    [DataContract]
    public class Arguments
    {
        [DataMember]
        public double Arg1
        {
            get; set;
        }
        [DataMember]
        public double Arg2
        {
            get; set;
        }
    }
}

