﻿using System;
using System.Runtime.Serialization;

namespace Rules.Base
{
    [DataContract]
    public class DateTimeMetaData : PropertyMetaData<DateTime>
    {
        [DataMember]
        public DateTime Start { get; set; }

        [DataMember]
        public DateTime End { get; set; }
    }
}
