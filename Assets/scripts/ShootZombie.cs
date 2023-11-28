using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootzombie : MonoBehaviour { 




    public class ShootingWithCooldown : MonoBehaviour
{
    public float cooldownTime = 1.0f; // Czas cooldownu mi�dzy strza�ami w sekundach
    private float nextShootTime = 0.0f; // Czas, kiedy mo�na ponownie strzela�

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
        // Sprawd�, czy up�yn�� wystarczaj�cy czas od ostatniego strza�u
        if (Time.time > nextShootTime)
        {
            // Tutaj umie�� kod, kt�ry ma by� uruchomiony podczas strza�u
            if (Input.GetButtonDown("Fire1")) // Przyk�adowy warunek strza�u (mo�esz dostosowa� go do swoich potrzeb)
            {
                Shoot(); // Funkcja obs�uguj�ca strza�

                // Ustaw czas kolejnego mo�liwego strza�u
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
