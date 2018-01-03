/********************************************************************
	created:	2017/12/26
	created:	26:12:2017   14:35
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\魔法事件\Magic_CreatEvent.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\魔法事件
	file base:	Magic_CreatEvent
	file ext:	cs
	author:		DLJ
	
	purpose:	将魔法卡中的特殊事件制造并且投递到事件队列中;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class Magic_CreatEvent:Base_Event
    {
        //Data:
        //--------------------------------------------------------------------------
        private MomentType _eventStage;//事件发动阶段;
        private int _eventID;//事件ID;
        private int _cardID;//所属卡牌ID;
        private FunctionObjectType _functionObject;//事件作用对象;
        private Card _fatherCard;//此事件所属的卡牌;
        //--------------------------------------------------------------------------
        private Card _cardOfThePlayAtPresent;//当前玩家出的卡牌;
        //--------------------------------------------------------------------------
        public Magic_CreatEvent(MomentType momenttype = MomentType.None, int eventID = 3, FunctionObjectType functionobjecttype = FunctionObjectType.None)
        {
            _eventStage = momenttype;//事件发动阶段;
            _eventID = eventID;//事件ID;
            _functionObject = functionobjecttype;//事件作用对象;
            _fatherCard = null;//初始无父类卡牌;
            _cardOfThePlayAtPresent = null;
        }
        //----------------------------------------------------------------
        public override void Execute()
        {
            //事件接口;
            //----------------------------------------------------------------
            _cardOfThePlayAtPresent = CoreDataObserver.GetInstance().Get_CardOfThePlayAtPresent();//获取当前打出的卡牌;
            if (_cardOfThePlayAtPresent != null && _cardOfThePlayAtPresent.GetCardType() == CardType.MagicCard)
            {
                //当前卡牌确实为魔法卡;
                List<string> function = null;
                Base_Event events = null;
                function = _cardOfThePlayAtPresent.GetMagic().GetMagicFunction();
                if (function != null)
                {
                    foreach (string i in function)
                    {
                        //通过字符串从EventTable中获取对应的事件类型,制造出对应的事件;(注意:先将事件类型与对应的字符串注册到EventTable中);
                        events = EventFactory.GetInstance().GetEvent(i);
                        events.SetCard(_cardOfThePlayAtPresent);//为此事件添加父类card;
                        EventQueue.GetInstance().PushEventForSecondqueue(events);//向事件队列中添加事件;

                    }

                }
            }
            else
            {
                //出错并不是魔法卡;
                Console.WriteLine("此卡牌不是魔法卡或者当前出的卡片为空");
                return;
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
