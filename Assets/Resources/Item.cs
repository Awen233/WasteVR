using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Item {

    [XmlAttribute("question")]
    public string question;

    [XmlElement("indexNum")]
    public float indexNum;

    [XmlElement("choiceNum")]
    public float choiceNum;

    [XmlElement("correctAnswer")]
    public string correctAnswer;

}
