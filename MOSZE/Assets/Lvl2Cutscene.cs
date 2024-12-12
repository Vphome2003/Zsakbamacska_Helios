using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl2Cutscene : MonoBehaviour
{
    public GameObject FadeIn;
    public GameObject FadeOut;
    public GameObject StartAnimation;
    public GameObject CameraAnimation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        FadeIn.SetActive(false);
        FadeOut.SetActive(false);
        StartAnimation.SetActive(false);
        CameraAnimation.SetActive(false);
        StartCoroutine(AnimationStart());
    }

    IEnumerator AnimationStart()
    {
        yield return new WaitForSeconds(1.5f);
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(2f);
        StartAnimation.SetActive(true);
        yield return new WaitForSeconds(4f);
        CameraAnimation.SetActive(true);
        yield return new WaitForSeconds(5f);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Level2");
    }
}
