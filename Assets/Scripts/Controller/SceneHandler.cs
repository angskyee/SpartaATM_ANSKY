using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject depositMenu;
    public GameObject withdrawMenu;

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
}
