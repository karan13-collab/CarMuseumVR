using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public CarTeleportManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.SetCanExit(true);

            // Show "Exit Vehicle" UI
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.SetCanExit(false);

            // Hide UI
        }
    }
}