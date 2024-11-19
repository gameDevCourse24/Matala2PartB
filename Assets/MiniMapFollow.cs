using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 newPosition = player.position;
            newPosition.z = transform.position.z; // שומר על גובה קבוע
            transform.position = newPosition;
        }
    }
}
