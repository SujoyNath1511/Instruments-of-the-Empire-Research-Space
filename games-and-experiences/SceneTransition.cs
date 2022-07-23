using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Platform 1") {
            SceneManager.LoadScene(1);
        }
        if (other.gameObject.tag == "Platform 2") {
            SceneManager.LoadScene(2);
        }
    }

    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */
}
