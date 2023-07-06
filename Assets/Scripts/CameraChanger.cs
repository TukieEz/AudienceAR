using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChanger : MonoBehaviour
{
    public Camera OutsideCamera;
    public Camera InsideThisCamera;
    public Camera InsideAnotherCamera;

    public void Start()
    {
        OutsideCamera.tag = "MainCamera";
        InsideAnotherCamera.tag = "Untagged";
        InsideThisCamera.tag = "Untagged";
        OutsideCamera.enabled = true;
        InsideAnotherCamera.enabled = false;
        InsideThisCamera.enabled = false;
    }
    public void ShowInsideCamera()
    {
        OutsideCamera.tag = "Untagged";
        InsideAnotherCamera.tag = "Untagged";
        InsideThisCamera.tag = "MainCamera";
        OutsideCamera.enabled = false;
        InsideAnotherCamera.enabled = false;
        InsideThisCamera.enabled = true;
    }
    public void ShowAnotherCamera()
    {
        OutsideCamera.tag = "Untagged";
        InsideAnotherCamera.tag = "MainCamera";
        InsideThisCamera.tag = "Untagged";
        OutsideCamera.enabled = false;
        InsideAnotherCamera.enabled = true;
        InsideThisCamera.enabled = false;
    }
}
