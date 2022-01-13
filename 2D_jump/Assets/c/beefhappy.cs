using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beefhappy : MonoBehaviour
{
    //如果被東西碰到

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //碰到肉肉就加分
        beef.Score = beef.Score + 1;

    }
    //碰撞肉肉後 肉肉消失

    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}
