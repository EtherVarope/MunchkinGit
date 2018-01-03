/********************************************************************
	created:	2017/12/27
	created:	27:12:2017   15:05
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者\MomentTypeAtPresent_Listenner.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者
	file base:	MomentTypeAtPresent_Listenner
	file ext:	cs
	author:		DLJ
	
	purpose:	当前游戏所属的阶段观察者,根据不同的阶段触发不同的事件响应;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Munchkin
{
    class MomentTypeAtPresent_Listenner:Base_Listenner
    {
        //----------------------------------------------------------------
        //Data:

        private MomentType _momentType;//对敌人释放的卡片;
        private MomentType _double;//替身;
        private string _name;//名字;

        //----------------------------------------------------------------
        public MomentTypeAtPresent_Listenner(string name)
        {
            _name = name;
            _momentType = MomentType.None;
            _double = MomentType.None;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }

        public MomentTypeAtPresent_Listenner()
        {

            //..........
            _name = "MomentTypeAtPresent_Listenner";
            _momentType = MomentType.None;
            _double = MomentType.None;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);


        }

        //----------------------------------------------------------------
        //事件组合器;
        public override void Update()
        {
            //事件处理;
            //------------------------------------------------------------
            _double = CoreDataObserver.GetInstance().GetMomentTypeAtPresent();//获取当前的状态;
            if(_double!=_momentType)
            {
               
                _momentType = _double;//触发了新的状态;
                //------------------------------------------------------------------------------------------------
                //Do something:
                //Put event;
                switch(_momentType)
                {
                    case MomentType.KickTheDoor:
                        Debug.Log("MomentTypeAtPresent_Listenner");
                        EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("SetACardOfKickTheDoor"));//投递事件;
                        //----------------------------------------------------------------------------------------
                        //当前为踢门牌阶段;
                        //从踢门牌堆中获取一张卡牌;
                        //.............
                        //......
                        //...
                        //----------------------------------------------------------------------------------------
                        break;

                    case MomentType.FreePhase:
                        //----------------------------------------------------------------------------------------
                        //当前为自由阶段;(抽到的踢门牌不为怪兽卡)
                        Console.WriteLine("当前为自由阶段,在此阶段你可以做任何想做的事情,阶段持续时间为10S,时间结束后,强制结束你的回合");

                        //----------------------------------------------------------------------------------------
                        break;

                    case MomentType.CombatPhase:
                        //----------------------------------------------------------------------------------------
                        //当前为战斗阶段;(怪兽List不为空的时候)
                        Console.WriteLine("当前为战斗阶段");

                        //----------------------------------------------------------------------------------------
                        break;

                    //----------------------------------------------------------------------------------------
                    default:
                        break;
                }

                //-------------------------------------------------------------------------------------------------

            }



            //------------------------------------------------------------
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
