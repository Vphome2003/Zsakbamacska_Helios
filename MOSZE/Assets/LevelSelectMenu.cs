using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameObject Level2Locked;
    public GameObject Level2Unlocked;
    public GameObject Level3Locked;
    public GameObject Level3Unlocked;
    void Update()
    {
        if (StaticScript.Level2Unlocked == false)
        {
            Level2Locked.SetActive(true);
            Level2Unlocked.SetActive(false);
        }
        else
        {
            Level2Unlocked.SetActive(true);
            Level2Locked.SetActive(false);
        }
        if (StaticScript.Level3Unlocked == false)
        {
            Level3Locked.SetActive(true);
            Level3Unlocked.SetActive(false);
        }
        else
        {
            Level3Unlocked.SetActive(true);
            Level3Locked.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            StaticScript.Level2Unlocked = true;
            StaticScript.Level3Unlocked = true;
        }
    }

    public void Level1()
    {
        SceneManager.LoadScene(4);
    }
    public void Level2()
    {
        SceneManager.LoadScene(3);
    }
    public void Level3()
    {
        SceneManager.LoadScene(8);
    }
}
