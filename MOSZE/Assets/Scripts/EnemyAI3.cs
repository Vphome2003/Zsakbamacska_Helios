using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyAI3 : MonoBehaviour
{
    public Transform player;
    public float range = 10f;
    private bool inRange = false;

    public GameObject bulletPrefab;  //lovessel kapcsolatos valtozok
    public Transform bulletSpawnPoint1;
    public Transform bulletSpawnPoint2;
    public float bulletSpeed;

    void Start()
    {
        Shoot();
    }
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);  //jatekos tavolsaga

        if (distanceToPlayer <= range)  //ha kozel van a játékos
        {
            LookAtTarget(player);  //nezzen a jatekosra
            inRange = true;
        }
        else
        {
            inRange = false;
        }
    }

    void LookAtTarget(Transform target)  //celpont valasztasa
    {
        Vector3 direction = target.position - transform.position;

        if (direction.magnitude > 0.01f)  //forduljon ra a celpontra
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }

    void OnDrawGizmosSelected()  //segitseg editor mode-ban, hogy lassam az enemy range-t
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    void Shoot()
    {
        StartCoroutine(Shooting());  //kezdje el a loves fazist
    }

    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(1f);   //1mp mulva lojjon megallas nelkul
        if (inRange)
        {
            var bullet1 = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
            bullet1.GetComponent<Rigidbody>().linearVelocity = bulletSpawnPoint1.forward * bulletSpeed;
            var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
            bullet2.GetComponent<Rigidbody>().linearVelocity = bulletSpawnPoint2.forward * bulletSpeed;
        }
        Shoot(); //kezdodjon minden elorol
    }
}
