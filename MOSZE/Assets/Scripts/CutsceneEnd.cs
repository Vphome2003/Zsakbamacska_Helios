using System.Collections;
using UnityEngine;

public class CutsceneEnd : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject Bullet;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public GameObject Bullet4;
    public GameObject Enemy;
    public GameObject Cutscene;
    public GameObject VictoryText;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Explosion.SetActive(false);
        Bullet.SetActive(false);
        Bullet2.SetActive(false);
        Bullet3.SetActive(false);
        Bullet4.SetActive(false);
        Enemy.SetActive(true);
        Cutscene.SetActive(false);
        VictoryText.SetActive(false);
        StartCoroutine(EndCinematic());
    }

    IEnumerator EndCinematic()
    {
        yield return new WaitForSeconds(1);
        Cutscene.SetActive(true);
        yield return new WaitForSeconds(5);
        Bullet.SetActive(true);
        Bullet2.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        Bullet3.SetActive(true);
        Bullet4.SetActive(true);
        yield return new WaitForSeconds(1.25f);
        Explosion.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        Bullet.SetActive(false);
        Bullet2.SetActive(false);
        Bullet3.SetActive(false);
        Bullet4.SetActive(false);
        Enemy.SetActive(false);
        yield return new WaitForSeconds(2f);
        VictoryText.SetActive(true);
    }
}
