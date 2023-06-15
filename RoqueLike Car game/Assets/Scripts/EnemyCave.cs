using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCave : MonoBehaviour
{
    public string name;
    public int damage;
    public TypeOfAttack typeOfAttack;
    public int HP;
    public int Defence;
    public int FireDefence;
    public int WoterDefence;
    public int DarkDefence;

    private float startTime;
    private bool shouldDestroy = false;

    private void Start()
    {
        startTime = Time.time;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.time - startTime < 5f)
            {
                Destroy(gameObject);
            }
            else
            {
                Enemy.name = name;
                Enemy.damage = damage;
                Enemy.typeOfAttack = typeOfAttack;
                Enemy.HP = HP;
                Enemy.Defence = Defence;
                Enemy.FireDefence = FireDefence;
                Enemy.WoterDefence = WoterDefence;
                Enemy.DarkDefence = DarkDefence;

                GameObject GM;
                GM = GameObject.FindGameObjectWithTag("GameManager");
                GM.GetComponent<GameManager>().SwitchScene("Game");

                shouldDestroy = true;
            }
        }
    }
}
