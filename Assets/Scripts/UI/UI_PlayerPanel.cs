using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Munchkin {
    public class UI_PlayerPanel : BaseUI {

        public static UI_PlayerPanel Instance;
        public Button Btn_EndTurn;
        public Button Btn_Start;
        public override void Install_UI()
        {
            Btn_EndTurn.onClick.AddListener(OnClickEndTurn);
            Instance = this;
      

        }

        public override void Uninstall_UI()
        {

        }

        public void OnClickEndTurn()
        {
            //通知服务器结束此回合
            
            Card _card = Resources.Load<Card>("Game/Card/Card/Card_Define");
            Debug.Log(_card._name);
            //服务器把卡牌数据传过来，通过json给模板赋值
            //公示阶段 
            HandCard.Instance.GetCardFromServer(_card);
        }
        public Card ReturnACard()
        {
            Card _card = Resources.Load<Card>("Game/Card/Card/Magic_Card");
            return _card;
        }
        public Card ReturnBCard()
        {
            Card _card = Resources.Load<Card>("Game/Card/Card/Magic_Card 1");
            return _card;
        }
        public Card ReturnCCard()
        {
            Card _card = Resources.Load<Card>("Game/Card/Card/Magic_Card 2");
            return _card;
        }
        public void OnClickStart()
        {
            Control.GetInstance().Run();
        }

    }
}