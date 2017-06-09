using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class loadingScene : MonoBehaviour {
    public GameObject screen1;
    public GameObject screen2;
	// Use this forg initialization
	void Start () {
        screen2.SetActive(false);
        screen1.SetActive(true);
        StartCoroutine(loadNext());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator loadNext()
    {
        yield return new WaitForSeconds(4f);
        screen1.SetActive(false);
        screen2.SetActive(true);
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene("main");

    }
    public void loadApp()
    {
        SceneManager.LoadScene("main");
    }
}
