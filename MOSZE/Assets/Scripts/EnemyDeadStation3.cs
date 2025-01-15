using UnityEngine;

public class EnemyDeadStation3 : MonoBehaviour
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
            StaticScript.Station3EnemyCount--;
            Deactivate.SetActive(false);
        }
        if(StaticScript.Station3Checkpoint == true)
        {
            Enemy.SetActive(false);
        }
    }
}
