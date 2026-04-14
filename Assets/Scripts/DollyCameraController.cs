using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Splines;

public class DollyCameraController : MonoBehaviour
{
    public CinemachineCamera cameraTarget;
    public Transform Player; 




    public CinemachineSplineDolly splineDolly;
    public SplineContainer MainSpline;
    public SplineContainer Spline1;
    public SplineContainer Spline2;
    public SplineContainer Spline3;
    public SplineContainer Spline4;
    public SplineContainer Spline5;

    public int PlaceSelected;

    public Transform Tp1;
    public Transform Tp2;
    public Transform Tp3;
    public Transform Tp4;
    public Transform Tp5;


    private void Awake()
    {
    }
    void Start()
    {

        GameManager.instance.OnStart += MovePlaceRight;
        GameManager.instance.OnPlay += TeleportPlayer;


    }
    public void MovePlaceRight()
    {
        PlaceSelected++;

        switch (PlaceSelected)
        {
            case 0://nothing
                break;
            case 1:
                cameraTarget.Target.TrackingTarget = Tp1;
                splineDolly.Spline = Spline1;
                break;
            case 2:

                cameraTarget.Target.TrackingTarget = Tp2;
                splineDolly.Spline = Spline2;
                break;
            case 3:

                cameraTarget.Target.TrackingTarget = Tp3;
                splineDolly.Spline = Spline3;
                break;
            case 4:

                cameraTarget.Target.TrackingTarget = Tp4;
                splineDolly.Spline = Spline4;
                break;
            case 5:

                cameraTarget.Target.TrackingTarget = Tp5;
                splineDolly.Spline = Spline5;
                break;
        }


    }

    public void MovePlaceLeft()
    {
        if(PlaceSelected >1)
        PlaceSelected--;
        switch (PlaceSelected)
        {
            case 0://nothing
                break;
            case 1:
                cameraTarget.Target.TrackingTarget = Tp1;
                splineDolly.Spline = Spline1;
                break;
            case 2:

                cameraTarget.Target.TrackingTarget = Tp2;
                splineDolly.Spline = Spline2;
                break;
            case 3:

                cameraTarget.Target.TrackingTarget = Tp3;
                splineDolly.Spline = Spline3;
                break;
            case 4:

                cameraTarget.Target.TrackingTarget = Tp4;
                splineDolly.Spline = Spline4;
                break;
            case 5:

                cameraTarget.Target.TrackingTarget = Tp5;
                splineDolly.Spline = Spline5;
                break;
        }

    }

    public void TeleportPlayer()
    {

        switch (PlaceSelected)
        {
            case 0:
                break;
            case 1:

                Player.gameObject.GetComponent<CharacterController>().enabled = false;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = false;
                
                Player.gameObject.transform.position = Tp1.position;
                Player.gameObject.GetComponent<CharacterController>().enabled = true;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = true;

                break;
            case 2:

                Player.gameObject.GetComponent<CharacterController>().enabled = false;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = false;

                Player.gameObject.transform.position = Tp2.position;

                Player.gameObject.GetComponent<CharacterController>().enabled = true;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
                break;
            case 3:

                Player.gameObject.GetComponent<CharacterController>().enabled = false;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = false;

                Player.gameObject.transform.position = Tp3.position;

                Player.gameObject.GetComponent<CharacterController>().enabled = true;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
                break;
            case 4:

                Player.gameObject.GetComponent<CharacterController>().enabled = false;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = false;
             
                Player.gameObject.transform.position = Tp4.position;
                Player.gameObject.GetComponent<CharacterController>().enabled = true;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
                break;
            case 5:

                Player.gameObject.GetComponent<CharacterController>().enabled = false;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = false;

                Player.gameObject.transform.position = Tp5.position;
                Player.gameObject.GetComponent<CharacterController>().enabled = true;
                Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
                break;
        }
    }



}
