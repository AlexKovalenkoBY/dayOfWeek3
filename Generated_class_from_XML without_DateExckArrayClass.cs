﻿using System;

public class Class1
{
	public Class1()
	{

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DateexArray
    {

        private DateexArrayDateexClass[] dateexClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateexClass")]
        public DateexArrayDateexClass[] DateexClass
        {
            get
            {
                return this.dateexClassField;
            }
            set
            {
                this.dateexClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DateexArrayDateexClass
    {

        private System.DateTime dayexclField;

        private bool flagField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dayexcl
        {
            get
            {
                return this.dayexclField;
            }
            set
            {
                this.dayexclField = value;
            }
        }

        /// <remarks/>
        public bool Flag
        {
            get
            {
                return this.flagField;
            }
            set
            {
                this.flagField = value;
            }
        }
    }


}
}
