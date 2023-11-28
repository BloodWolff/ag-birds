using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiescript : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;

    bool hasHit = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHit == false)
        {
            trackMovement();
        }
    }

    void trackMovement()
    {
        Vector2 direccation = rb.velocity;

        float angle = Mathf.Atan2(direccation.y, direccation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
 
    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject, 6f);
    }
    
}

