using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    public Camera MainCamera;
    public Transform MarkInside;
    public Transform MarkAnother;
    public void MoveCameraToInside()
    {
        MainCamera.transform.position = MarkInside.transform.position;
        Debug.Log("Перемещение в эту аудит");
    }
    public void MoveCameraToAnother()
    {
        MainCamera.transform.position = MarkAnother.transform.position;
        Debug.Log("Перемещение в другую аудит");
    }
}
