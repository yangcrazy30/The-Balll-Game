using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttoncontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*void OnGUI()
    {
        if (GUI.Button(new Rect(300, 0, 200, 30), "Restart"))
        {
            SceneManager.LoadScene("level1");
        }
        if (GUI.Button(new Rect(600, 0, 200, 30), "Next Level"))
        {
            SceneManager.LoadScene("level1");
        }

    }*/
    public void Click()
    {
        SceneManager.LoadScene("level1");
    }
    public void Nextlevel()
    {
        SceneManager.LoadScene("level3");
    }
    public void End()
    { 
            Application.Quit();
    }
}
