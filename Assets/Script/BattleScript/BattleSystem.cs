using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem: MonoBehaviour
{
    private Act mode;

    public Act Mode
    {
        get { return mode; }
        set { mode = value; }
    }

    public Text log;

    public Queue<string> logText = new Queue<string>();
}
