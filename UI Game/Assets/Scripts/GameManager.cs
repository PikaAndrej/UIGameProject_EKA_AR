using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Characters enemy;

    [SerializeField] private TMP_Text playerName, playerHP, playerWeapon, enemyName, enemyHP;

    void Start()
    {
        Debug.Log("Player: " + player.CharName);
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: " + enemy.health.ToString("F1");
        playerWeapon.text = "Weapon: " + player.ActiveWeaponName;
    }

    public void SwitchWeapon()
    {
        player.SwitchWeapon();
        UpdateUI();
    }
    public void AttackButton()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }
}
