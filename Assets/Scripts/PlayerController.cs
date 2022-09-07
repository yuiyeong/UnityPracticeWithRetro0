using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Debug.Assert(_rigidbody != null);
    }

    void Update()
    {
        // 발사 기능에 "Fire" 라는 추상화된 이름을, 앉는 기능에 "Crunch" 붙여 실제 keyboard 나 mouse button 클릭과 분리
        // Unity -> Edit -> ProjectSettings -> Input 에 보면 Axes 탭이 있는데 거기서 설정 가능.

        // KeyCode.A 와 KeyCode.D 대신에 사용. 조이스틱일 때 도 받을 수 있음
        // 방향에 대한 값을 확인 (-1.0 ~ 0.0 ~ 1.0)
        // true false 가 아니라 숫자 값인 것은 조이스틱은 변화량으로 오므로
        float inputX = Input.GetAxis("Horizontal");
        float speedY = _rigidbody.velocity.y; // 원래 떨어지는 속도(중력 가속도와 중량에 의한 떨어지는 속도) 유지를 위해
        float inputZ = Input.GetAxis("Vertical");

        // 힘으로 주면 관성 작용 가능
        // rigidbody.AddForce(inputX * speed, 0, inputZ * speed);

        // 그냥 바로 변경이 되고 싶으면 속도를 사용해야함.
        _rigidbody.velocity = speed * new Vector3(inputX, speedY, inputZ);
    }
}