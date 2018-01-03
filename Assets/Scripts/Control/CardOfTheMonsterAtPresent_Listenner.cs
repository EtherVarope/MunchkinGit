/********************************************************************
	created:	2017/12/29
	created:	29:12:2017   14:55
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者\CardOfTheMonsterAtPresent_Listenner.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者
	file base:	CardOfTheMonsterAtPresent_Listenner
	file ext:	cs
	author:		DLJ
	
	purpose:	当前场地上怪兽容器的观察者;(如果场地上的怪兽容器不为空,则调用此观察者)
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class CardOfTheMonsterAtPresent_Listenner : Base_Listenner
    {
        //----------------------------------------------------------------
        //Data:

        
        private Card _double;//替身;
        private string _name;//名字;

        //----------------------------------------------------------------
        public CardOfTheMonsterAtPresent_Listenner(string name)
        {
            _name = name;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }

        public CardOfTheMonsterAtPresent_Listenner()
        {

            //..........
            _name = "CardOfTheMonsterAtPresent_Listenner";
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);


        }

        //----------------------------------------------------------------
        //事件组合器;
        public override void Update()
        {

            //-------------------------------------------------------------
            if (CoreDataObserver.GetInstance().GetCardOfTheMonsterAtPresent().Count>0 && CoreDataObserver.GetInstance().GetMomentTypeAtPresent()!=MomentType.CombatPhase)
            {
                //当前场地上的怪兽容器存在怪兽卡片,并且当前游戏阶段不为战斗阶段,则执行此函数;
                //将当前的游戏阶段设置为战斗阶段;
                EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("ChangeMomentType_CombatPhase"));//投递事件;

            }

            //-------------------------------------------------------------

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
