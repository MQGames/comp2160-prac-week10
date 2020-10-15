using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuck : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        Vector3 position = MousePosition();
        transform.position = position;
    }

    private Vector3 MousePosition()
    {
        // use raycasting to turn mouse position into position on the board
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float t;
        plane.Raycast(ray, out t);
        return ray.GetPoint(t);
    }
}
