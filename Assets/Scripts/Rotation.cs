using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float distanceToTarget = 10;

    private Vector3 previousPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 currentPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - currentPosition;

            float rotationAroundYAxis = direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = -direction.y * 180; // camera moves vertically

            previousPosition = currentPosition;

            cam.transform.RotateAround(target.transform.position, new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.RotateAround(target.transform.position, new Vector3(0, 1, 0), rotationAroundYAxis);
        }
    }
}

