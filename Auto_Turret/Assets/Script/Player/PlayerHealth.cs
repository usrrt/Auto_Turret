using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private void Die() => gameObject.SetActive(false);

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            //Die();
        }
    }
}