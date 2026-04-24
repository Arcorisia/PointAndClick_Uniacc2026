using UnityEngine;
using Unity.Cinemachine;

public class CameraManager : MonoBehaviour
{
    public CinemachineCamera actualCamera;
    public static CameraManager instance;

    void Awake()
    {
        instance = this;
    }

    public void ChangeCamera(CinemachineCamera newCamera)
    {
        actualCamera.Priority = 0;
        newCamera.Priority = 10;
    }
}
