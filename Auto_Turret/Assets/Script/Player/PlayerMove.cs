using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;


    private PlayerInput _input;
    private Rigidbody _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // input값 할당위해 컴포넌트 가져오기
        _input = GetComponent<PlayerInput>();

        // rigidbody 컴포넌트 가져오기
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 이동방향에 따라 좌표값 새로 할당 velocity 사용
        float xSpeed = _input.X * Speed;
        float ySpeed = _input.Y * Speed;
        _rigidBody.velocity = new Vector3(xSpeed, 0f, ySpeed);
        
    }
}
