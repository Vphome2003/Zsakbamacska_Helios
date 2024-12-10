using UnityEngine;

public class StaticScript : MonoBehaviour
{
    static public float PlayerHP = 1f;
    static public float HeliosHP = 1000f;
    static public float EnemyKillCount = 0;

    void Start()
    {
        PlayerHP = 1f;
        HeliosHP = 1000f;
        EnemyKillCount = 0;
    }
}
