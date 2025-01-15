using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl3Cutscene3 : MonoBehaviour
{
    public GameObject Sphere;
    void Start()
    {
        Sphere.SetActive(true);
        StartCoroutine(Shield());
    }

    IEnumerator Shield()
    {
        yield return new WaitForSeconds(2f);
        Sphere.SetActive(false);
    }
}
