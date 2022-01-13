using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walehappy : MonoBehaviour
{
  //如果被東西碰到

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //碰到肉肉就加分
        wale.Score = wale.Score + 1;

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
