using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   

    public void LoadFamily()
    {
        FamilyScene.scene = "family";
        SceneManager.LoadScene("family");
    }
    public void LoadSucess()
    {
        FamilyScene.scene = "sucess";
        SceneManager.LoadScene("family");
    }
    public void LoadMusic()
    {
        FamilyScene.scene = "music";
        SceneManager.LoadScene("family");
    }
    public void LoadEducation()
    {
        FamilyScene.scene = "education";
        SceneManager.LoadScene("family");
    }
    public void LoadNature()
    {
        FamilyScene.scene = "nature";
        SceneManager.LoadScene("family");
    }
    public void Loadpollution()
    {
        FamilyScene.scene = "pollution";
        SceneManager.LoadScene("family");
    }
    public void Loadfriendship()
    {
        FamilyScene.scene = "friendship";
        SceneManager.LoadScene("family");
    }
    public void Loadbirthday()
    {
        FamilyScene.scene = "birthday";
        SceneManager.LoadScene("family");
    }
    public void LoadLife()
    {
        SceneManager.LoadScene("LifeScene");
    }
    public void LoadPsy()
    {
        SceneManager.LoadScene("PsyScene");
    }
    public void home()
    {
        SceneManager.LoadScene("main");
    }
    public void LoadLove()
    {
        psyScene1.scene = "love";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadSad()
    {
        psyScene1.scene = "sad";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadMotivation()
    {
        psyScene1.scene = "motivation";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadWisdom()
    {
        psyScene1.scene = "wisdom";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadSmile()
    {
        psyScene1.scene = "smile";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadHappiness()
    {
        psyScene1.scene = "happiness";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadInspiration()
    {
        psyScene1.scene = "inspiration";
        SceneManager.LoadScene("PsyInside");
    }
    public void LoadLoneliness()
    {
        psyScene1.scene = "loneliness";
        SceneManager.LoadScene("PsyInside");
    }

}
