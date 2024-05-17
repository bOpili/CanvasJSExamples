using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CanvasJSExamples.Models {

    [DataContract]
    public class DataPerson {
        //Constructor of the point
        public DataPerson(string label, dynamic y) {
            this.Label = label;
            this.Y = y;
        }

        [DataMember(Name = "label")]
        public string Label = "";

        [DataMember(Name = "y")]
        public dynamic Y = null;

    }
}