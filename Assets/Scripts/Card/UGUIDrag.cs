using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]

public class UGUIDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private Vector2 orignPoint;
    private bool isDrag = false;
    //偏移量
    private Vector3 offset = Vector3.zero;

    public void OnBeginDrag(PointerEventData eventData)
    {
          
        isDrag = false;
        SetDragObjPostion(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        isDrag = true;
        SetDragObjPostion(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
     
        SetDragObjPostion(eventData);
    }
    
    void SetDragObjPostion(PointerEventData eventData)
    {
        RectTransform rect = this.GetComponent<RectTransform>();
        Vector3 mouseWorldPosition;

        //判断是否点到UI图片上的时候
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, eventData.position, eventData.pressEventCamera, out mouseWorldPosition))
        {
            if (isDrag)
            {
                rect.position = mouseWorldPosition + offset;
            }
            else
            {
                //计算偏移量
                offset = rect.position - mouseWorldPosition;
            }
                       
        }
        if (rect.localPosition.y <= 350)
        {
            Debug.Log("不出牌，收回");
        }
        if (rect.localPosition.y > 350)
        {
            Debug.Log("出牌");
                
            DestroyImmediate(this.gameObject);
        }

    }

    
}