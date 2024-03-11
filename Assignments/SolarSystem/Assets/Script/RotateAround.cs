using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public int speed;

    void Start()
    {
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* RotateAround takes 3 arguments:
        - The vector to rotate around
        - A vector that axis to rotate around
        - The degrees to rotate, in this case the speed per second 
        */
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
