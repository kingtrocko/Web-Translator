using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Translator
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
    public partial class ArrayOfstring
    {

        private string[] stringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("string")]
        public string[] @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }


}
