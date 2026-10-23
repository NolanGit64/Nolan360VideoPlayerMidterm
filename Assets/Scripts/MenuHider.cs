using UnityEngine;

public class MenuHider : MonoBehaviour
{
    public GameObject canvas;
    void Update()
    {
        float angleX = transform.localEulerAngles.x;
        if (angleX > 180)
        {
            angleX -= 360;
        }
        if (canvas != null)
        {
            if (angleX >= 20)
            {
                canvas.SetActive(true);
            }
            else
            {
                canvas.SetActive(false);
            }
        }
    }
}
