using Unity.VisualScripting;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuText;
    public GameObject ControlsText;
    public GameObject LevelSelect;
    public void PlayGame()
    {
        LevelSelect.SetActive(true);
        MainMenuText.SetActive(false);
    }
    public void Controls()
    {
        ControlsText.SetActive(true);
        MainMenuText.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
