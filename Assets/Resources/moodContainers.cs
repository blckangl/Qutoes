
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

[XmlRoot("List")]
public class moodContainer
{
    [XmlArray("Life")]
    [XmlArrayItem("quote")]
    public List<Mood> moods = new List<Mood>();
    [XmlArray("psy")]
    [XmlArrayItem("quote")]
    public List<Mood> ListPsy = new List<Mood>();
    public static moodContainer Load(string path)
    {

        TextAsset _xml = Resources.Load<TextAsset>(path) as TextAsset;
        
        XmlSerializer serializer = new XmlSerializer(typeof(moodContainer));
        StringReader reader = new StringReader(_xml.text);
        moodContainer moods = serializer.Deserialize(reader) as moodContainer;
        //moodContainer ListPsy = serializer.Deserialize(reader) as moodContainer;
        reader.Close();
        return moods;

    }
}

