using UnityEngine;

public class StaticScript : MonoBehaviour
{
    static public float PlayerHP = 1f;
    static public float HeliosHP = 1000f;

    void Start()
    {
        PlayerHP = 1f;
        HeliosHP = 1000f;
    }
}
