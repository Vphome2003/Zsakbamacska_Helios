using UnityEngine;

public class EnemyDead : MonoBehaviour
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
        if(!Enemy.activeInHierarchy)
        {
            StaticScript.EnemyKillCount++;
            Deactivate.SetActive(false);
        }
    }
}
