using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("hello" + name);
    }

    int Add(int a , int b)
    {
        int c = a + b;
        return c;
    }

    // Start is called before the first frame update
    void Start()
    {
        SayHello();
        SayHello();
        CallName("Tom");
        CallName("SAM");
        int answer = Add(2, 5);
        Debug.Log(answer);
    }

    
}
