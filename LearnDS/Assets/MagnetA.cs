
using System.Collections.Generic;
using UnityEngine;
public class MagnetA: MonoBehaviour
{
    public float forceFactor = 200f;
    List<Rigidbody> Container = new List<Rigidbody>();
    Transform magnetPoint;

    void Start() 
    {
        magnetPoint = GetComponent<Transform>();
    }

    void FixedUpdate() 
    {
        foreach (Rigidbody Con in Container)
        {
            Con.AddForce((magnetPoint.position) * forceFactor * Time.fixedDeltaTime);
        }

    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Container"))
            Container.Add(other.GetComponent<Rigidbody>());
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Container"))
            Container.Remove(other.GetComponent<Rigidbody>());
    }
    
}