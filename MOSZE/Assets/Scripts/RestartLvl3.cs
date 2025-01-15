using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLvl3 : MonoBehaviour
{
    public void RestartScene()
    {
        StaticScript.PlayerHP = 1;
        StaticScript.HeliosHP = 1000;
        StaticScript.EnemyKillCount = 0;
        StaticScript.BigEnemyHP1 = 30;
        StaticScript.BigEnemyHP2 = 30;
        StaticScript.BigEnemyHP3 = 30;
        StaticScript.BigEnemyHP4 = 30;
        StaticScript.BigEnemyHP5 = 30;
        SceneManager.LoadScene("Level3");
    }
}
