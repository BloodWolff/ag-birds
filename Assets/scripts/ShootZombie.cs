using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootzombie : MonoBehaviour { 




    public class ShootingWithCooldown : MonoBehaviour
{
    public float cooldownTime = 1.0f; // Czas cooldownu miêdzy strza³ami w sekundach
    private float nextShootTime = 0.0f; // Czas, kiedy mo¿na ponownie strzelaæ

}
    // Start is called before the first frame update
    public float launchForce;

    public GameObject zombie;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      {
        // SprawdŸ, czy up³yn¹³ wystarczaj¹cy czas od ostatniego strza³u
        if (Time.time > nextShootTime)
        {
            // Tutaj umieœæ kod, który ma byæ uruchomiony podczas strza³u
            if (Input.GetButtonDown("Fire1")) // Przyk³adowy warunek strza³u (mo¿esz dostosowaæ go do swoich potrzeb)
            {
                Shoot(); // Funkcja obs³uguj¹ca strza³

                // Ustaw czas kolejnego mo¿liwego strza³u
                nextShootTime = Time.time + cooldownTime;
            }
        }
    }
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
        Debug.Log("Shoot");
        Shoot();

        }
    }


    void Shoot()
    {
        GameObject zombieIns = Instantiate(zombie,transform.position,transform.rotation);

        zombieIns.GetComponent<Rigidbody2D>().AddForce(transform.right * launchForce);
    }
}
