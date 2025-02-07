using UnityEngine;

public class CameraSizeFix : MonoBehaviour
{
    private Camera cam;
    public fixForOrthographicCam = 5f;

    void Start()
    {
        // מקבלים את המצלמה
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // מחשבים את ה-Aspect Ratio של המסך
        float aspectRatio = (float)Screen.width / (float)Screen.height;

        // אם המצלמה אורתוגרפית, אנחנו משנים את ה-orthographicSize בהתאם
        if (cam.orthographic)
        {
            // מציבים את ה-orthographicSize לפי ה-Aspect Ratio של המסך
            cam.orthographicSize = fixForOrthographicCam / aspectRatio;
        }
    }
}
