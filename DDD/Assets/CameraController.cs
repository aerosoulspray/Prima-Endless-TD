using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBoarderThickness = 1f;
    public float scrollSpeed = 20f;
    public float minY = 20f;
    public float maxY = 120f;

    public Vector2 panLimit;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBoarderThickness)
        {
            if(Time.timeScale == 4)
            {
                pos.x += panSpeed * Time.deltaTime/4;
            }
            else if(Time.timeScale == 2)
            {
                pos.x += panSpeed * Time.deltaTime/2;
            }
            else
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            if(pos.x >= 180)
            {
                pos.x = 180;
            }
        }
        if (Input.GetKey("a") || Input.mousePosition.x <=  panBoarderThickness)
        {
            if (Time.timeScale == 4)
            {
                pos.x -= panSpeed * Time.deltaTime / 4;
            }
            else if (Time.timeScale == 2)
            {
                pos.x -= panSpeed * Time.deltaTime / 2;
            }
            else
            {
                pos.x -= panSpeed * Time.deltaTime;
            }        
            if (pos.x <= 32)
            {
                pos.x = 32;
            }
        }
       


        transform.position = pos;
    }
}
