using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject gameCanvas;
    [SerializeField] private GameObject aboutCanvas;

    public void Play()
    {
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }

    public void Back()
    {
        menuCanvas.SetActive(true);
        gameCanvas.SetActive(false);
        aboutCanvas.SetActive(false);
    }

    public void About()
    {
        menuCanvas.SetActive(false);
        aboutCanvas.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
