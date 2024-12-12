using System.Collections;
using UnityEngine;

public class EnemyAI2 : MonoBehaviour
{  
    public GameObject bombPrefab;
    public Transform bombSpawnPoint;
    public float bombSpeed;

    void Start()
    {
        Bomb();
    }
    void Bomb()
    {
        StartCoroutine(Bombing());
    }

    IEnumerator Bombing()
    {
        yield return new WaitForSeconds(6f);
        var bomb = Instantiate(bombPrefab, bombSpawnPoint.position, bombSpawnPoint.rotation);
        bomb.GetComponent<Rigidbody>().linearVelocity = bombSpawnPoint.forward * bombSpeed;
        Bomb();
    }
}
