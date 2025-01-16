using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1EndScene : MonoBehaviour
{
    public GameObject EndCam;
    public GameObject Player;
    public GameObject Canvas;
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;

    void Start()
    {
        EndCam.SetActive(false);
    }

    void Update()
    {
        if(!Enemy.activeInHierarchy && !Enemy2.activeInHierarchy && !Enemy3.activeInHierarchy && !Enemy4.activeInHierarchy && !Enemy5.activeInHierarchy)
        {
            Player.SetActive(false);
            EndCam.SetActive(true);
            Canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    public void BackToMenu()
    {
        StaticScript.Level2Unlocked = true;
        SceneManager.LoadScene(0);
    }
}
