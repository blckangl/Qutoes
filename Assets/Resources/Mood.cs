using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Mood {

    [XmlAttribute("name")]
    public string name;
    [XmlElement("advice")]
    public string advice;
    
    
}
