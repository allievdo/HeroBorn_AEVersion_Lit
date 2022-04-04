using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yes1 : MonoBehaviour
{
    public void YesRestart1()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
