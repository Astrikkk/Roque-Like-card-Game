using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BattleManager : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject enemyObj;
    public List<Card> Cards;
    private Card choosenCard;
    public GameManager GM;
    public TextMeshProUGUI EnemyHp;
    public TextMeshProUGUI EnemyName;
    public TextMeshProUGUI PlayerHp;
    public TextMeshProUGUI PlayerName;

    private void Start()
    {
        Player.NameText = PlayerName;
        Player.HpText = PlayerHp;
        Enemy.NameText = PlayerName;
        Enemy.HpText = PlayerHp;
    }
    public void NextMove()
    {
        if (choosenCard != null)
        {
            switch (choosenCard.typeOfAttack)
            {
                case TypeOfAttack.Fire:
                    Enemy.HP += Enemy.FireDefence -= Player.damage + choosenCard.PlusDamage;
                    break;
                case TypeOfAttack.Woter:
                    Enemy.HP += Enemy.WoterDefence -= Player.damage + choosenCard.PlusDamage;
                    break;
                case TypeOfAttack.Dark:
                    Enemy.HP += Enemy.DarkDefence -= Player.damage + choosenCard.PlusDamage;
                    break;
                case TypeOfAttack.Nothing:
                    Enemy.HP += Enemy.Defence -= Player.damage + choosenCard.PlusDamage;
                    break;
                default:
                    Debug.Log("Invalid attack type.");
                    break;
            }
            switch (Enemy.typeOfAttack)
            {
                case TypeOfAttack.Fire:
                    Player.HP += Player.FireDefence -= Enemy.damage;
                    break;
                case TypeOfAttack.Woter:
                    Player.HP += Player.WoterDefence -= Enemy.damage;
                    break;
                case TypeOfAttack.Dark:
                    Player.HP += Player.DarkDefence -= Enemy.damage;
                    break;
                case TypeOfAttack.Nothing:
                    Player.HP += Player.Defence -= Enemy.damage;
                    break;
                default:
                    Debug.Log("Invalid attack type.");
                    break;

            }
            if (Player.HP <= 0)
            {
                GM.SwitchScene("LooseMenu");
            }
            if (Enemy.HP <= 0)
            {
                GM.SwitchScene("WinMenu");
            }
            choosenCard = null;
        }
    }

    public void ChooseCard(int a)
    {
        choosenCard = Cards[a];
    }

    private void Update()
    {
        Player.HpText.text = Player.HP.ToString();
        Player.NameText.text = Player.name;
        Enemy.HpText.text = Enemy.HP.ToString();
        Enemy.NameText.text = Enemy.name;
    }
}