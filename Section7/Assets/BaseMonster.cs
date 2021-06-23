using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour
{
    // 추상 클래스는 어느 정도 구현이 가능
    public float damage = 100f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    public abstract void Attack(); 
    // 상속받으면 강제로 만들어야 함.
    // virtual은 강제가 아님.

    //public override void Attack(){}
}
