using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2EndScene : MonoBehaviour
{
    public GameObject EndCam;
    public GameObject Player;
    public GameObject Canvas;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;
    public GameObject Enemy11;
    public GameObject Enemy12;
    public GameObject Enemy13;
    public GameObject Enemy14;
    public GameObject Enemy15;
    void Update()
    {
        if(!Enemy1.activeInHierarchy && !Enemy2.activeInHierarchy && !Enemy3.activeInHierarchy && !Enemy4.activeInHierarchy && !Enemy5.activeInHierarchy && !Enemy6.activeInHierarchy
            && !Enemy7.activeInHierarchy && !Enemy8.activeInHierarchy && !Enemy9.activeInHierarchy && !Enemy10.activeInHierarchy && !Enemy11.activeInHierarchy
            && !Enemy12.activeInHierarchy && !Enemy13.activeInHierarchy && !Enemy14.activeInHierarchy && !Enemy15.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.Confined;
            EndCam.SetActive(true);
            Player.SetActive(false);
            Canvas.SetActive(false);
        }
    }

    void Start()
    {
        EndCam.SetActive(false);
    }

    public void BackToMenu()
    {
        StaticScript.Level3Unlocked = true;
        SceneManager.LoadScene(0);
    }
}
