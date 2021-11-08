using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR���ʪ���
/// 1. VR�`���I�ݨ즹���� OnPointerEnter
/// 2. VR�`���I�ݨ�����}������ OnPointerExit
/// 3. VR�`���I�ݨ즹������I�郎�ʫ��s OnPointerClick
/// </summary>
public class VRInteractiveObj : MonoBehaviour
{
    // Unity �ƥ�Ϊk
    // 1. �ޥ�Events �R�W�Ŷ�
    // 2. �w�qUnity Evnet �������ó]���}
    // 3. �Q�n���榹�ƥ󤺮e���a��I�s �ƥ�.Invoke();
    // 4. �ݩʭ��O�]�w�ƥ󤺮e

    [Header("�ƥ�:�ݨ�B���}�P�I��"),Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    ///<summary>
    ///VR�`���I�ݨ즹����
    ///</summary>
    public void OnPointerEnter()
    {
        onEnter.Invoke();
    }
    /// <summary>
    /// VR�`���I�ݨ�����}������
    /// </summary>
    public void OnPointerExit()
    {
        onExit.Invoke();
    }
    ///<summary>
    /// VR�`���I�ݨ즹����I�郎�ʫ��s
    ///</summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
