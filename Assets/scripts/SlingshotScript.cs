using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingshotScript : MonoBehaviour
{

    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);  
        
        Vector2 SLingshotPos = transform.position;

        direction = MousePos - SLingshotPos;

        FaceMouse();

    }

    void FaceMouse()
    {
        transform.right = direction;
    }
}
