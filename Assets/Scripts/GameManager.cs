using System;
using Unity.Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    public Action OnStart;
    public Action OnPlay;

    [Button("Transition")]
    public void transition()
    {
        if (camA.Priority > camB.Priority)
        {
            camA.Priority = 0;
            camB.Priority = 1;
        }
        else
        {
            camA.Priority = 1;
            camB.Priority = 0;
        }
    }
    public void OnCameraFinished()
    {
        Debug.Log("Camera transition finished!");
    }

    public void StartThis()
    {
        OnStart?.Invoke();
    }
    public void Play()
    {

        OnPlay?.Invoke();
        transition();
    }
}
