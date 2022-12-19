using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public bool spin = true;
    public float spinSpeed = 100.0f;

    private Transform mover;
    private bool moveDir = true;
    // Start is called before the first frame update
    void Start()
    {
        mover = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (spin) 
        { // if spin is true, do this
            mover.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }

        if (moveDir)
            mover.Translate(Time.deltaTime, 0, 0);
        else
            mover.Translate(-Time.deltaTime, 0, 0);
        
        if (mover.position.x < -4.3)
            moveDir = true;
        if (mover.position.x > 4.3)
            moveDir = false;
    }
}
