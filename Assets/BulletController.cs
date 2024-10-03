using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public Transform bulletPosition;
    private float timeBtwShots;
    public float startTimeBtwShots;
    void Start()
    {
        
    }

    void Update()
    {

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, bulletPosition.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;   
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }
}
