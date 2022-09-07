using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool IsDefeated { get; private set; }

    void OnTriggerEnter(Collider other)
    {
        // IsTrigger 가 체크되어있는 collider 와 충돌을 "시작했을 때"


        if (other.CompareTag("EndPoint"))
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);

            IsDefeated = true;
        }
    }

    private void OnEnable()
    {
        IsDefeated = false;
    }

    private void OnTriggerExit(Collider other)
    {
        // IsTrigger 가 체크되어있는 collider 와 충돌을 "끝났을 때"
    }

    private void OnTriggerStay(Collider other)
    {
        // IsTrigger 가 체크되어있는 collider 와 충돌을 "하는 동안"
    }

    private void OnCollisionEnter(Collision collision)
    {
        // IsTrigger 가 false Collider(일반 Collider) 와 충돌했을 때
    }
}