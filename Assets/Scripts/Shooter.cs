using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile; // you can do for example [SerializeField] GameObject projectile, gun; etc, this would do the same thing as what i did
    [SerializeField] GameObject gun;

    public void Fire() // you can use (float damage) if you want to control the amount of damage through the animation event inspector instead of through script
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
