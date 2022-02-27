using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 50f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //easy way to move at a specific direction and speed
    }

    private void OnTriggerEnter2D(Collider2D otherCollider) //otherCollider refers to what this collider bumps into, could be named whatever you want.
    {
        var health = otherCollider.GetComponent<Health>(); //So when this projectile hit another collider(otherCollider) it will find the Health script component
        var attacker = otherCollider.GetComponent<Attacker>();

        if(attacker && health)//means if the thing this hits has attacker and health vars then we do this
        {
            health.DealDamage(damage);
            Destroy(gameObject); //projectile will destroy it self upon dealing damage once it hits something with these 2 vars
        }
        
    }
}
