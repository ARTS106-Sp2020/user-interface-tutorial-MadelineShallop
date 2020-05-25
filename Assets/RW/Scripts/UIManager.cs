using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;

    public void OpenSettings()
    {

        startButton.SetBool("isHidden", true);

        settingsButton.SetBool("isHidden", true);
    }
   public void StartGame()
    {

        SceneManager.LoadScene("RocketMouse");
    }
}
