using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandUIController : MonoBehaviour
{
    //３つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    public GameObject NormalMenuPanel;
    public GameObject AttackMenuPanel;
    public GameObject LogPanel;
    public GameObject LogButton;

    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }


    //MainMenuPanelでAttackが押されたときの処理
    //AttackMenuPanelをアクティブにする
    public void SelectAttackMenu()
    {
        NormalMenuPanel.SetActive(false);
        AttackMenuPanel.SetActive(true);
    }

    public void SelectLogMenu()
    {
        if (NormalMenuPanel.activeSelf || AttackMenuPanel.activeSelf)
        {
            NormalMenuPanel.SetActive(false);
            AttackMenuPanel.SetActive(false);
            LogPanel.SetActive(true);
            LogButton.GetComponentInChildren<Text>().text = "Back";
        }
        else
        {
            BackToMenu();
            LogButton.GetComponentInChildren<Text>().text = "Log";
        }
    }

    //2つのDescriptionPanelでBackButtonが押されたときの処理
    //MenuPanelをアクティブにする
    public void BackToMenu()
    {
        NormalMenuPanel.SetActive(true);
        AttackMenuPanel.SetActive(false);
        LogPanel.SetActive(false);
    }
}
