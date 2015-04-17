using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace WebTranslator.Models
{
    [DataContract]
    public class Translator
    {

        [DataMember(Name = "SourceSelectedValue")]  
        public string SourceSelectedValue { get; set; }

        [DataMember(Name = "TargetSelectedValue")]  
        public string TargetSelectedValue { get; set; }
        
        
        public SelectList SourceLanguages { get; set; }


        public SelectList TargetLanguages { get; set; }

        
        [DataType(DataType.MultilineText)]
        public string TranslateText { get; set; }

        
        [DataType(DataType.MultilineText)]
        public string TranslateResult { get; set; }
    }
}