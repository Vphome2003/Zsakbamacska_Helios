using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartScene() 
    {
        StaticScript.PlayerHP = 1;
        StaticScript.HeliosHP = 1000;
        StaticScript.EnemyKillCount = 0;
        SceneManager.LoadScene("Level2");
    }
}
