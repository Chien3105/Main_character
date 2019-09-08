using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_behaviour : MonoBehaviour
{
    public Rigidbody2D ship;
    public float degrees = 1f;
    public float shipspeed = 3f;

    public Vector3 RotateLocation = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        ship = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            shipspeed = shipspeed * (-1);
            RotateUpsideDown();
        } 
        ship.velocity = new Vector2(ship.velocity.x, shipspeed);
    }
    
    void RotateUpsideDown()
    {
        transform.RotateAround(transform.position, Vector3.forward, 180);
        //Debug.Log(transform.position);
        //Debug.Log(Vector3.forward);
    }
}
