using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl3Cutscene : MonoBehaviour
{
    public GameObject FadeIn;
    public GameObject FadeOut;
    public GameObject StartAnimation;
    public GameObject Camera1;
    public GameObject Camera2;

    void Start()
    {
        FadeIn.SetActive(false);
        FadeOut.SetActive(false);
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        StartAnimation.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(AnimationStart());
    }

    IEnumerator AnimationStart()
    {        
        yield return new WaitForSeconds(2f);
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(2f);
        StartAnimation.SetActive(true);
        yield return new WaitForSeconds(4f);
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Level3");
    }
}
