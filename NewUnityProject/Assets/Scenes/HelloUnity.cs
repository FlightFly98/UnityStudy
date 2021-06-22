using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

        int age = 24;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);

        float height = 173.1f;

        double pi = 3.14;

        bool isBoy = true;
        bool isGirl = false;

        char grade = 'A';
        string moveTitle = "러브라이브";
        
        Debug.Log("내 나이는!: " + age);
        Debug.Log("내가 가진 돈은!: " + money);
        Debug.Log("키: " + height);
        Debug.Log("성적: " + grade);
        Debug.Log(moveTitle);

        var myName = "I_Seungju";
    }
}
