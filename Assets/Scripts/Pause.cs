using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isGamePaused = true;

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        isPaused = true;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        isPaused = false;
        pauseMenuUI.SetActive(false);
    }
}
