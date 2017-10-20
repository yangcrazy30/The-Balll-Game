using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class level2buttoncontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void End()
    {
            Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("level3");
    }
}
