using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerMoneysController : MonoBehaviour
{
    public Text CashTxt;
    public Text CardTxt;
    private CharacterMoneyHandler _money;
    protected int currentCash;
    protected int currentCard;

    private void Awake()
    {
        _money = GetComponent<CharacterMoneyHandler>();
    }

    private void Start()
    {
        GetMoney(ref currentCash, ref currentCard);
    }

    private string MoneyToString(int value)
    {
        return value.ToString("N0");
    }

    private void GetMoney(ref int cashValue, ref int cardValue)
    {
        cashValue = _money.CurrentMoney.moneyInCash;
        cardValue = _money.CurrentMoney.moneyInCard;
    }

    private void Update()
    {
        CashTxt.text = MoneyToString(currentCash);
        CardTxt.text = MoneyToString(currentCard);
    }

    public bool ChangeMoney(int change)
    {
        int cash = currentCash;
        int card = currentCard;

        if (change == 0 || cash < 0 || card < 0)
        {
            CallWarning();
            return false;
        }

        if (change > 0)
        {
            Debug.Log(cash);
            Debug.Log(change);
            card += change;
            cash -= change;

        }
        else
        {
            card -= change;
            cash += change;
        }

        UpdeteMoney(card, cash);

        return true;
    }

    private void UpdeteMoney(int card, int cash)
    {
        currentCard = card;
        currentCash = cash;
    }

    public void CallWarning()
    {
        Debug.Log(currentCash + currentCard);
    }
}
