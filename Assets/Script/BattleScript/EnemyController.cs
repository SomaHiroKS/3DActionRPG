using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    BattleSystem battleSystem;
    Act mode;

    public void Start()
    {
        battleSystem = gameObject.GetComponent<BattleSystem>();
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
        ModeCheck();
        GameObject.Find("Enemy").GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void EnemyActionFin()
    {
        battleSystem.Mode = Act.EnemyActFin;
        ModeCheck();
        GameObject.Find("Enemy").GetComponent<Renderer>().material.color = Color.white;
        if (mode == Act.EnemyActFin)
        {
            battleSystem.Mode = Act.TurnEnd;
            ModeCheck();
        }
        if (mode == Act.TurnEnd)
        {
            battleSystem.Mode = Act.KeyInput;
            ModeCheck();
        }
    }

    public void ModeCheck()
    {
        mode = battleSystem.Mode;
        Debug.Log(battleSystem.Mode);
    }
}
