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
            Debug.Log("��");
        Debug.Log("����������� � ��� �����");
    }
    public void MoveCameraToAnother()
    {
        MainCamera.position = MarkAnother.transform.position;
        Debug.Log("����������� � ������ �����");
    }
}
