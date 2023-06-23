using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void ARScan()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Debug.Log("Игра закрыта");
        Application.Quit();
    }
}
