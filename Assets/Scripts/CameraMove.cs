using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    [Range(50f, 300f)]
    public float speed = 85f;
    void Update()
    {
        // Get direction via button pression from WASD or arrow keys. 
        float front = Input.GetAxis("Vertical") * speed;
        float side = Input.GetAxis("Horizontal") * speed;

        // Calculate speed of direction relative to frames
        front *= Time.deltaTime;
        side *= Time.deltaTime;

        // Physically move object in direct using speed and direction.
        transform.Translate(0, 0, front);
        transform.Translate(side, 0, 0);

    }

}
