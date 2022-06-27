using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    public GameObject window;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (window.activeInHierarchy)
            {
                window.SetActive(false);
                CursorController.Instance.SetCursorState(true);
            }
            else
            {
                window.SetActive(true);
                CursorController.Instance.SetCursorState(false);
            }
        }
    }
}
