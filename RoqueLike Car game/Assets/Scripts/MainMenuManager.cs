using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public TextMeshProUGUI HpText;
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI DefenceText;
    public TextMeshProUGUI FireDefenceText;
    public TextMeshProUGUI WoterDefenceText;
    public TextMeshProUGUI DarkDefenceText;
    public static int Money;

    private void Update()
    {
        HpText.text = Player.HP.ToString();
        damageText.text = Player.damage.ToString();
        DefenceText.text = Player.Defence.ToString();
        FireDefenceText.text = Player.FireDefence.ToString();
        WoterDefenceText.text = Player.WoterDefence.ToString();
        DarkDefenceText.text = Player.DarkDefence.ToString();
    }


    public void Upgrade(int a)
    {
        switch (a)
        {
            case 1:
                if (Money >= 5)
                {
                    Money -= 5;
                    Player.HP += 10;
                }
                break;
            case 2:
                if (Money >= 10)
                {
                    Money -= 10;
                    Player.damage += 10;
                }
                break;
            case 3:
                if (Money >= 10)
                {
                    Money -= 10;
                    Player.Defence += 10;
                }
                break;
            case 4:
                if (Money >= 20)
                {
                    Money -= 20;
                    Player.FireDefence += 10;
                }
                break;
            case 5:
                if (Money >= 20)
                {
                    Money -= 20;
                    Player.WoterDefence += 10;
                }
                break;
            case 6:
                if (Money >= 50)
                {
                    Money -= 50;
                    Player.DarkDefence += 10;
                }
                break;


        }
    }
}
