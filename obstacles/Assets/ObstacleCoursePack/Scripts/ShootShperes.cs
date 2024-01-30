using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootShperes : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float timebetweenShot;
    [SerializeField] private string directions;

    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        Destroy(bulletPrefab, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (counter > timebetweenShot)
        {
            counter = 0;
            GameObject bullet = Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            BulletMovement bulletMovement = bullet.GetComponent<BulletMovement>();
            bulletMovement.SetDirection(directions);
            Destroy(bullet, 5f);
        }
    }
}
