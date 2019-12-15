using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDiamond : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject diamondPreFab;
    void Start()
    {
        
    }


    void Update()
    {
        spawnObject();
    }

    public void spawnObject()
    {
       // Debug.Log("in spawn function");

        Vector3 position = center + new Vector3(Random.Range(-size.x, size.x), Random.Range(-size.y, size.y), Random.Range(-size.z, size.z));
        Instantiate(diamondPreFab, position, Quaternion.identity);

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
        
    }
}
