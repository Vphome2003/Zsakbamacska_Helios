using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartlvl3_1 : MonoBehaviour
{    
    public void RestartSceneLVL3_1()
    {
        StaticScript.PlayerHP = 1;
        StaticScript.GunHP = 30;
        StaticScript.GunHP2 = 30;
        StaticScript.GunHP3 = 30;
        StaticScript.GunHP4 = 30;
        StaticScript.GunHP5 = 30;
        StaticScript.GunHP6 = 30;
        StaticScript.GunHP7 = 30;
        StaticScript.GunHP8 = 30;
        SceneManager.LoadScene(9);
    }
}
