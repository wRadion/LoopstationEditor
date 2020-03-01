﻿using System.Xml.Serialization;

using Loopstation.Xml.Base;

namespace Loopstation.Xml
{
    [XmlRoot("database")]
    public class XmlSystemFile : XmlFileBase
    {
        /// <summary>
        /// The default file name of a Loopstation RC-505 system file.
        /// </summary>
        public const string FILE_NAME = "SYSTEM.RC0";

        [XmlElement("sys")]
        public XmlSystemSettings System;

        /// <summary>
        /// Initializes an object that represents a Loopstation RC-505 system file.
        /// </summary>
        public XmlSystemFile() : this(null) { }
        /// <summary>
        /// Initializes an object that represents a Loopstation RC-505 system file.
        /// </summary>
        /// <param name="other">An other system to copy the values from</param>
        public XmlSystemFile(XmlSystemFile other)
        {
            System = new XmlSystemSettings(other?.System);
        }

        public override object Clone() => new XmlSystemFile(this);
    }
}