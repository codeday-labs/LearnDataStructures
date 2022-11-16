using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private Rigidbody CubeRigidBody;
    public GameObject Magnet;


    // Start 
    void Start()
    {
        CubeRigidBody = this.GetComponent<Rigidbody>();
    }

    // Update  
    void Update()
    {
        FollowMagnet();
        FaceMagnet();
    }


    // cube follow the magnet
    void FollowMagnet()
    {
        // cube follows magnet
        float strength = 100f; // magnet strength 
        Vector3 DirectionToMagnet = (Magnet.transform.position - transform.position).normalized;
        CubeRigidBody.AddForce(DirectionToMagnet * strength, ForceMode.Force);
    }

    // face the magnet
    void FaceMagnet()
    {
        Vector3 DirectionToMagnet = (Magnet.transform.position - this.transform.position).normalized;
        this.transform.forward = DirectionToMagnet;
    }


}