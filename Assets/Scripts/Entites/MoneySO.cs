using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterCash", menuName = "TopDownMoneyController/Money/Default", order = 0)]

public class MoneySO : ScriptableObject
{
    [Header("Deposit")]
    public int Deposit1;
    public int Deposit2;
    public int Deposit3;

    [Header("Withdraw")]
    public int Withdraw1;
    public int Withdraw2;
    public int Withdraw3;
}
