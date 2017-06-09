using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SucessScene : MonoBehaviour {
    public Text text;
    public int i;
    public List<Mood> moods = new List<Mood>();
    // Use this for initialization
    void Start () {
	foreach(Mood m in loader.LifeQutoes)
        {
            if (m.name.Equals("sucess"))
            {
                moods.Add(m);
            }
        }
        i = 0;

        text.text = moods[i].advice;
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    public void next()
    {
        i++;  
        if (i >= moods.Count)
        {
            i = 0;
        }
        text.text = moods[i].advice;
    }
}
