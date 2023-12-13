using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerMoneysController : MonoBehaviour
{

    public InputField inputFieldDeposit;
    public InputField inputFieldWithdraw;

    private ATMSystem aTMSystem;
    private CharacterMoneyHandler _handler;

    private void Start()
    {
        aTMSystem = transform.GetComponentInParent<ATMSystem>();
        _handler = transform.GetComponentInParent<CharacterMoneyHandler>();
    }

    public void OnFirstDepositButtonClick()
    {
        aTMSystem.ChangeMoney(_handler.BasicMoney.moneySO.Deposit1);
    }

    public void OnSecondDepositButtonClick()
    {
        aTMSystem.ChangeMoney(_handler.BasicMoney.moneySO.Deposit2);
    }

    public void OnThirdDepositButtonClick()
    {
        aTMSystem.ChangeMoney(_handler.BasicMoney.moneySO.Deposit3);
    }

    public void OnFreeDepositButtonClick()
    {
        aTMSystem.ChangeMoney(InputDepositMoney());
    }

    public int InputDepositMoney()
    {
        string inputDepositText = inputFieldDeposit.text;

        if(int.TryParse(inputDepositText, out int moneyValue))
        {
            return moneyValue;
        }
        else
        {
            return 0;
        }
    }

    public void OnFirstWithdrawButtonClick()
    {
        aTMSystem.ChangeMoney(_handler.BasicMoney.moneySO.Withdraw1);
    }

    public void OnSecondWithdrawButtonClick()
    {
        aTMSystem.ChangeMoney(_handler.BasicMoney.moneySO.Withdraw2);
    }

    public void OnThirdWithdrawButtonClick()
    {
        aTMSystem.ChangeMoney(_handler.BasicMoney.moneySO.Withdraw3);
    }

    public void OnFreeWithdrawButtonClick()
    {
        aTMSystem.ChangeMoney(InputWithdrawMoney());
    }

    public int InputWithdrawMoney()
    {
        string inputWithdrawText = inputFieldWithdraw.text;

        if (int.TryParse(inputWithdrawText, out int moneyValue))
        {
            return -moneyValue;
        }
        else
        {
            return 0;
        }
    }

    //public Text CashTxt;
    //public Text CardTxt;
    //private CharacterMoneyHandler _money;

    //public int CurrentCash { get; private set; }
    //public int CurrentCard { get; private set; }

    //public int BasicCash => _money.BasicMoney.moneyInCash;
    //public int BasicCard => _money.BasicMoney.moneyInCard;

    //private void Awake()
    //{
    //    _money = GetComponent<CharacterMoneyHandler>();
    //}

    //private void Start()
    //{
    //    CurrentCard = _money.BasicMoney.moneyInCard;
    //    CurrentCash = _money.BasicMoney.moneyInCash;
    //}

    //private string MoneyToString(int value)
    //{
    //    return value.ToString("N0");
    //}

    //private void Update()
    //{
    //    CashTxt.text = MoneyToString(CurrentCash);
    //    CardTxt.text = MoneyToString(CurrentCard);
    //}

    //public bool ChangeMoney(int change)
    //{

    //    if (change == 0)
    //    {
    //        CallWarning();
    //        return false;
    //    }

    //    if (change > 0)
    //    {
    //        Debug.Log(CurrentCash);
    //        Debug.Log(change);
    //        CurrentCard += change;
    //        CurrentCash -= change;

    //    }
    //    else
    //    {
    //        CurrentCard -= change;
    //        CurrentCash += change;
    //    }

    //    return true;
    //}

    //public void CallWarning()
    //{
    //    Debug.Log(CurrentCash + CurrentCard);
    //}
}
