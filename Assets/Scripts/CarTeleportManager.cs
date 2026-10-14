using UnityEngine;

public class CarTeleportManager : MonoBehaviour
{
    public Transform xrRig;
    public Transform insidePoint;
    public Transform outsidePoint;

    private bool canEnter;
    private bool canExit;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canEnter)
            {
                xrRig.position = insidePoint.position;
                xrRig.rotation = insidePoint.rotation;
            }
            else if (canExit)
            {
                xrRig.position = outsidePoint.position;
                xrRig.rotation = outsidePoint.rotation;
            }
        }
    }

    public void SetCanEnter(bool value)
    {
        canEnter = value;
    }

    public void SetCanExit(bool value)
    {
        canExit = value;
    }
}