using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool fromMainScene;

    public void Change_Scene()
    {
        if (fromMainScene)
        {
            SceneManager.LoadScene("Prototype 2");
        }
        else
        {
            SceneManager.LoadScene("Challenge 2");
        }
    }
}
