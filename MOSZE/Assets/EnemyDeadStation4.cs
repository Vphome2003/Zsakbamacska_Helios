using UnityEngine;

public class EnemyDeadStation4 : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Deactivate;

    void Start()
    {
        Deactivate.SetActive(true);
        Enemy.SetActive(true);
    }

    void Update()
    {
        if (!Enemy.activeInHierarchy)
        {
            StaticScript.EnemyKillCount++;
            StaticScript.Station4EnemyCount--;
            Deactivate.SetActive(false);
        }
        if (StaticScript.Station4Checkpoint == true)
        {
            Enemy.SetActive(false);
        }
    }
}
