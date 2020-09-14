using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem: MonoBehaviour
{
    private Act mode;

    public Act Mode
    {
        get { return mode; }
        set { mode = value; }
    }
}
