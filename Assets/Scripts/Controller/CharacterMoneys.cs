using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoneyChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class CharacterMoneys
{
    public MoneyChangeType MoneyChangeType;
    [Range(1, 10000000)] public int moneyInCash;
    [Range(1, 10000000)] public int moneyInCard;
    public MoneySO moneySO;
}
