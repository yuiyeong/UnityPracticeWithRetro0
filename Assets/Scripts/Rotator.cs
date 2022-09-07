using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    void Update()
    {
        // Rendering frame rate 에 맞춰서 실행되므로, 1초에 x 만큼 가고 싶다면
        // x 를 frame 과 frame 사이의 시간(Time.deltaTime)으로 조정해서 사용해야함
        float deltaAngle = 30 * speed * Time.deltaTime;
        transform.Rotate(deltaAngle, deltaAngle, deltaAngle);
    }
}