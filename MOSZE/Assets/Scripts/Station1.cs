using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class Station1 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;
    public GameObject Enemy10;
    public GameObject Enemy11;

    private bool EngineOpen = false;

    public GameObject Engine1;
    public GameObject Engine2;
    public GameObject Engine3;
    public GameObject Engine4;

    public GameObject Pipe;

    public Transform player;
    public float range = 10f;

    public GameObject EnemyNerby;

    public TextMeshProUGUI NerbyText;

    void Start()
    {
        StaticScript.Station1EnemyCount = 10;
        if(StaticScript.Station1Checkpoint == true)
        {
            Pipe.SetActive(false); Enemy5.SetActive(false); Enemy6.SetActive(false); Enemy7.SetActive(false); Enemy8.SetActive(false); Enemy9.SetActive(false);
            Enemy1.SetActive(false); Enemy3.SetActive(false); Enemy4.SetActive(false); Enemy10.SetActive(false); Enemy11.SetActive(false);
            Engine1.SetActive(false); Engine2.SetActive(false); EngineOpen = true; Engine3.SetActive(false); Engine4.SetActive(false);
        }
    }

    void Update()
    {
        NerbyText.text = ("Enemies Nerby: " + StaticScript.Station1EnemyCount);

        if(!Enemy1.activeInHierarchy && !Enemy3.activeInHierarchy &&
           !Enemy4.activeInHierarchy && !Enemy5.activeInHierarchy && !Enemy6.activeInHierarchy &&
           !Enemy7.activeInHierarchy && !Enemy8.activeInHierarchy && !Enemy9.activeInHierarchy &&
           !Enemy10.activeInHierarchy && !Enemy11.activeInHierarchy && !EngineOpen)
        {
            Engine1.SetActive(true);
            Engine2.SetActive(true);
            Engine3.SetActive(true);
            Engine4.SetActive(true);
            EngineOpen = true;
        }

        if(EngineOpen && !Engine1.activeInHierarchy && !Engine2.activeInHierarchy && !Engine3.activeInHierarchy
           && !Engine4.activeInHierarchy)
        {
            Pipe.SetActive(false);
            StaticScript.Station1Checkpoint = true;
        }

        float distanceToPlayer = Vector3.Distance(player.position, transform.position);  //jatekos tavolsaga

        if (distanceToPlayer <= range)  //ha kozel van a játékos
        {
            EnemyNerby.SetActive(true);
        }
        else
        {
            EnemyNerby.SetActive(false);
        }
    }

    void OnDrawGizmosSelected() //segitseg editor mode-ban, hogy lassam az enemy range-t
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
