/********************************************************************
	created:	2017/12/24
	created:	24:12:2017   16:23
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\功能事件\GetACardOfKickTheDoor.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\功能事件
	file base:	GetACardOfKickTheDoor
	file ext:	cs
	author:		DLJ
	
	purpose:	将一张踢门牌获取到手牌中;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Munchkin
{
    class GetACardOfKickTheDoor:Base_Event
    {
        //Data:
        //--------------------------------------------------------------------------
        private MomentType _eventStage;//事件发动阶段;
        private int _eventID;//事件ID;
        private int _cardID;//所属卡牌ID;
        private FunctionObjectType _functionObject;//事件作用对象;
        private Card _fatherCard;//此事件所属的卡牌;
        //--------------------------------------------------------------------------
        private Card _cardOfKickTheDoorAtPresent;//当前抽到的踢门牌;
        //--------------------------------------------------------------------------
        public GetACardOfKickTheDoor(MomentType momenttype = MomentType.None, int eventID = 2, FunctionObjectType functionobjecttype = FunctionObjectType.None)
        {
            _eventStage = momenttype;//事件发动阶段;
            _eventID = eventID;//事件ID;
            _functionObject = functionobjecttype;//事件作用对象;
            _fatherCard = null;//初始无父类卡牌;
            _cardOfKickTheDoorAtPresent = null;
        }
        //----------------------------------------------------------------
        public override void Execute()
        {
            //事件接口;
            //----------------------------------------------------------------
            _cardOfKickTheDoorAtPresent = CoreDataObserver.GetInstance().Get_CardOfKickTheDoorAtPresent();//获取当前的踢门牌;
            if(_cardOfKickTheDoorAtPresent!=null)
            {
                _cardOfKickTheDoorAtPresent.SetPlayerId(CoreDataObserver.GetInstance().GetPlayer().GetId());//设置此卡牌的拥有者;
                CoreDataObserver.GetInstance().GetPlayer().SetCardInMyHand(_cardOfKickTheDoorAtPresent);//将当前的踢门牌加入手牌中;
                Debug.Log(CoreDataObserver.GetInstance().GetPlayer().GetCardInMyHand().Count);

            }
            
            //----------------------------------------------------------------

        }
        public override MomentType GetEventStage()
        {
            //获取事件发动的阶段;
            return _eventStage;
        }
        public override int GetEventID()
        {
            //获取事件ID;
            return _eventID;
        }
        public override void SetCardID(int id)
        {
            //设置该事件所属卡牌的ID;
            _eventID = id;
        }
        public override int GetCardID()
        {
            //获取事件所属的卡牌ID;
            return _cardID;

        }
        public override FunctionObjectType GetFunctionObjectType()
        {
            //获取事件作用对象;
            return _functionObject;

        }
        public override void SetCard(Card card)
        {
            //设置此事件所属的卡牌;
            _fatherCard = card;

        }
        public override Card GetCard()
        {
            //获取此事件所属的卡牌;
            return _fatherCard;
        }
        //事件类型;
        //----------------------------------------------------------------
    }
}
