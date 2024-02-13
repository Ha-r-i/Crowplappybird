using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipescripts : MonoBehaviour
{
    public float motionspeed = 5;
    public float deadzone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * motionspeed)*Time.deltaTime;
        if (transform.position.x <= deadzone)
        {
            Destroy(gameObject);
        }
    }
}
