using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 收集寶物
/// </summary>

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
        HurtSystem ruby = collision.GetComponent<HurtSystem>();
        print("碰到的東西：" + rubyGO);
        rubyGO.ChamgeHealth(1);
        Destroy(gameObject);
        }
}
