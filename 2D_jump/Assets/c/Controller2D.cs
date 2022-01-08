using UnityEngine;

/// <summary>
/// 控制器：2D 橫向捲軸模式
/// </summary>

public class Controller2D : MonoBehaviour
{
    #region 欄位：公開
    [Header("移動速度"), Range(0, 100)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 500;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRedius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode KeyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion

    /// <summary>
    /// 剛體元件 Rigidbody 2D
    /// </summary>
    private Rigidbody2D rig;

    /// <summary>
    /// 繪製圖示
    /// 在 unity 繪製輔助用圖示
    /// 線條、射線、圖形、方形、扇形、圖片
    /// 圖示 Gizmos 類別
    /// </summary>

    private void OnDrawGizmos()
    {
        //1. 決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        //2. 決定繪製圖形
        // transform.position 此物件為世界座標
        // transform.TransformDirection() 根據變形元件的區域座標轉換為世界座標
        Gizmos.DrawSphere(transform.position + transform.TransformDirection(checkGroundOffset),
            checkGroundRedius);
    }

    private void Start()
    {
        //剛體欄位 ＝ 取得元件<2D 剛體>()
        rig = GetComponent<Rigidbody2D>();
    }

    ///<summary>
    ///固定更新事件：50 FPS
    ///處理物理行為
    ///</summary>
    private void FixedUpdate()
    {
        Move();
    }


    #region 方法
    ///<summary>
    ///1. 玩家是否有按移動鍵 左右方向鍵 或 A、D
    ///2. 物件移動行為（API）
    ///</summary>
    private void Move()
    {
        //h值 指定為 輸入.取得軸向(水平線) - 水平軸代表左右鍵與 AD
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值：" + h);

        //剛體元件加速度.加速度 = 新 二維向量(h值 ＊ 移動速度,0);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        float U = Input.GetAxis("Vertical");
        print("玩家上下按鍵值：" + U);
    }

    ///<summary>
    ///翻面：
    ///h值 小於 0 左：角度 Y 180
    ///h值 大於 0 右：角度 Y 0
    ///</summary>

    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");

        //如果 h 小於 0 左：角度 Y 180
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 100, 0);
        }

        //如果 h值 大於 0 右：角度 Y 0
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }

    ///<summary>
    ///檢查是否在地板
    ///</summary>
    private void CheckGround()
    {

    }

    #endregion


}
