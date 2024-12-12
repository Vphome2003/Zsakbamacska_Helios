using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationScript : MonoBehaviour
{
    public GameObject FadeAnimation;
    public GameObject HeliosVoiceLine;
    public GameObject CameraAnimation;
    public GameObject FadeOutAnimation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        FadeOutAnimation.SetActive(false);
        HeliosVoiceLine.SetActive(false);
        FadeAnimation.SetActive(false);
        CameraAnimation.SetActive(false);
        StartCoroutine(StartAnimation());
    }

    IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(2f);
        FadeAnimation.SetActive(true);
        yield return new WaitForSeconds(3f);
        HeliosVoiceLine.SetActive(true);
        yield return new WaitForSeconds(3f);
        CameraAnimation.SetActive(true);
        yield return new WaitForSeconds(8.5f);
        FadeOutAnimation.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Level1");
    }

}
