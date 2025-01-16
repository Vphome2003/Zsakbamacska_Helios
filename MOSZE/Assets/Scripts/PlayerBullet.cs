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
            if(collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy1"))
            {
                StaticScript.BigEnemyHP1--;
                Destroy(gameObject);
            }
            else if(collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy2"))
            {
                StaticScript.BigEnemyHP2--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy3"))
            {
                StaticScript.BigEnemyHP3--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy4"))
            {
                StaticScript.BigEnemyHP4--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BigEnemy5"))
            {
                StaticScript.BigEnemyHP5--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun"))
            {
                StaticScript.GunHP--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun2"))
            {
                StaticScript.GunHP2--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun3"))
            {
                StaticScript.GunHP3--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun4"))
            {
                StaticScript.GunHP4--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun5"))
            {
                StaticScript.GunHP5--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun6"))
            {
                StaticScript.GunHP6--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun7"))
            {
                StaticScript.GunHP7--;
                Destroy(gameObject);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("BossGun8"))
            {
                StaticScript.GunHP8--;
                Destroy(gameObject);
            }
            else
            {
                if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) //Ha eltalalja a jatekost
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
}
