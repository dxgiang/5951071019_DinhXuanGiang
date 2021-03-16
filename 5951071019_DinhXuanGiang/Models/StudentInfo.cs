using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071019_DinhXuanGiang.Models
{
    [DataContract]
    public class StudentInfo
    {

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "ID")]
        public double ID { get; set; }

        [DataMember(Name = "Age")]
        public int Age { get; set; }


    }
}