using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTargetting : MonoBehaviour
{
    public bool TargetOn{get; private set;}

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TargetOn = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        TargetOn = false;

    }
}
