using UnityEngine;

public class Resume : MonoBehaviour
{
    public Canvas menu;
    public Canvas crosshair;
    [SerializeField] TMPro.TMP_Dropdown dropdownpause;
    [SerializeField] TMPro.TMP_Dropdown dropdownplayagain;

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
        dropdownpause.onValueChanged.AddListener(checkdropdownvalue);
        dropdownpause.value = QualitySettings.GetQualityLevel();
        dropdownplayagain.onValueChanged.AddListener(checkdropdownvalue);
        dropdownplayagain.value = QualitySettings.GetQualityLevel();
    }

    public void MainMenu()
    {
        counter count = FindAnyObjectByType<counter>();
        if (PlayerPrefs.GetInt("kills") < count.deathcount)
        {
            PlayerPrefs.SetInt("kills", count.deathcount);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void playAgain()
    {
        counter count = FindAnyObjectByType<counter>();
        if (PlayerPrefs.GetInt("kills") < count.deathcount)
        {
            PlayerPrefs.SetInt("kills", count.deathcount);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    void checkdropdownvalue(int value)
    {
        QualitySettings.SetQualityLevel(value);
    }
}
