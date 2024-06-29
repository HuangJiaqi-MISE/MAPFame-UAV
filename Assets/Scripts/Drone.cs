using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UAV_Z_Control(float Z_number)
    {
        gameObject.transform.position = new Vector3(7, 4, Z_number);
    }
}
