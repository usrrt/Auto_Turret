using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // 플레이어 좌표 선언
    public float X {get; private set;}
    public float Y {get; private set;}
   

    // Update is called once per frame
    void Update()
    {
        // 좌표 매 프레임 마다 초기화
        X = Y = 0f;

        // 입력값 저장
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

    }
}
