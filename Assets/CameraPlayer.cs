using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform target; // Đối tượng mà camera sẽ theo dõi
    public Vector2 minBounds; // Giới hạn tối thiểu của camera
    public Vector2 maxBounds; // Giới hạn tối đa của camera

    public float smoothTime = 0.3f; // Thời gian mềm mại khi camera di chuyển
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target != null)
        {
            // Lấy tọa độ hiện tại của camera
            Vector3 targetPosition = target.position;

            // Giới hạn tọa độ của camera trong phạm vi minBounds và maxBounds
            targetPosition.x = Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y);
            targetPosition.z = transform.position.z; // Giữ nguyên tọa độ z của camera

            // Dịch chuyển camera mềm mại đến vị trí mới
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
