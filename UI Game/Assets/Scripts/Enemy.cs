using UnityEngine;

public class Enemy : Characters
{
    [SerializeField] private float minDamage, maxDamage;
    
    public override void Attack(Characters toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
    }
}
