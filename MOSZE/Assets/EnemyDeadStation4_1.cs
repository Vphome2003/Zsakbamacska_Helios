using UnityEngine;

public class EnemyDeadStation4_1 : MonoBehaviour
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
            StaticScript.EnemyKillCount = StaticScript.EnemyKillCount + 3;
            StaticScript.Station4EnemyCount--;
            Deactivate.SetActive(false);
        }
    }
}
