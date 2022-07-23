using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingLine : MonoBehaviour
{
    // Start is called before the first frame update
    
    int distance_scale_from_camera = 10;

    List<Vector3> linePoints;

    float timer;
    public float timerDelay;

    GameObject newLine;
    LineRenderer drawLine;

    public float lineWidth;

    void Start() {
        linePoints = new List<Vector3>();
        timer = timerDelay;
    }

    void Update() {

        if (Input.GetMouseButtonDown(0)) {
            newLine = new GameObject();
            drawLine = newLine.AddComponent<LineRenderer>();
            drawLine.material = new Material(Shader.Find("Sprites/Default"));


            drawLine.startColor = Color.red;
            drawLine.endColor = Color.red;

            drawLine.startWidth = lineWidth;
            drawLine.endWidth = lineWidth;
        }

        if (Input.GetMouseButton(0)) {
            Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), GetMousePosition(), Color.red);
            timer -= Time.deltaTime;
            if (timer <= 0) {
                linePoints.Add(GetMousePosition());
                drawLine.positionCount = linePoints.Count;
                drawLine.SetPositions(linePoints.ToArray());
                
                timer = timerDelay;

            }
        }

        if (Input.GetMouseButtonUp(0)) {
            linePoints.Clear();
        }
        
    }

    Vector3 GetMousePosition() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        return ray.origin + ray.direction * distance_scale_from_camera;
    }
}
