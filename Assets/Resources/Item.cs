using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Item {

    [XmlAttribute("a")]
    public string a;

    [XmlAttribute("b")]
    public string b;

    [XmlAttribute("c")]
    public string c;

    [XmlAttribute("d")]
    public string d;

    [XmlAttribute("e")]
    public string e;

    [XmlAttribute("question")]
    public string question;

    [XmlElement("indexNum")]
    public float indexNum;

    [XmlElement("choiceNum")]
    public float choiceNum;

    [XmlElement("correctAnswer")]
    public string correctAnswer;

}
