using UnityEditor.TextCore.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DeathCam : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject NewCanvas;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI OtherScore;
    void Update()
    {
        Canvas.SetActive(false);
        NewCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Score.text = OtherScore.text;
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
