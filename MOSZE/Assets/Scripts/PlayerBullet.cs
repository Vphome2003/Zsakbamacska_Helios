using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float life = 3f; //A tolteny elettartama

    void Awake()
    {
        Destroy(gameObject, life);  //Loves utan 3mp mulva torlodik az objektum ("life" valtozo szerint)
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))  //Ha eltalalja az "enemy" layerrel rendelkezo celpontot, deaktivalja az enemy-t es torolje a tolteny
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            if(collision.gameObject.layer == LayerMask.NameToLayer("Player")) //Ha eltalalja a jatekost
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
