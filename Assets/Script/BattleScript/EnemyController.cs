using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    BattleSystem battleSystem;
    CommandUIController commandUI;
    Act mode;

    public void Start()
    {
        battleSystem = gameObject.GetComponent<BattleSystem>();
        commandUI = GameObject.Find("UIManager").GetComponent<CommandUIController>();
        //ModeCheck();
    }

    public void EnemyAllAction()
    {
        mode = battleSystem.Mode;
        if (mode == Act.PlayerActFin)
        {
            EnemyAction();
        }
        
        if (mode == Act.EnemyAct)
        {
            Invoke("EnemyActionFin", 3.0f);
        }
    }

    public void EnemyAction()
    {
        battleSystem.Mode = Act.EnemyAct;
        GameObject.Find("Enemy").GetComponent<Renderer>().material.color = Color.yellow;
        battleSystem.logText.Enqueue("EnemyAct\n");
        ModeCheck();
    }

    public void EnemyActionFin()
    {
        battleSystem.Mode = Act.EnemyActFin;
        GameObject.Find("Enemy").GetComponent<Renderer>().material.color = Color.white;
        battleSystem.logText.Enqueue("EnemyActFin\n");
        ModeCheck();
        if (mode == Act.EnemyActFin)
        {
            battleSystem.Mode = Act.TurnEnd;
            ModeCheck();
        }
        if (mode == Act.TurnEnd)
        {
            battleSystem.Mode = Act.KeyInput;
            ModeCheck();
            LogModeFin();
        }
    }

    public void LogModeFin()
    {
        commandUI.NormalMenuPanel.SetActive(true);
        commandUI.AttackMenuPanel.SetActive(false);
        commandUI.LogPanel.SetActive(false);
        commandUI.LogButton.SetActive(true);
    }

    public void ModeCheck()
    {
        if (battleSystem.logText.Count > 20)
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
