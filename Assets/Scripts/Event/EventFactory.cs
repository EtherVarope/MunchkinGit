/********************************************************************
	创建时间:	2017/12/29;29:12:2017   15:33
	文件路径: 	F:\Unity3D Project5.6\Munchkin\Assets\Scripts\Event\EventFactory.cs
	文件名:	EventFactory
	文件类型t:	cs
	文件作者:		Author
//-------------------------------------------------------------------------------/
	主题:	事件工厂
	功能:       
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class EventFactory
    {
        //----------------------------------------------------------------
        private Base_Event base_event;
        private static EventFactory instance = null;
        private static object _lock = new object();
        //----------------------------------------------------------------
        public static EventFactory GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new EventFactory();
                    }
                }
            }
            return instance;
        }

        //----------------------------------------------------------------
        public Base_Event GetEvent(string fp_string)
        {
            switch(EventTable.GetInstance().GetEventType(fp_string))
            {

                case EventType.None:
                    //----------------------------------------------------
                    //base_event=new  ******
                    //----------------------------------------------------
                    break;
                case EventType.Debuff_CreatEventOne:
                    //----------------------------------------------------
                    base_event = new Debuff_CreatEventOne();
                    //----------------------------------------------------
                    break;

                case EventType.GetACardOfKickTheDoor:
                    //----------------------------------------------------
                    base_event = new GetACardOfKickTheDoor();
                    //----------------------------------------------------
                    break;
                case EventType.Magic_CreatEvent:
                    //----------------------------------------------------
                    base_event = new Magic_CreatEvent();
                    //----------------------------------------------------
                    break;
                case EventType.PushAttackEnemyCards:
                    //-----------------------------------------------------
                    base_event = new PushAttackEnemyCards();
                    break;
                //------------------------------------------------------
                case EventType.GetMonsterCardAndPushItToList:
                    base_event = new GetMonsterCardAndPushItToList();
                    break;
                //------------------------------------------------------
                case EventType.SetACardOfKickTheDoor:
                    base_event = new SetACardOfKickTheDoor();
                    break;
                //------------------------------------------------------

                case EventType.ChangeMomentType_CombatPhase:
                    base_event = new ChangeMomentType_CombatPhase();
                    break;
                //------------------------------------------------------
                case EventType.TestOneEvent:
                    base_event = new TestOneEvent();
                    break;
                //------------------------------------------------------
                case EventType.TestTwoEvent:
                    base_event = new TestOneEvent();
                    break;
                //------------------------------------------------------
                case EventType.TestThreeEvent:
                    base_event = new TestOneEvent();
                    break;
                default:
                    break;

            }
            //----------------------------------------------------
            if (base_event!=null)
            {
                return base_event;

            }
            else
            {
                return null;
            }
            //----------------------------------------------------
        }



        //----------------------------------------------------------------
        private EventFactory()
        {
            base_event = null;
        }
        //----------------------------------------------------------------

    }
}
