using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level1button : MonoBehaviour {

public void LEVEL1()
    {
        SceneManager.LoadScene("level1");
    }
public void LEVEL2()
    {
        SceneManager.LoadScene("level3");
    }
public void LEVEL3()
    {
        SceneManager.LoadScene("level4");
    }
}
