using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pointlvl3 : MonoBehaviour
{
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Gun3;
    public GameObject Gun4;
    public GameObject Gun5;
    public GameObject Gun6;
    public GameObject Gun7;
    public GameObject Gun8;

    public GameObject Enemy;
    public GameObject Enemy2; 
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;

    void Start()
    {
        StaticScript.EnemyKillCount = 47f;
        StaticScript.GunHP = 30;
        StaticScript.GunHP2 = 30;
        StaticScript.GunHP3 = 30;
        StaticScript.GunHP4 = 30;
        StaticScript.GunHP5 = 30;
        StaticScript.GunHP6 = 30;
        StaticScript.GunHP7 = 30;
        StaticScript.GunHP8 = 30;
        Gun1.SetActive(true);
        Gun2.SetActive(true);
        Gun3.SetActive(true);
        Gun4.SetActive(true);
        Gun5.SetActive(true);
        Gun6.SetActive(true);
        Gun7.SetActive(true);
        Gun8.SetActive(true);
        Enemy.SetActive(true);
        Enemy2.SetActive(true);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
        Enemy5.SetActive(true);
        Enemy6.SetActive(true);
        Enemy7.SetActive(true);
        Enemy8.SetActive(true);
        Enemy9.SetActive(true);
        Enemy10.SetActive(true);
    }

    void Update()
    {
        if(StaticScript.GunHP <= 0)
        {
            StaticScript.GunHP = 0;
            Gun1.SetActive(false);
        }
        if (StaticScript.GunHP2 <= 0)
        {
            StaticScript.GunHP2 = 0;
            Gun2.SetActive(false);
        }
        if (StaticScript.GunHP3 <= 0)
        {
            StaticScript.GunHP3 = 0;
            Gun3.SetActive(false);
        }
        if (StaticScript.GunHP4 <= 0)
        {
            StaticScript.GunHP4 = 0;
            Gun4.SetActive(false);
        }
        if (StaticScript.GunHP5 <= 0)
        {
            StaticScript.GunHP5 = 0;
            Gun5.SetActive(false);
        }
        if (StaticScript.GunHP6 <= 0)
        {
            StaticScript.GunHP6 = 0;
            Gun6.SetActive(false);
        }
        if (StaticScript.GunHP7 <= 0)
        {
            StaticScript.GunHP7 = 0;
            Gun7.SetActive(false);
        }
        if (StaticScript.GunHP8 <= 0)
        {
            StaticScript.GunHP8 = 0;
            Gun8.SetActive(false);
        }

        if(!Gun1.activeInHierarchy &&  !Gun2.activeInHierarchy && !Gun3.activeInHierarchy && !Gun3.activeInHierarchy && !Gun4.activeInHierarchy
            && !Gun5.activeInHierarchy && !Gun6.activeInHierarchy && !Gun7.activeInHierarchy && !Gun8.activeInHierarchy && !Enemy.activeInHierarchy
            && !Enemy2.activeInHierarchy && !Enemy3.activeInHierarchy && !Enemy4.activeInHierarchy && !Enemy5.activeInHierarchy && !Enemy6.activeInHierarchy
            && !Enemy7.activeInHierarchy && !Enemy8.activeInHierarchy && !Enemy9.activeInHierarchy && !Enemy10.activeInHierarchy)
        {
            StartCoroutine(EndCutscene());
        }
    }

    IEnumerator EndCutscene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(11);
    }

}
