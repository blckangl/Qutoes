using UnityEngine;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

public class loader : MonoBehaviour {
    public static List<Mood> LifeQutoes;
    public static List<Mood> PsyQuotes;
    public const string path = "DB";
    public static loader manager;
	// Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (manager == null)
        {
            manager = this;
        }
        else
            Destroy(gameObject);

        LifeQutoes = new List<Mood>();
        PsyQuotes = new List<Mood>();

        moodContainer mc = moodContainer.Load(path);
        foreach (Mood m in mc.moods)
        {
            LifeQutoes.Add(m);
        }
        foreach (Mood m in mc.ListPsy)
        {
            PsyQuotes.Add(m);
        }

     

    

}
	
         
	
	

   
}
