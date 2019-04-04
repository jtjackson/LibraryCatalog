using System;
using System.Runtime.Serialization;

namespace LibraryCatalog
{
    [DataContract]
    public class Book 
    {
        public Book() { }

        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string pages { get; set; }
        [DataMember]
        public string year { get; set; }
        [DataMember]
        public string language { get; set; }
        [DataMember]
        public string country { get; set; }

    }
}
