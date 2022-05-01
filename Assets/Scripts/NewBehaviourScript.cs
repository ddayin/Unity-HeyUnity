using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 데이터 타입 별로 변수를 선언하고 초기화한다.
        int i = 1;
        float f = 1.0f;
        string s = "Hello, world!";
        bool b = false;
        
        // 데이터 타입의 크기를 알아보자.
        Debug.Log("int = " + sizeof(int));
        Debug.Log("float = " + sizeof(float));
        //Debug.Log("string = " + sizeof(string));
        Debug.Log("bool = " + sizeof(bool));

        // 각기 다른 타입의 변수 값을 출력해 보자.
        Debug.Log("=======================");
        Debug.Log("i = " + i);
        Debug.Log("f = " + f);
        Debug.Log("s = " + s);
        Debug.Log("b = " + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}