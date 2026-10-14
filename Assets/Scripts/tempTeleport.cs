using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform xrOrigin;
    public Transform teleportTarget;

    public void Teleport()
    {
        if (xrOrigin == null || teleportTarget == null)
        {
            Debug.LogWarning("Missing references for teleport!");
            return;
        }

        xrOrigin.position = teleportTarget.position;
        xrOrigin.rotation = teleportTarget.rotation;
    }
}