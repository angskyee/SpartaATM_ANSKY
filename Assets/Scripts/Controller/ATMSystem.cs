using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ATMSystem : MonoBehaviour
{
    public Text CashTxt;
    public Text CardTxt;

    protected CharacterMoneyHandler _handler;
    private SceneHandler _sceneHandler;

    //public event Action OnButtonClick;

    public int CurrentCash { get; private set; }
    public int CurrentCard { get; private set; }

    public int BasicCash => _handler.BasicMoney.moneyInCash;
    public int BasicCard => _handler.BasicMoney.moneyInCard;

    private void Awake()
    {
        _handler = GetComponent<CharacterMoneyHandler>();
        _sceneHandler = GetComponentInChildren<SceneHandler>();
    }

    private void Start()
    {
        CurrentCard = _handler.BasicMoney.moneyInCard;
        CurrentCash = _handler.BasicMoney.moneyInCash;
    }

    private void Update()
    {
        CashTxt.text = MoneyToString(CurrentCash);
        CardTxt.text = MoneyToString(CurrentCard);
    }

    private string MoneyToString(int value)
    {
        return value.ToString("N0");
    }

    public bool ChangeMoney(int change)
    {
        if(change > 0 && change > CurrentCash)
        {
            change = 0;
        }

        if(change < 0 && change > CurrentCard)
        {
            change = 0;
        }

        if (change == 0)
        {
            CallWarning();
            return false;
        }
        else
        {
            CurrentCard += change;
            CurrentCash -= change;
        }

        return true;
    }

    public void CallWarning()
    {
        _sceneHandler.ArrorScene();
    }

    //public void CallButtonClick()
    //{
    //    OnButtonClick?.Invoke();
    //}




    //public void DepositFirstBtn()
    //{
    //    OnButtonClick(_handler.BasicMoney.moneySO.Deposit1);
    //}

    //public void DepositSecondBtn()
    //{
    //    OnButtonClick(_handler.BasicMoney.moneySO.Deposit2);
    //}

    //public void DepositThirdBtn()
    //{
    //    OnButtonClick(_handler.BasicMoney.moneySO.Deposit3);
    //}

    //public void DepositInputBtn()
    //{
    //    OnInputFieldDepositButtonClick();
    //}

    //private void OnButtonClick(int value)
    //{
    //    customerMoneysController.ChangeMoney(value);
    //}

    //private void OnInputFieldDepositButtonClick()
    //{
    //    string inputvalue = inputFieldDeposit.text;

    //    if (int.TryParse(inputvalue, out int intValue))
    //    {
    //        customerMoneysController.ChangeMoney(intValue);
    //    }
    //    else
    //    {
    //        customerMoneysController.CallWarning();
    //    }
    //}

    //private void OnInputFieldWithdrawButtonClick()
    //{
    //    string inputvalue = inputFieldWithdraw.text;

    //    if (int.TryParse(inputvalue, out int intValue))
    //    {
    //        customerMoneysController.ChangeMoney(-intValue);
    //    }
    //    else
    //    {
    //        customerMoneysController.CallWarning();
    //    }
    //}
}