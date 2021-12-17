using UnityEngine;

/// <summary>
/// Npc 行為
/// 偵測目標進入碰撞區
/// 顯示對話系統
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public DataDialogue dataDialogue;
    [Header("對話系統")]
    public DalongueSystem dialogueSystem;
    [Header("觸發對象之對象")]
    public string target = "和尚";

    //觸發開始事件
    //1.兩個物件都要有 collider 2D
    //2.兩個要有一個有 Rigidnody 2D (兩個都有也可以)
    //3.其中有一個要勾選 trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StartDialogue(dataDialogue.dialongues);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StopDialogue();
        }
    }
}
