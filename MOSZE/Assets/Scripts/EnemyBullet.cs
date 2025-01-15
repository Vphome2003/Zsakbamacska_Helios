using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float life = 3f; //A tolteny elettartama

    void Awake()
    {
        Destroy(gameObject, life);  //Loves utan 3mp mulva torlodik az objektum ("life" valtozo szerint)
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obsticle"))  //Ha eltalalja az "Obsticle" layerrel rendelkezo celpontot, torolje a tolteny
        {
            StaticScript.HeliosHP = StaticScript.HeliosHP - 1f;
            Destroy(gameObject);
        }
        else
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy") || collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy1") || collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy2") || collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy3") || collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy4") || collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy5")) //Ha eltalal egy masik ellenfelet
            {
                //Semmit ne csinaljon
            }
            else 
            {
                if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))  //ha eltalalja a playert, haljon meg a player
                {
                    StaticScript.PlayerHP = StaticScript.PlayerHP - 1f;
                    Destroy(gameObject);
                }
                else
                {
                    Destroy(gameObject);  //Ha barmi mast talal el, csak torolje a toltenyt
                }                
            }
        }
    }
}
