using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCam : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject NewCanvas;
    void Update()
    {
        Canvas.SetActive(false);
        NewCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    void Start()
    {
        Canvas.SetActive(true);
        NewCanvas.SetActive(false);
    }

    public void Restart()
    {
        StaticScript.PlayerHP = 1;
        StaticScript.HeliosHP = 1000;
        StaticScript.EnemyKillCount = 0;
        SceneManager.LoadScene("Level1");
    }

}
