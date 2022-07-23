using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    
    private string input;

    public Text MapAnnotation1;
    public Text MapAnnotation2;
    public Text MapAnnotation3;
    public Text MapAnnotation4;
    public Text MapAnnotation5;

    private int numAnnotations = 5;

    private List<int> availableAnnotations = new List<int>();

    // Time Delay
    float time;
    float timeDelay;
    bool canAddAnnotation;
    int currentAnnotation;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        timeDelay = 3f;
        canAddAnnotation = true;
        currentAnnotation = 0;
        for (int i = 0; i < numAnnotations; i++) {
            availableAnnotations.Add(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if (time > timeDelay) {
            canAddAnnotation = true;
        }

        if (Input.GetKeyDown(KeyCode.C) && canAddAnnotation) {
            if (availableAnnotations[0] == 1) {
                Debug.Log("London");
                availableAnnotations[0] = 0;
                MapAnnotation1.text = input;
            }
            else if (availableAnnotations[1] == 1) {
                availableAnnotations[1] = 0;
                MapAnnotation2.text = input;
            }
            else if (availableAnnotations[2] == 1) {
                availableAnnotations[2] = 0;
                MapAnnotation3.text = input;
            }
            else if (availableAnnotations[3] == 1) {
                availableAnnotations[3] = 0;
                MapAnnotation4.text = input;
            }
            else if (availableAnnotations[4] == 1) {
                availableAnnotations[4] = 0;
                MapAnnotation5.text = input;
            }

            
            time = 0f;
            canAddAnnotation = false;
        }
    }

    public void ReadStringInput(string s) {
        input = s;
        Debug.Log(input);
    }
}
