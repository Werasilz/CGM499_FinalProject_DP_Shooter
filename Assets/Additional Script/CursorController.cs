using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : Singleton<CursorController>
{
    // Start is called before the first frame update
    void Start()
    {
        SetCursorState(false);
    }

    public void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !newState;
    }
}
