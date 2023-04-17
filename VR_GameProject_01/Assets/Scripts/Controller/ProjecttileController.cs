using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecttileController : MonoBehaviour
{
    public GameObject Projecttile;



    public void FireProjecttile()
    {
        GameObject temp = (GameObject)Instantiate(Projecttile);

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProjecttileMove>().launchDirection = transform.forward;

        Destroy(temp, 10.0f);


    }
}
