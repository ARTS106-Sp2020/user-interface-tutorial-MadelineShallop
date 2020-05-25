﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;
    public Animator contentPanel;
    public Animator gearImage;

    public void OpenSettings()
    {

        startButton.SetBool("isHidden", true);

        settingsButton.SetBool("isHidden", true);

        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {

        startButton.SetBool("isHidden", false);

        settingsButton.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }

    public void ToggleMenu()
    {
        bool isHidden = contentPanel.GetBool("isHidden");

        contentPanel.SetBool("isHidden", !isHidden);

        gearImage.SetBool("isHidden", !isHidden);
    }
   public void StartGame()
    {

        SceneManager.LoadScene("RocketMouse");
    }
}
