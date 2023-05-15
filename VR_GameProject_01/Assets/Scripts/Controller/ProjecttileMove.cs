using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecttileMove : MonoBehaviour
{
    public enum PROJECTILETYPE
    {
        PLAYER,
        ENEMY
    }
    public PROJECTILETYPE projectiletype = PROJECTILETYPE.PLAYER;
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "Monster" && projectiletype == PROJECTILETYPE.PLAYER)
        {
            collision.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "Player" && projectiletype == PROJECTILETYPE.PLAYER)
        {
            collision.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }
    } 


    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }
}
