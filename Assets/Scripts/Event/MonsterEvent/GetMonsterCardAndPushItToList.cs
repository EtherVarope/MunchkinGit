/********************************************************************
	created:	2017/12/29
	created:	29:12:2017   11:06
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\怪兽事件\GetMonsterCardAndPushItToList.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件\怪兽事件
	file base:	GetMonsterCardAndPushItToList
	file ext:	cs
	author:		DLJ
	
	purpose:	将当前的踢门牌上的怪兽卡牌存入怪兽容器中;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class GetMonsterCardAndPushItToList : Base_Event
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
        public GetMonsterCardAndPushItToList(MomentType momenttype = MomentType.None, int eventID = 5, FunctionObjectType functionobjecttype = FunctionObjectType.None)
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
            //将当前的踢门牌存入_cardOfTheMonsterAtPresent中;
            Card monstercard = CoreDataObserver.GetInstance().Get_CardOfKickTheDoorAtPresent();
            if(monstercard != null && monstercard.GetCardType()==CardType.MonsterCard)
            {
                //卡片不为空且为怪兽卡片;
                //将其存入list中;
                CoreDataObserver.GetInstance().SetCardOfTheMonsterAtPresent(monstercard);

            }
            else
            {
                Console.WriteLine("当前的踢门牌为空,或者当前的卡片不为怪兽卡");
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
