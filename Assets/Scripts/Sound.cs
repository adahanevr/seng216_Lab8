using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public GameObject car;
    
    void Update()
    {
        transform.RotateAround(
            car.transform.position,
            car.transform.up,
            100*Time.deltaTime
        );
    }
}
