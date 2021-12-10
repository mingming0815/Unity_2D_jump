using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 對話系統
/// 將需要輸出的文字利用打字效果呈現
/// </summary>
public class DalongueSystem : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public Text textContent;

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect()
    {
        string test = "哈囉，咩～～";

        textContent.text = "";  //清除上次的對話內容
        goDialogue.SetActive(true);  //顯示對話物件

        for (int i = 0; i < test.Length; i++)
        {

            textContent.text += test[i];  //疊加對話內容物件
            yield return new WaitForSeconds(interval);

        }
    }
}
