/********************************************************************
	created:	2017/12/26
	created:	26:12:2017   19:40
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\功能事件\PushAttackEnemyCards.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\功能事件
	file base:	PushAttackEnemyCards
	file ext:	cs
	author:		DLJ
	
	purpose:	如果当前为捣乱阶段或者施舍阶段,此事件将玩家所出的牌投递到特殊的事件队列中;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class PushAttackEnemyCards : Base_Event
    {
        //Data:
        //--------------------------------------------------------------------------
        private MomentType _eventStage;//事件发动阶段;
        private int _eventID;//事件ID;
        private int _cardID;//所属卡牌ID;
        private FunctionObjectType _functionObject;//事件作用对象;
        private Card _fatherCard;//此事件所属的卡牌;
        //--------------------------------------------------------------------------
        private Card _cardOfThePlayAtPresent;//当前打出的卡牌;
        //--------------------------------------------------------------------------
        public PushAttackEnemyCards(MomentType momenttype = MomentType.None, int eventID = 4, FunctionObjectType functionobjecttype = FunctionObjectType.None)
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
            _cardOfThePlayAtPresent = CoreDataObserver.GetInstance().Get_CardOfThePlayAtPresent();
            if(_cardOfThePlayAtPresent!=null)
            {
                //如果此卡牌不为空;
                //将其投递到卡牌队列中;
                CoreDataObserver.GetInstance().SetQueueOfAttackEnemyCards(_cardOfThePlayAtPresent);

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
