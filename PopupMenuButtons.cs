using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupMenuButtons : MonoBehaviour
{

    public void CloseMenu()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = 0;   // Make the popoup menu invisible.
        Cursor.visible = false;             // Hide the cursor.
        Cursor.lockState = CursorLockMode.Locked;   // Lock the cursor to the center of the screen.
    }
}
