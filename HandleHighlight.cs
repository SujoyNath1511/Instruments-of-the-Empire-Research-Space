using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHighlight : MonoBehaviour
{
    /* Instance Variable:
     * - isFocused: Determines whether the current game object is focused on or not.
     * - highlightColor: The color to set the material to when the object is focused on.
     * - unHighlightColor: The color to set the material to when the object is not focused on.
     * - mainMaterial: The main material we are changing the color of. 
     * 
     */
    public bool isFocused { get; set; } 
    public Color highlightColor;
    public Color unHighlightColor;
    public Material mainMaterial;

    // Start is called before the first frame update
    void Start()
    {
        this.isFocused = false;      // Start this off as unfocused.
        this.highlightColor = new Color32(181, 193, 248, 255);
        this.unHighlightColor = new Color32(255, 255, 255, 255);
        this.mainMaterial = this.gameObject.GetComponent<Renderer>().material;
    }

    // Update once per frame, but be one of the last to update.
    void LateUpdate()
    {
        if (isFocused)
        {
            this.mainMaterial.SetColor("_Color", highlightColor);
            isFocused = false;
        }
        else
        {
            this.mainMaterial.SetColor("_Color", unHighlightColor);
        }
    }
}
