using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoneyHandler : MonoBehaviour
{
    [SerializeField] private CharacterMoneys baseMoney;
    public CharacterMoneys BasicMoney { get; private set; }
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

        BasicMoney = new CharacterMoneys { moneySO = moneySO };
        BasicMoney.MoneyChangeType = baseMoney.MoneyChangeType;
        BasicMoney.moneyInCard = baseMoney.moneyInCard;
        BasicMoney.moneyInCash = baseMoney.moneyInCash;
    }
}
