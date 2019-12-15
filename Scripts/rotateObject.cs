using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    
    private Vector3 target = new Vector3(.1f, .1f, .1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target,Vector3.up, 10* Time.deltaTime);
    }
}
