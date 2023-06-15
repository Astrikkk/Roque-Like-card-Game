using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeOfAttack { Fire, Woter, Dark, Nothing };

public class Card : MonoBehaviour
{
    public int PlusDamage;
    public TypeOfAttack typeOfAttack;
}
