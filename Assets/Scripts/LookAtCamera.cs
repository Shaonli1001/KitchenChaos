using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private enum Mode
    {
        LookAt,
        LookAtInverted,
        CameraForward, CameraBackward,
    }

    [SerializeField]private Mode mode;

    void LateUpdate()
    {
        switch(mode)
        {
            case Mode.LookAt:
            transform.LookAt(Camera.main.transform);
                break;
            case Mode.LookAtInverted:
                Vector3 dirFromCamera = transform.position - Camera.main.transform.forward;
                transform.LookAt(transform.position + dirFromCamera);
                break;
                case Mode.CameraForward:
                transform.forward = Camera.main.transform.forward;
                break;
                case Mode.CameraBackward:
                transform.forward = -Camera.main.transform.forward;
                break;
        }

    }
}
