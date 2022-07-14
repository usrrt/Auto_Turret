using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTargetting : MonoBehaviour
{
    public bool TargetOn{get; private set;}

    public Transform Target;

    // 각도 60, 거리 80
    public float Angle;

    public float distance = 40f;
    
    void Update()
    {
        // 코사인값 -1 ~ 1 반환 
        float cosValue = Mathf.Cos(Mathf.Deg2Rad * (Angle / 2));

        //Debug.Log($"dotValue: {dotValue}");

        // 타겟과 트리거 콜라이더의 거리 벡터
        Vector3 direction = Target.position - transform.position;
        //Debug.Log($"direction.magnitude: {direction.magnitude}");

        // 거리벡터의 크기와 지정한 거리크기 비교
        if(direction.magnitude <= distance)
        {
            // 벡터 내적으로 두 벡터 사이의 각도를 측정
            // z축과 타겟을 향한 벡터의 내적 
            if(Vector3.Dot(direction.normalized, transform.forward) > cosValue)
            {
                TargetOn = true;

            }
            else
            {
                TargetOn = false;
            }
        }
        else
        {
            TargetOn = false;
        }

    }

}
