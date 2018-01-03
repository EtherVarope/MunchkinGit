using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Munchkin
{
    public class HandCard : MonoBehaviour
    {
        public static HandCard Instance;
        public List<Card> _handCard;

        void Awake()
        {
            Instance = this;
        }
        void Start()
        {
       

            _handCard = new List<Card>();
        }
        /// <summary>
        /// 从服务器拿到Card 并加入手牌中
        /// </summary>
        public void GetCardFromServer(Card _getCard)
        {
            //校验卡牌数量
            _handCard.Add(_getCard);
            //通知UI更新手牌显示
            UI_HandCard.Instance.InsertCard(_getCard);

        }
    }
}
