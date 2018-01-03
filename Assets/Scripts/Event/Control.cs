/********************************************************************
	created:	2017/12/05
	created:	5:12:2017   10:20
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\Control.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test
	file base:	Control
	file ext:	cs
	author:		DLJ
	
	purpose:	control
*********************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Munchkin
{
    class Control:MonoBehaviour
    {
        private static Control instance;
   
        //----------------------------------------------------------------
        public static Control GetInstance()
        {
            return instance;
          
        }

        //----------------------------------------------------------------
        public void Run()
        {
            //----------------------------------------------------------------
            //初始化;(携程申请,初始化牌堆.......//有关卡牌的东西都以发事件的方式进行)
            //游戏主逻辑流程;
            BaseEventListener();
            //CoreDataObserver.GetInstance().SetMomentTypeAtPresent(MomentType.KickTheDoor);
            CoreDataObserver.GetInstance().Set_CardOfThePlayAtPresent(UI_PlayerPanel.Instance.ReturnACard());
            //CoreDataObserver.GetInstance().Set_CardOfThePlayAtPresent(UI_PlayerPanel.Instance.ReturnBCard());
            //CoreDataObserver.GetInstance().Set_CardOfThePlayAtPresent(UI_PlayerPanel.Instance.ReturnCCard());
        


            //while (true)
            //{
             

            //}
            //...........
            //........
            //.....
            //----------------------------------------------------------------
        }

        public void  BaseEventListener()
        {
            ExecuteEvent.GetInstance().EventProcessing();
          
        }
        //----------------------------------------------------------------
        void Awake()
        {
            //Debug.Log(CoreDataObserver.GetInstance().GetList().Count());
        }
        void Start()
        {
            instance = this;
            AttackEnemyCards_Listenner atkEnemyCardsListener = new AttackEnemyCards_Listenner();
            CardOfKickTheDoorAtPresent_Listenner cardOfKickTheDoorAtPresentListener = new CardOfKickTheDoorAtPresent_Listenner();
            CardOfTheMonsterAtPresent_Listenner cardOfTheMonsterAtPresentListener = new CardOfTheMonsterAtPresent_Listenner();
            CardOfThePlayAtPresent_Listenner cardOfThePlayAtPresent_Listener = new CardOfThePlayAtPresent_Listenner();
            MomentTypeAtPresent_Listenner momentTypeAtPresent_Listener = new MomentTypeAtPresent_Listenner();
      
            CoreDataObserver.GetInstance().AddListenner(momentTypeAtPresent_Listener);
            PlayerDefine player = new PlayerDefine(1, "小磊君");
            CoreDataObserver.GetInstance().SetPlayer(player);//初始化玩家;
            EventTable.GetInstance().RegisterEventType("GetACardOfKickTheDoor", EventType.GetACardOfKickTheDoor);
            EventTable.GetInstance().RegisterEventType("PushAttackEnemyCards", EventType.PushAttackEnemyCards);
            EventTable.GetInstance().RegisterEventType("Magic_CreatEvent", EventType.Magic_CreatEvent);
            EventTable.GetInstance().RegisterEventType("Debuff_CreatEventOne", EventType.Debuff_CreatEventOne);
            EventTable.GetInstance().RegisterEventType("GetMonsterCardAndPushItToList", EventType.GetMonsterCardAndPushItToList);
            EventTable.GetInstance().RegisterEventType("SetACardOfKickTheDoor", EventType.SetACardOfKickTheDoor);
            EventTable.GetInstance().RegisterEventType("ChangeMomentType_CombatPhase", EventType.ChangeMomentType_CombatPhase);
            ////---------------------------------------------------------------------------------------------------------
            ////Test:
            EventTable.GetInstance().RegisterEventType("TestOneEvent", EventType.TestOneEvent);
            EventTable.GetInstance().RegisterEventType("TestTwoEvent", EventType.TestTwoEvent);
            EventTable.GetInstance().RegisterEventType("TestThreeEvent", EventType.TestThreeEvent);
            Run();
        }
        //----------------------------------------------------------------
    }
}
