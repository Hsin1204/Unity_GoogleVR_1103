using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR互動物件
/// 1. VR注視點看到此物件 OnPointerEnter
/// 2. VR注視點看到後離開此物件 OnPointerExit
/// 3. VR注視點看到此物件並點選互動按鈕 OnPointerClick
/// </summary>
public class VRInteractiveObj : MonoBehaviour
{
    // Unity 事件用法
    // 1. 引用Events 命名空間
    // 2. 定義Unity Evnet 類型欄位並設公開
    // 3. 想要執行此事件內容的地方呼叫 事件.Invoke();
    // 4. 屬性面板設定事件內容

    [Header("事件:看到、離開與點擊"),Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    ///<summary>
    ///VR注視點看到此物件
    ///</summary>
    public void OnPointerEnter()
    {
        onEnter.Invoke();
    }
    /// <summary>
    /// VR注視點看到後離開此物件
    /// </summary>
    public void OnPointerExit()
    {
        onExit.Invoke();
    }
    ///<summary>
    /// VR注視點看到此件並點選互動按鈕
    ///</summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
