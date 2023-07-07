using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMotion : MonoBehaviour
{
    public Transform MainCamera;
    public GameObject MarkInside;
    public GameObject MarkAnother;
    public void MoveCameraToInside()
    {
        if (MainCamera.position == MarkInside.transform.position)
            Debug.Log("Yes");
        else
            Debug.Log("No");
        MainCamera.position = MarkInside.transform.position;
        if (MainCamera.position == MarkInside.transform.position)
            Debug.Log("Да");
        Debug.Log("Перемещение в эту аудит");
    }
    public void MoveCameraToAnother()
    {
        MainCamera.position = MarkAnother.transform.position;
        Debug.Log("Перемещение в другую аудит");
    }
}
