using System;
using System.Runtime.Serialization;

namespace CanvasJSExamples.Models {
    //DataContract for Serializing Data - required to serve in JSON format
    [DataContract]
    public class DataCombination {
        public DataCombination(double x, double y, string indexLabel) {
            this.X = x;
            this.Y = y;
            this.IndexLabel = indexLabel;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "x")]
        public Nullable<double> X = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<double> Y = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "indexLabel")]
        public string IndexLabel = "";
    }
}