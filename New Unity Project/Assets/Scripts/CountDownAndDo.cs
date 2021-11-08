using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// 倒數計時
/// 並且執行事件
/// 例如:離開遊戲、重新遊戲、顯示選單
/// </summary>
public class CountDownAndDo : MonoBehaviour
{
    #region
    [Header("倒數時間"), Range(1, 5)]
    public float timeCount = 3f;
    [Header("要執行的事件")]
    public UnityEvent onTimeUp;
    [Header("介面")]
    public Image imgBar;

    private float timeMax;

    /// <summary>
    /// 開始倒數 : true 停止:false
    /// Unity Event 可以存取
    /// 1.實體物件存取元件內的API
    /// 2.存取公開方法僅限 :0-1個參數，有資料類型限制(基本類型)
    /// 3.存取公開屬性 : 有資料類型限制(基本類型)
    /// </summary>
    public bool startCountDown { get; set; }
    #endregion

    private void Awake()
    {
        timeMax = timeCount;
    }

    private void Update()
    {
        CountDown();
      
    }
    //計時器
    private float timer;

    //倒數功能
    private void CountDown()
    {
        if(startCountDown)                          //如果開始倒數
        {
            
            if (timer < timeCount)                   //如果計時器小於倒數時間
            {
                timer += Time.deltaTime;           //累加時間(於Update內呼叫)
            }
            else
            {
                onTimeUp.Invoke();                  //計時器大於等於倒數時間就呼叫事件
            }
            imgBar.fillAmount = timer / timeMax;    //長度 = 當前時間 / 最大時間
        }
        else
        {
            timer = 0;
            imgBar.fillAmount = 0;
        }
    }
}
