/********************************************************************
	created:	2017/12/13
	created:	13:12:2017   16:29
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者\CardOfKickTheDoorAtPresent_Listenner.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者
	file base:	CardOfKickTheDoorAtPresent_Listenner
	file ext:	cs
	author:		DLJ
	
	purpose:	踢门牌数据观察者;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Munchkin
{
    class CardOfKickTheDoorAtPresent_Listenner:Base_Listenner
    {
        //----------------------------------------------------------------
        //Data:
        private Card _cardOfKickTheDoorAtPresent;//当前抽到的踢门牌;
        private Card _double;//替身;
        private string _name;//名字;
        //----------------------------------------------------------------
        public CardOfKickTheDoorAtPresent_Listenner(string name)
        {
            _name = name;
            _cardOfKickTheDoorAtPresent = null;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }
        public CardOfKickTheDoorAtPresent_Listenner()
        {
            //..........
            _name = "CardOfKickTheDoorAtPresent_Listenner";
            _cardOfKickTheDoorAtPresent = null;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }
        //----------------------------------------------------------------
        //事件组合器;
        public override void Update()
        {
            //游戏阶段更新;

            _double = CoreDataObserver.GetInstance().Get_CardOfKickTheDoorAtPresent();//获取最新的卡牌数据;
            if(_double!= _cardOfKickTheDoorAtPresent)
            {
                _cardOfKickTheDoorAtPresent = _double;
                //-------------------------------------------------------------------------------------------------
                //Do something:
                //Put event;
                switch(_cardOfKickTheDoorAtPresent.GetCardType())
                {
                    case CardType.DebuffCard:
                        //-----------------------------------------------------------------------------------------
                        //当前抽到的卡片为诅咒卡和即时魔法卡;
                        EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("Debuff_CreatEventOne"));//投递事件;

                        //-----------------------------------------------------------------------------------------
                        break;
                    case CardType.MonsterCard:
                        //-----------------------------------------------------------------------------------------
                        //当前抽到的卡片为怪兽卡;
                        EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent(" GetMonsterCardAndPushItToList"));

                        //-----------------------------------------------------------------------------------------
                        break;

                    default:
                        //-----------------------------------------------------------------------------------------
                        //其余卡片;(将此卡片加入手牌中)
                        EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("GetACardOfKickTheDoor"));//投递事件;
                        //------------------------------------------------------------------------------------------
                        //Test:
                        //当前的手牌

                        //-----------------------------------------------------------------------------------------
                        break;
                }

                //-------------------------------------------------------------------------------------------------

            }

        }

        //----------------------------------------------------------------
        public override string GetLinstennerName()
        {
            return _name;
            //获取观察者名字;
        }
        //----------------------------------------------------------------
    }
}
