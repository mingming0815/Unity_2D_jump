using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beef : MonoBehaviour
{
    //宣告分數參數
    public static int Score;

    //宣告文字
    public Text ShowScore;

    void Start()
    {
        //分數初始化
        Score = 0;
    }

    private void Update()
    {
        //讓UI文字與分數同步
        ShowScore.text = Score.ToString();
    }
}
