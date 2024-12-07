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
            Destroy(gameObject);
        }
        else
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy")) //Ha eltalal egy masik ellenfelet
            {
                //Semmit ne csinaljon
            }
            else
            {
                Destroy(gameObject);  //Ha barmi mast talal el, csak torolje a toltenyt
            }
        }
    }
}
