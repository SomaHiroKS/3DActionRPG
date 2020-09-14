using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActionButton : MonoBehaviour
{
    BattleSystem battleSystem;
    EnemyController enemy;
    CommandUIController commandUI;
    Act mode;

    public void Start()
    {
       battleSystem = gameObject.GetComponent<BattleSystem>();
       enemy = gameObject.GetComponent<EnemyController>();
       commandUI = GameObject.Find("UIManager").GetComponent<CommandUIController>();
;        //ModeCheck();
    }

    public void onPressAttack()
    {
        LogMode();
        mode = battleSystem.Mode;
        //攻撃ボタンを押したら状態を「プレイヤー行動中」へ遷移
        if (mode == Act.KeyInput)
        {
            PlayerAction();
        }

        if (mode == Act.PlayerAct)
        {
            //行動処理後に状態を「プレイヤー行動終了」へ遷移
            Invoke("PlayerActionFin", 3.0f);
        }

       

        enemy.EnemyAllAction();  
    }

    public void PlayerAction()
    {
        battleSystem.Mode = Act.PlayerAct;
        GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.yellow;
        battleSystem.logText.Enqueue("PlayerAct\n");
        ModeCheck();
    }

    public void PlayerActionFin()
    {
        battleSystem.Mode = Act.PlayerActFin;
        GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.white;
        battleSystem.logText.Enqueue("PlayerActFin\n");
        ModeCheck();
        enemy.EnemyAllAction();
        
    }
    public void LogMode()
    {
        commandUI.NormalMenuPanel.SetActive(false);
        commandUI.AttackMenuPanel.SetActive(false);
        commandUI.LogPanel.SetActive(true);
        commandUI.LogButton.SetActive(false);
    }

    public void ModeCheck()
    {
        if(battleSystem.logText.Count > 20)
        {
            string dequeue = battleSystem.logText.Dequeue();
        }
        mode = battleSystem.Mode;
        //Debug.Log(battleSystem.Mode);
        battleSystem.log.text = "";
        foreach (var item in battleSystem.logText)
        {
            battleSystem.log.text += item;
        }
    }
}
