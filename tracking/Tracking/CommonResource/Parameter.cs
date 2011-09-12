﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CommonResource
{
    [DataContract(Namespace = "")]
    public class Parameter
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Type;
        [DataMember]
        public string Value;
    }
    [CollectionDataContract(Name = "ParameterList", Namespace = "")]
    public class ParameterList : List<Parameter>
    {

    }
}