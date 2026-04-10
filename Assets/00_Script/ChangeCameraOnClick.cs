using Unity.Cinemachine;
using UnityEngine;

public class ChangeCameraOnClick : MonoBehaviour, IClickeable
{
    public CinemachineCamera newCamera;

    public void OnClick()
    {
        CameraManager.instance.ChangeCamera(newCamera);
    }
}
