using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject depositMenu;
    public GameObject withdrawMenu;
    public GameObject arror;

    public void SetMainMenu()
    {
        if(depositMenu.activeSelf)
        {
            depositMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
        else if (withdrawMenu.activeSelf)
        {
            withdrawMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

    public void SetDepositMenu()
    {
        if (mainMenu.activeSelf)
        {
            mainMenu.SetActive(false);
            depositMenu.SetActive(true);
        }
    }

    public void SetWithdrawMenu()
    {
        if (mainMenu.activeSelf)
        {
            mainMenu.SetActive(false);
            withdrawMenu.SetActive(true);
        }
    }

    public void ReturnMainScene()
    {
        mainMenu.SetActive(true);
        if (depositMenu.activeSelf)
        {
            depositMenu.SetActive(false);
        }
        else if (withdrawMenu.activeSelf)
        {
            withdrawMenu.SetActive(false);
        }
    }

    public void ArrorScene()
    {
        arror.SetActive(true);
    }

    public void ExitArrorScene()
    {
        arror.SetActive(false);
    }
}
