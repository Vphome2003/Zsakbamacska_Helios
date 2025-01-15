using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class Station2 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    private bool EngineOpen = false;

    public GameObject Engine1;
    public GameObject Engine2;
    public GameObject Engine3;
    public GameObject Engine4;

    public GameObject Pipe;

    public Transform player;
    public float range = 1200f;

    public GameObject EnemyNerby;
    public TextMeshProUGUI NerbyText;

    public TextMeshProUGUI Enemy1HP;
    public TextMeshProUGUI Enemy2HP;
    public TextMeshProUGUI Enemy3HP; 

    void Start()
    {
        StaticScript.Station2EnemyCount = 3;
        if (StaticScript.Station2Checkpoint == true)
        {
            Pipe.SetActive(false);  StaticScript.BigEnemyHP1 = 0f; StaticScript.BigEnemyHP2 = 0f; StaticScript.BigEnemyHP3 = 0f;
            Engine1.SetActive(false); Engine2.SetActive(false); EngineOpen = true; Engine3.SetActive(false); Engine4.SetActive(false);
        }
    }

    void Update()
    {
        NerbyText.text = ("Enemies Nerby: " + StaticScript.Station2EnemyCount);
        Enemy1HP.text = ("Enemy HP: " + StaticScript.BigEnemyHP1);
        Enemy2HP.text = ("Enemy HP: " + StaticScript.BigEnemyHP2);
        Enemy3HP.text = ("Enemy HP: " + StaticScript.BigEnemyHP3);

        if(StaticScript.BigEnemyHP1 <= 0)
        {
            StaticScript.BigEnemyHP1 = 0f;
            Enemy1.SetActive(false);
        }
        if (StaticScript.BigEnemyHP2 <= 0)
        {
            StaticScript.BigEnemyHP2 = 0f;
            Enemy2.SetActive(false);
        }
        if (StaticScript.BigEnemyHP3 <= 0)
        {
            StaticScript.BigEnemyHP3 = 0f;
            Enemy3.SetActive(false);
        }

        if (!Enemy1.activeInHierarchy && !Enemy3.activeInHierarchy &&
           !Enemy2.activeInHierarchy && !EngineOpen)
        {
            Engine1.SetActive(true);
            Engine2.SetActive(true);
            Engine3.SetActive(true);
            Engine4.SetActive(true);
            EngineOpen = true;
        }

        if (EngineOpen && !Engine1.activeInHierarchy && !Engine2.activeInHierarchy && !Engine3.activeInHierarchy
           && !Engine4.activeInHierarchy)
        {
            Pipe.SetActive(false);
            StaticScript.Station2Checkpoint = true;
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
