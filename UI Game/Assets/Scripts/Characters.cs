using UnityEngine;

public abstract class Characters : MonoBehaviour
{
    public float health;
    [SerializeField] private string charName;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Characters toHit);
    public void TakeDamage(float damage)
    {
        health = health-damage;
        Debug.Log(charName + " got hit for " + damage + " damage! " + "Current Health: " + health);
    }

    public void TakeDamage(Weapon weapon)
    {
        float damage = weapon.GetDamage();
        TakeDamage(damage);
    }
}
