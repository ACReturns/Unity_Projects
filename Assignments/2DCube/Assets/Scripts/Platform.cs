using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<BoxFunctions>().OutOfBoundsPrint();
		string stringFromOutside = FindObjectOfType<BoxFunctions>().TestMethod(25);
        Debug.Log(stringFromOutside);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
