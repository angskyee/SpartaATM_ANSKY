using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ATMSystem : MonoBehaviour
{
    public InputField inputFieldDeposit;
    public InputField inputFieldWithdraw;

    //public Button DepositBtn;
    //public Button DepositBtn10000;
    //public Button DepositBtn30000;
    //public Button DepositBtn50000;
    //public Button WithdrawBtn;
    //public Button WithdrawBtn10000;
    //public Button WithdrawBtn30000;
    //public Button WithdrawBtn50000;

    private CustomerMoneysController customerMoneysController;

    //private void Start()
    //{
    //    DepositBtn.onClick.AddListener(OnInputFieldDepositButtonClick);
    //    DepositBtn10000.onClick.AddListener(() => OnButtonClick(10000));
    //    DepositBtn30000.onClick.AddListener(() => OnButtonClick(30000));
    //    DepositBtn50000.onClick.AddListener(() => OnButtonClick(50000));
    //    WithdrawBtn.onClick.AddListener(OnInputFieldWithdrawButtonClick);
    //    WithdrawBtn10000.onClick.AddListener(() => OnButtonClick(-10000));
    //    WithdrawBtn30000.onClick.AddListener(() => OnButtonClick(-30000));
    //    WithdrawBtn50000.onClick.AddListener(() => OnButtonClick(-50000));
    //}

    private void Awake()
    {
        customerMoneysController = new CustomerMoneysController();
    }

    public void Deposit10000Btn()
    {
        OnButtonClick(10000);
    }

    public void Deposit30000Btn()
    {
        OnButtonClick(30000);
    }

    public void Deposit50000Btn()
    {
        OnButtonClick(50000);
    }

    public void DepositInputBtn()
    {
        OnInputFieldDepositButtonClick();
    }

    public void Withdraw10000Btn()
    {
        OnButtonClick(10000);
    }

    public void Withdraw30000Btn()
    {
        OnButtonClick(30000);
    }

    public void Withdraw50000Btn()
    {
        OnButtonClick(50000);
    }

    public void WithdrawInputBtn()
    {
        OnInputFieldWithdrawButtonClick();
    }

    private void OnButtonClick(int value)
    {
        customerMoneysController.ChangeMoney(value);
    }

    private void OnInputFieldDepositButtonClick()
    {
        string inputvalue = inputFieldDeposit.text;

        if (int.TryParse(inputvalue, out int intValue))
        {
            customerMoneysController.ChangeMoney(intValue);
        }
        else
        {
            customerMoneysController.CallWarning();
        }
    }

    private void OnInputFieldWithdrawButtonClick()
    {
        string inputvalue = inputFieldWithdraw.text;

        if (int.TryParse(inputvalue, out int intValue))
        {
            customerMoneysController.ChangeMoney(-intValue);
        }
        else
        {
            customerMoneysController.CallWarning();
        }
    }
}