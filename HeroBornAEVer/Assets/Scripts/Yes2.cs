using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Yes2 : MonoBehaviour
{
    public void YesRestart2()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
