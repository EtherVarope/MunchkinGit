/********************************************************************
	created:	2017/12/22
	created:	22:12:2017   9:45
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\诅咒事件\Debuff_CreatEvent.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\诅咒事件
	file base:	Debuff_CreatEvent
	file ext:	cs
	author:		DLJ
	
	purpose:	针对诅咒事件,将诅咒卡中的string转化为对应的事件;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class Debuff_CreatEventOne:Base_Event
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
        public Debuff_CreatEventOne(MomentType momenttype=MomentType.None,int eventID=1, FunctionObjectType functionobjecttype=FunctionObjectType.None)
        {
            _eventStage = momenttype;//事件发动阶段;
            _eventID = eventID;//事件ID;
            _functionObject = functionobjecttype;//事件作用对象;
            _fatherCard = null;//初始无父类卡牌;
            _cardOfKickTheDoorAtPresent = null;
        }
        public override void Execute()
        {
            //事件接口;
            //-----------------------------------------------------------------------
            _cardOfKickTheDoorAtPresent= CoreDataObserver.GetInstance().Get_CardOfKickTheDoorAtPresent();//获取当前的踢门牌;
            if(_cardOfKickTheDoorAtPresent!=null && _cardOfKickTheDoorAtPresent.GetCardType()== CardType.DebuffCard)
            {
                //当前卡牌确实为诅咒卡;
                List<string> function = null;
                Base_Event events = null;
                function = _cardOfKickTheDoorAtPresent.GetDebuffCard().GetCurse();
                if(function!=null)
                {
                    foreach(string i in function)
                    {
                        //通过字符串从EventTable中获取对应的事件类型,制造出对应的事件;(注意:先将事件类型与对应的字符串注册到EventTable中);
                        events = EventFactory.GetInstance().GetEvent(i);
                        events.SetCard(_cardOfKickTheDoorAtPresent);//为此事件添加父类card;
                        EventQueue.GetInstance().PushEventForSecondqueue(events);//向事件队列中添加事件;

                    }

                }
            }
            else
            {
                //出错并不是诅咒卡;
                Console.WriteLine("此卡牌不是诅咒卡或者当前踢门卡为空");
                return;
            }




            //-----------------------------------------------------------------------

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
            _cardID = id;
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
        public override  void SetCard(Card card)
        {
            //设置此事件所属的卡牌;
            _fatherCard = card;
        }
        public override Card GetCard()
        {
            //获取此事件所属的卡牌;
            return _fatherCard;
        }
        //--------------------------------------------------------------------------
    }
}
