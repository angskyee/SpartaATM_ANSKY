using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoneyHandler : MonoBehaviour
{
    [SerializeField] private CharacterMoneys baseMoney;
    public CharacterMoneys CurrentMoney { get; private set; }
    public List<CharacterMoneys> moneysModifiers = new List<CharacterMoneys>();

    private void Awake()
    {
        UpdateCharacterMoneys();
    }

    private void UpdateCharacterMoneys()
    {
        MoneySO moneySO = null;
        if(baseMoney.moneySO != null)
        {
            moneySO = Instantiate(baseMoney.moneySO);
        }

        CurrentMoney = new CharacterMoneys { moneySO = moneySO };
        CurrentMoney.MoneyChangeType = baseMoney.MoneyChangeType;
        CurrentMoney.moneyInCard = baseMoney.moneyInCard;
        CurrentMoney.moneyInCash = baseMoney.moneyInCash;
    }
}
