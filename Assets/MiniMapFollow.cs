using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player; // הציפור

    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y; // שמירה על גובה קבוע
        transform.position = newPosition;
    }
}
