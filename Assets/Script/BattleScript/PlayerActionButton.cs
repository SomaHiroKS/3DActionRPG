using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionButton : MonoBehaviour
{
    BattleSystem battleSystem;
    EnemyController enemy;
    Act mode;

    public void Start()
    {
       battleSystem = gameObject.GetComponent<BattleSystem>();
       enemy = gameObject.GetComponent<EnemyController>();
        //ModeCheck();
    }

    public void onPressAttack()
    {
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
        ModeCheck();
        GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void PlayerActionFin()
    {
        battleSystem.Mode = Act.PlayerActFin;
        ModeCheck();
        GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.white;
        enemy.EnemyAllAction();
    }

    public void ModeCheck()
    {
        mode = battleSystem.Mode;
        Debug.Log(battleSystem.Mode);
    }
}
