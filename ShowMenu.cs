using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowMenu : MonoBehaviour, InteractableArtifact
{
    // Start is called before the first frame update
    GameObject text;

    void Start()
    {
        /* Be sure to name the popup menu "Popup Text", or change the tag below */
        this.text = GameObject.FindGameObjectWithTag("Popup Text");

        if (text != null)
        {
            text.GetComponent<CanvasGroup>().alpha = 0;
        }
    }
    public void interact()
    {
        if (text == null)
        {
            return;
        }

        if (text.GetComponent<CanvasGroup>().alpha == 0)
        {
            text.GetComponent<CanvasGroup>().alpha = 1;   // Make the menu visible
            Cursor.visible = true;  // Make the cursor visible.
            Cursor.lockState = CursorLockMode.Confined;   // Unlock the cursor from the center.

            // Set the text of the popup menu.
            text.GetComponentInChildren<TextMeshProUGUI>().text = "This is a historical map. \nIt has historical value.";

        }
    }
    
}
