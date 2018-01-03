using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Munchkin
{
    public class UI_HandCard : MonoBehaviour
    {
        public static UI_HandCard Instance;
        void Awake()
        {
            Instance = this;
        }
        void Start()
        {
   
        }
        //加入手牌UI对象
        public void InsertCard(Card _insertCard)
        {
            GameObject newHandCard = Resources.Load<GameObject>("UI/Prefabs/UI_CardDefine");
            newHandCard.GetComponent<UI_CardDefine>()._cardName.text = _insertCard._name;
            GameObject.Instantiate(newHandCard,this.transform);
        }

    }
}