using UnityEngine;

public class Player : Characters
{
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private Weapon activeWeapon;

    public string ActiveWeaponName
    {
        get { return activeWeapon.weaponName; }
    }
    public int selectedWeaponID = 0;
    public override void Attack(Characters toHit)
    {
        toHit.TakeDamage(activeWeapon);
    }

    public void SwitchWeapon()
    {
        selectedWeaponID = (++selectedWeaponID) % weapons.Length;
        activeWeapon = weapons[selectedWeaponID];
    }

    void Start()
    {
        activeWeapon = weapons[0];
    }
}
