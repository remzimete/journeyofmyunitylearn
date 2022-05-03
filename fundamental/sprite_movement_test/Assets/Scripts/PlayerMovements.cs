using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    public float Speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() // we have 60 frames in a second it will be called sixty times which is update is called once per frame is that equal to 0.01 second
    {
        // we are getting input at here
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");
        // i am accessing values of gameobject Transform = GameObject dot(of) position
        // Pos is a local variable 
        // Vector2 a struct a classname of unity library
        Vector2 pos = transform.position;
        // x value and y value of game object 
        // we are changing it with position from user (when you click example: 'A' it's going left and it's equal to 1f or something. then you are multiplying it by time. its makes an animation) by time
        Debug.Log(h);
        Debug.Log(v);
        pos.x += h * Speed * Time.deltaTime; // Time.deltaTime provided by unity library = The interval in seconds from the last frame to the current one (Read Only).
        pos.y += v * Speed * Time.deltaTime; //                                            en sonuncu frame ve þimdiki frame arasýnda geçen süre(saniye) yaratýyor ve böylece animasyonlu böyle gidiþat oluyor.

        transform.position = pos;
    }
}// class
