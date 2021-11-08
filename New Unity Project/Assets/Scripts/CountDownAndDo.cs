using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// �˼ƭp��
/// �åB����ƥ�
/// �Ҧp:���}�C���B���s�C���B��ܿ��
/// </summary>
public class CountDownAndDo : MonoBehaviour
{
    #region
    [Header("�˼Ʈɶ�"), Range(1, 5)]
    public float timeCount = 3f;
    [Header("�n���檺�ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imgBar;

    private float timeMax;

    /// <summary>
    /// �}�l�˼� : true ����:false
    /// Unity Event �i�H�s��
    /// 1.���骫��s�����󤺪�API
    /// 2.�s�����}��k�ȭ� :0-1�ӰѼơA�������������(������)
    /// 3.�s�����}�ݩ� : �������������(������)
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
    //�p�ɾ�
    private float timer;

    //�˼ƥ\��
    private void CountDown()
    {
        if(startCountDown)                          //�p�G�}�l�˼�
        {
            
            if (timer < timeCount)                   //�p�G�p�ɾ��p��˼Ʈɶ�
            {
                timer += Time.deltaTime;           //�֥[�ɶ�(��Update���I�s)
            }
            else
            {
                onTimeUp.Invoke();                  //�p�ɾ��j�󵥩�˼Ʈɶ��N�I�s�ƥ�
            }
            imgBar.fillAmount = timer / timeMax;    //���� = ��e�ɶ� / �̤j�ɶ�
        }
        else
        {
            timer = 0;
            imgBar.fillAmount = 0;
        }
    }
}
