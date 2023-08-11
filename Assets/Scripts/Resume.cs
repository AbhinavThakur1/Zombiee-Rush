using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public Canvas menu;
    public Canvas crosshair;
    [SerializeField] TMPro.TMP_Dropdown dropdown;
    public void resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        menu.enabled = false;
        crosshair.enabled = true;
    }

    private void Start()
    {
        dropdown.value = checkdropdownvalue();
    }

    private void Update()
    {
        if (dropdown.value == 0)
        {
            dataTransfer.health = 200;
        }
        else if (dropdown.value == 1)
        {
            dataTransfer.health = 300;
        }
        else if (dropdown.value == 2)
        {
            dataTransfer.health = 400;
        }
        else if (dropdown.value == 3)
        {
            dataTransfer.health = 500;
        }
        else if (dropdown.value == 4)
        {
            dataTransfer.health = 700;
        }
    }

    public void MainMenu()
    {
        counter count = FindAnyObjectByType<counter>();
        SaveScore savescore = FindAnyObjectByType<SaveScore>();
        if (savescore.Load() < count.deathcount)
        {
            savescore.save(count.deathcount);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(0); 
    }

    public void playAgain()
    {
        counter count = FindAnyObjectByType<counter>();
        SaveScore savescore = FindAnyObjectByType<SaveScore>();
        if (savescore.Load() < count.deathcount)
        {
            savescore.save(count.deathcount);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    int checkdropdownvalue()
    {
        if(dataTransfer.health == 200)
        {
            return 0;
        }
        else if (dataTransfer.health == 300)
        {
            return 1;
        }
        else if (dataTransfer.health == 400)
        {
            return 2;
        }
        else if (dataTransfer.health == 500)
        {
            return 3;
        }
        else if (dataTransfer.health == 700)
        {
            return 4;
        }
        else
        {
            return 0;
        }
    }
}
