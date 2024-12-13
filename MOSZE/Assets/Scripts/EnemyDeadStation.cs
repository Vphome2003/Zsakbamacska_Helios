using UnityEngine;

public class EnemyDeadStation : MonoBehaviour
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
            StaticScript.Station1EnemyCount--;
            Deactivate.SetActive(false);
        }
    }
}
