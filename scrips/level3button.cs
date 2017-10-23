using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level3button : MonoBehaviour {

	public void End()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("level4");
    }
}
