using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject bulletPrefabs;
    public GameObject EnemyPivot;
    public Transform firePoint;
    public float fireRate;
    public float nextFireTime;

    private Rigidbody rb;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        GameObject Temp = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            player = Temp.transform;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(player.position , transform.position) > 5.0f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }

        Vector3 tagetDirection = (player.position - EnemyPivot.transform.position).normalized;
        Quaternion targerRotation = Quaternion.LookRotation(tagetDirection);
        EnemyPivot.transform.rotation = Quaternion.Lerp(EnemyPivot.transform.rotation, targerRotation, Time.deltaTime);

        if(Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefabs, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjecttileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjecttileMove>().projectiletype = ProjecttileMove.PROJECTILETYPE.ENEMY;

        }




    }
}
