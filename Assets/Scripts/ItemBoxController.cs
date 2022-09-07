using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // IsTrigger 가 체크되어있는 collider 와 충돌을 "시작했을 때"
        
        
        if (!other.CompareTag("EndPoint")) return;
        
        Debug.Log("EndPoint 와 부딪침");
        other.gameObject.SetActive(false);
        gameObject.SetActive(false);
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
