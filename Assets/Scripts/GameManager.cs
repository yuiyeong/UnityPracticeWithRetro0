using UnityEngine;

public class GameManager : MonoBehaviour
{
    private ItemBox[] _boxes;

    void Start()
    {
        _boxes = FindObjectsOfType<ItemBox>();

        Debug.Assert(_boxes != null);
    }

    void Update()
    {
        foreach (var box in _boxes)
        {
            if (!box.IsDefeated) return;
        }

        Debug.Log("Is Won");
    }
}