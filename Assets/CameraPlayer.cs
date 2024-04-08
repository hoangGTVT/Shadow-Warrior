using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform target; 
    public Vector2[] minBounds; 
    public Vector2[] maxBounds; 
    public MapController cotroller;
    public float smoothTime = 0.3f; 
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target != null)
        {
            int index = cotroller.GetMapIndex();
            Vector3 targetPosition = target.position;

            // Giới hạn tọa độ của camera trong phạm vi minBounds và maxBounds
            targetPosition.x = Mathf.Clamp(targetPosition.x, minBounds[index].x, maxBounds[index].x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minBounds[index].y, maxBounds[index].y);
            targetPosition.z = transform.position.z; // Giữ nguyên tọa độ z của camera

            // Dịch chuyển camera mềm mại đến vị trí mới
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
