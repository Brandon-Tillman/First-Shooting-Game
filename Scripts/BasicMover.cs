using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public enum motionDirection {Spin, Horizontal, Vertical };
    public motionDirection motionState = motionDirection.Horizontal;

    public float spinSpeed = 100.0f;
    public float motionMagnitude = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (motionState) {
            case motionDirection.Spin:
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;
            case motionDirection.Horizontal:
                gameObject.transform.Translate(Vector3.right * motionMagnitude * Mathf.Cos(Time.timeSinceLevelLoad));
                break;
            case motionDirection.Vertical:
                gameObject.transform.Translate(Vector3.up * motionMagnitude * Mathf.Cos(Time.timeSinceLevelLoad));
                break;
        }
            
    }
}
