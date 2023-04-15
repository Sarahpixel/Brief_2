using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    int currentWayPoints =0;
    Rigidbody rb;
    [SerializeField] float moveSpeed = 5;
    bool startMovement = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            startMovement = true;
        if(startMovement)
            Movement(); 
    }

    void Movement()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWayPoints].position)< 0.25f)
        {
            currentWayPoints+= 1;
            currentWayPoints = currentWayPoints % waypoints.Length;
        }

        Vector3 _dir = (waypoints[currentWayPoints].position - transform.position).normalized;
        rb.MovePosition(transform.position + _dir * moveSpeed * Time.deltaTime);
    }
}
