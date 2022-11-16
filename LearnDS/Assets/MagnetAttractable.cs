
using System.Collections.Generic;
using UnityEngine;
public class MagnetAttractable : MonoBehaviour
{

    [SerializeField] private float magnetStrength;
    [SerializeField] private float magnetRange;

    Transform player;
    public float distance;
    Rigidbody move;
    // Use this for initialization
    void Start()
    {
        move = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < 115900)
        {

            move.AddForce((player.transform.position - transform.position) * (16));
        }

    }
}