using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // 생성할 오브젝트
    public GameObject bulletPrefab;
    // 맞출 대상의 위치값 필요
    public Transform target;
    public float minRange;
    public float maxRange;
    private float firingSpeed;

    //private TurretTargetting _targetting;

    // Start is called before the first frame update
    void Start()
    {
        firingSpeed = Random.Range(minRange, maxRange);
    }

    public bool setupTurret;
    private float _elapsedTime;
    public float rotationNum;
    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            _elapsedTime += Time.deltaTime;

            transform.LookAt(target); // transform안 rotation이 포함, target을 player로 주면 포신이 돌아간다. rigidbody 추가필요

            if(_elapsedTime >= firingSpeed)
            {
                _elapsedTime = 0f;
                
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                // 생성된 탄알이 target을 바라보도록
                bullet.transform.LookAt(target);
                firingSpeed = Random.Range(minRange, maxRange);
            }

        }
        else
        {
            transform.Rotate(0f, 1f, 0f);
        }
        
    }
}
