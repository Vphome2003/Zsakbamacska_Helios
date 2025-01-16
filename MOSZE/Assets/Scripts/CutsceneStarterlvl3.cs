using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneStarterlvl3 : MonoBehaviour
{
    public GameObject Pipe1;
    public GameObject Pipe2;
    public GameObject Pipe3;
    public GameObject Pipe4;

    void Update()
    {
        if(!Pipe1.activeInHierarchy && !Pipe2.activeInHierarchy && !Pipe3.activeInHierarchy && !Pipe4.activeInHierarchy)
        {
            StartCoroutine(StartSwitch());
        }
    }

    IEnumerator StartSwitch()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(9);
    }
}
