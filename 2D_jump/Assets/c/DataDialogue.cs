using System;
using UnityEngine;

// 建立專案內的選單(mennuName = "選單名單") 資料夾/子資料
[CreateAssetMenu(menuName = "Say/對話資料")]
///<summary>
///對話資料
/// 保存 NPC 要跟玩家對話內容
///</summary>
///Ｓcriptable Object 腳本化物件： 將程式資料儲存至 Project 內的物件
public class DataDialogue : ScriptableObject
{
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialongues;

    internal void StopDialogue()
    {
        throw new NotImplementedException();
    }

    internal void StartDialogue(string[] dialongues)
    {
        throw new NotImplementedException();
    }
}
