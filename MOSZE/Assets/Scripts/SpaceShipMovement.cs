using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public bool throttle => Input.GetKey(KeyCode.W);  //Iranyitashoz billentyu inputok
    public bool breaking => Input.GetKey(KeyCode.S);
    public bool rotateRight => Input.GetKey(KeyCode.D);
    public bool rotateLeft => Input.GetKey(KeyCode.A);

    public float pitchPower, rollPower, yawPower, enginePower, shipSpeed, maxSpeed, minSpeed;  //mozgashoz tartozo valtozok
    private float activeRoll, activePitch, activeYaw;
    public float maxRotationSpeed;

    public string mouseXInputName, mouseYInputName;  //eger mozgatasahoz info

    public GameObject FPCam, TPCam; //kulso es belsonezet
    private bool isFPCam = true;

    private float mouseXInertia = 0f;  //kamera csuszasaval kapcsolatos valtozok
    private float mouseYInertia = 0f;
    public float inertiaDecay;

    public Transform bulletSpawnPoint1;  //lovessel kapcsolatos valtozok
    public Transform bulletSpawnPoint2;
    public GameObject bulletPrefab;
    public float bulletSpeed;

    private float lastShootTime = 0f;
    public float shootInterval;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  //kurzor eltuntetese kezdesnel
        FPCam.SetActive(true);  //belsonezet aktivalasa kezdesnel
        TPCam.SetActive(false);  //kulsonezet deaktivalasa kezdesnel
    }

    void Update()
    {
        transform.position += transform.forward * shipSpeed * Time.deltaTime;  //urhajo mozgasa

        if (shipSpeed < maxSpeed && throttle)
        {
            shipSpeed += enginePower * Time.deltaTime;
        }
        if (shipSpeed > minSpeed && breaking)
        {
            shipSpeed -= enginePower * Time.deltaTime;
        }
        if (rotateLeft)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rollPower);
        }
        if (rotateRight)
        {
            transform.Rotate(-Vector3.forward * Time.deltaTime * rollPower);
        }

        if (Input.GetKeyDown(KeyCode.V) && isFPCam)  //belso-kulso nezet allitasa
        {
            FPCam.SetActive(false);
            TPCam.SetActive(true);
            isFPCam = false;
        }
        else if (Input.GetKeyDown(KeyCode.V) && !isFPCam)
        {
            FPCam.SetActive(true);
            TPCam.SetActive(false);
            isFPCam = true;
        }

        float mouseX = Input.GetAxis(mouseXInputName) * Time.deltaTime * pitchPower;  //forgas az urhajoval
        float mouseY = Input.GetAxis(mouseYInputName) * Time.deltaTime * yawPower;

        mouseX = Mathf.Clamp(mouseX, -maxRotationSpeed * Time.deltaTime, maxRotationSpeed * Time.deltaTime);
        mouseY = Mathf.Clamp(mouseY, -maxRotationSpeed * Time.deltaTime, maxRotationSpeed * Time.deltaTime);

        if (mouseX != 0 || mouseY != 0)  //csuszasa az iranyitasnak
        {
            mouseXInertia = mouseX;
            mouseYInertia = mouseY;
        }
        else
        {
            mouseXInertia = Mathf.Lerp(mouseXInertia, 0, inertiaDecay * Time.deltaTime);
            mouseYInertia = Mathf.Lerp(mouseYInertia, 0, inertiaDecay * Time.deltaTime);
        }

        mouseXInertia = Mathf.Clamp(mouseXInertia, -maxRotationSpeed * Time.deltaTime, maxRotationSpeed * Time.deltaTime);
        mouseYInertia = Mathf.Clamp(mouseYInertia, -maxRotationSpeed * Time.deltaTime, maxRotationSpeed * Time.deltaTime);

        transform.Rotate(-Vector3.right * mouseYInertia);
        transform.Rotate(Vector3.up * mouseXInertia);

        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= lastShootTime + shootInterval)  //tolteny lovese
        {
            lastShootTime = Time.time;

            var bullet1 = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
            bullet1.GetComponent<Rigidbody>().linearVelocity = bulletSpawnPoint1.forward * bulletSpeed;
            var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
            bullet2.GetComponent<Rigidbody>().linearVelocity = bulletSpawnPoint2.forward * bulletSpeed;
        }
    }
}
