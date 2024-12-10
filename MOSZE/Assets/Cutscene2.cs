using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene2 : MonoBehaviour
{
    public GameObject BomberVoice;
    public GameObject BomberAnimation;
    public GameObject FadeOut;

    void Start()
    {
        BomberAnimation.SetActive(false);
        BomberVoice.SetActive(false);
        FadeOut.SetActive(false);
        StartCoroutine(Cutscene());
    }

    IEnumerator Cutscene()
    {
        yield return new WaitForSeconds(0.5f);
        BomberAnimation.SetActive(true);
        yield return new WaitForSeconds(1f);
        BomberVoice.SetActive(true);
        yield return new WaitForSeconds(3f);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Level1_2");
    }
}
