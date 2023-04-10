using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Tile001;
   
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(Tile001);
                temp.transform.position = new Vector3(i, 0, j);
            }          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
