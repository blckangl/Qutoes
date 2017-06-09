using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class psyScene1 : MonoBehaviour {
    public Text text;
    public Text title;
    public int i;
    public List<Mood> moods = new List<Mood>();
    public static string scene;
    // Use this for initialization
    void Start()
    {
        foreach (Mood m in loader.PsyQuotes)
        {
            if (m.name.Equals(scene))
            {
                moods.Add(m);
            }
        }
        i = 0;

        text.text = moods[i].advice;
        title.text = scene;
       
    }

    // Update is called once per frame
    void Update()
    {


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


    public void back()
    {
        SceneManager.LoadScene("PsyScene");
    }
}
