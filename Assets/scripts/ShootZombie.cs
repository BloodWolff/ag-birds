using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootZombie : MonoBehaviour
{
    // Start is called before the first frame update
    public float launchForce;

    public GameObject Zombie;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {

            Shoot();

        }
    }


    void Shoot()
    {
        GameObject ZombieIns = Instantiate(Zombie,transform.position,transform.rotation);

        ZombieIns.GetComponent<Rigidbody2D>().AddForce(transform.right * launchForce);
    }
}
