using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    // 프로 퍼티
    public int point
    {
        get
        {
            return m_point;
        }

        //set을 안만들수도 있음, 버그 방지 가능
        //안쪽을 함수처럼 구현 가능
        set
        {
            if(value < 0)
            {
                m_point = 0;
            }
            else
            {
                m_point = value;
            }
        }
    }
    private int m_point = 0;
    
}
