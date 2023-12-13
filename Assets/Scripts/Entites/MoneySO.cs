using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterCash", menuName = "TopDownMoneyController/Money/Default", order = 0)]

public class MoneySO : ScriptableObject
{
    [Header("BaseMoney")]
    public int TotalMoney;
}
