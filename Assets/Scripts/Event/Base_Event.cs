/********************************************************************
	created:	2017/12/04
	created:	4:12:2017   9:36
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\BaseEvent.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test
	file base:	BaseEvent
	file ext:	cs
	author:		DLJ
	purpose:	事件类型抽象类;
*********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    abstract class Base_Event
    {
        //----------------------------------------------------------------
        public abstract void Execute();//事件接口;
        public abstract MomentType GetEventStage();//获取事件发动的阶段;
        public abstract int GetEventID();//获取事件ID;
        public abstract void SetCardID(int id);//设置该事件所属卡牌的ID;
        public abstract int GetCardID();//获取事件ID;
        public abstract FunctionObjectType GetFunctionObjectType();//获取事件作用对象;
        public abstract void SetCard(Card card);//设置此事件所属的卡牌;
        public abstract Card GetCard();//获取此事件所属的卡牌;
        //事件类型;
        //----------------------------------------------------------------
    }
}
