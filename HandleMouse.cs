using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is the class used to handle the mouse events. Be sure to attach this to the SuperCharacterController, or
 * it's parent. I did it by creating an empty object and setting it as the parent of the SuperCharacterController.
 * I attached this script to that object. 
 * 
 */
public class HandleMouse : MonoBehaviour
{
    /* Instance Variables:
     *  - cam: The main camera connected to the mouse.
     */
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        this.cam = gameObject.GetComponentInChildren(typeof(Camera)) as Camera;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.cam is null)   
        {
            return;
        }

        // Do a ray cast from the center of the screen and check if the object being pointed to is
        // an Artifact.

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));   // (Center of the screen)
        RaycastHit hit;

        /* IMPORTANT NOTE: Make sure your interactable object has tag Artifact.
         * OR, you can just add another and statement below with another tag name. 
         */

        if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Artifact")
        {
            hit.collider.gameObject.GetComponent<HandleHighlight>().isFocused = true;

            if (Input.GetMouseButtonDown(0))
            {
                // Get the interactable component.
                InteractableArtifact interactableArtifact = hit.collider.gameObject.GetComponent<InteractableArtifact>();

                if (interactableArtifact != null) { interactableArtifact.interact(); }  // Perform the behavior

                Debug.Log("I'm looking at " + hit.transform.name);
            }
        }

    }
}
