using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayExit : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI text;
    [SerializeField] TMPro.TMP_Dropdown dropdown;
    public int Score = 0; 
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        try
        {
            int score = FindAnyObjectByType<SaveScore>().Load();
            text.text = "Most Kills:- " + score.ToString();
        }
        catch
        {
            text.text = 0.ToString();
        }
        if (dropdown.value == 0)
        {
            dataTransfer.health = 200;
        }else if(dropdown.value == 1)
        {
            dataTransfer.health = 300;
        }
        else if(dropdown.value == 2)
        {
            dataTransfer.health = 400;
        }
        else if(dropdown.value == 3)
        {
            dataTransfer.health = 500;
        }
        else if(dropdown.value == 4)
        {
            dataTransfer.health = 700;
        }
    }

    public void exit()
    {
        Application.Quit();
    }
}
