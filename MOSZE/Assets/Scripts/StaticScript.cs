using UnityEngine;

public class StaticScript : MonoBehaviour
{
    static public float PlayerHP = 1f;
    static public float HeliosHP = 1000f;
    static public float EnemyKillCount = 0;

    static public float Station1EnemyCount = 10;
    static public bool Station1Checkpoint = false;

    static public float Station2EnemyCount = 3;
    static public bool Station2Checkpoint = false;
    static public float BigEnemyHP1 = 30;
    static public float BigEnemyHP2 = 30;
    static public float BigEnemyHP3 = 30;

    static public float Station3EnemyCount = 10;
    static public bool Station3Checkpoint = false;

    static public float Station4EnemyCount = 14;
    static public bool Station4Checkpoint = false;
    static public float BigEnemyHP4 = 30;
    static public float BigEnemyHP5 = 30;

    void Start()
    {
        PlayerHP = 1f;
        HeliosHP = 1000f;
        EnemyKillCount = 0;
    }
}
