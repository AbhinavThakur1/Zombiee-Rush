using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayExit : MonoBehaviour
{

    [SerializeField] TMPro.TextMeshProUGUI text;
    [SerializeField] TMPro.TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown.onValueChanged.AddListener(checkdropdownvalue);
        dropdown.value = QualitySettings.GetQualityLevel();
        text.text = "Most Kills- " + PlayerPrefs.GetInt("kills");
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    void checkdropdownvalue(int value)
    {
        QualitySettings.SetQualityLevel(value);
    }

    public void exit()
    {
        Application.Quit();
    }

}
