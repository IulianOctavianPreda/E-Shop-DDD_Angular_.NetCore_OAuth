﻿using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class LongMetaData : PropertyMetaData
    {
        [DataMember]
        public long MinValue { get; set; }
        [DataMember]
        public long MaxValue { get; set; }
    }
}
