using UnityEngine;

// class 類別：一個物件藍圖
//語法：類別 類別名稱 {類別內容(類別成員)}
//此類別要在unity內使用，需繼承「MonBehaviour」
public class nohair : MonoBehaviour
{
    #region 欄位語法
    //欄  位 Field : 保存各種類型資料夾
    //語  法： 修飾詞 資料夾類型 欄位名稱 指定 預設值 結束符號
    //整  數： 無效數點之正負整數  - int
    //浮點數： 有小數點知正負數    - float
    //字  串： 文字資訊          - string
    //布林值： 是與否 ture、fales - bool
    //修飾詞
    //私人：其他類別不能存取、不顯示 -private(預設值)
    //公開：其他類別可以存取、顯示  -publiv
    //欄位屬性：Attritube
    //語法：[欄位屬性(值)]
    //標題 Header  (字母)
    //字串 Tooltip (字串)
    //範圍 Range   (最小值,最大值)
    
    [Header("血量"), Range(0,100)]
    public int blood = 100;
    #endregion
}