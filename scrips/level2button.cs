using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level2button : MonoBehaviour {
 public void Restart()
    {
        SceneManager.LoadScene("level3");
    }
    public void End()
    {
        SceneManager.LoadScene("level4");
    }
}
