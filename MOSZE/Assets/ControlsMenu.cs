using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    public GameObject MainMenuText;
    public GameObject ControlsMenuText;
    public GameObject LevelSelect;
    public void Back()
    {
        MainMenuText.SetActive(true);
        LevelSelect.SetActive(false);
        ControlsMenuText.SetActive(false);
    }
}
