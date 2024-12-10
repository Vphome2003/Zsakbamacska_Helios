using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneChange : MonoBehaviour
{
    void Update()
    {
        if(StaticScript.EnemyKillCount == 7)
        {
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        if (StaticScript.PlayerHP == 1)
        {
            SceneManager.LoadScene("Lvl1Cutscene2");
        }
        else StopCoroutine(ChangeScene());
    }
}
