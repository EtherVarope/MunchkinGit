
/********************************************************************
	created:	2017/12/04
	created:	4:12:2017   9:45
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\Base_EventQueue.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test
	file base:	Base_EventQueue
	file ext:	cs
	author:		DLJ
	
	purpose:	事件队列;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Munchkin
{
    class EventQueue
    {
        //----------------------------------------------------------------
        private Base_Event base_event;
        private static EventQueue instance = null;
        private static object _lock = new object();
        private Queue<Base_Event> _firstqueue;//第一优先级队列;
        private Queue<Base_Event> _secondqueue;//第二优先级队列;
        //游戏阶段事件队列;
        //.........
        //.....
        //----------------------------------------------------------------
        public static EventQueue GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new EventQueue();
                    }
                }
            }
            return instance;
        }
        //----------------------------------------------------------------
        public Base_Event PopEvent()
        {

            //base_event = null;
            //获取队列首元素;
            if (_firstqueue.Count!=0)
            {
                //优先获取第一优先级队列;
                base_event = _firstqueue.Dequeue();

            }
            else
            {
                if(_secondqueue.Count!=0)
                {

                    base_event = _secondqueue.Dequeue();
                }
                else
                {
                    base_event = null;
                }
                
            }
         
            if(base_event!=null)
            {
                return base_event;
            }
            else
            {
                return null;
            }


        }
        //----------------------------------------------------------------
        public void PushEventForFirstqueue(Base_Event baseevent)
        {
            //向第一优先级队列中插入元素;
            if(baseevent!=null)
            {
                _firstqueue.Enqueue(baseevent);

            }

        }
        //----------------------------------------------------------------
        public void PushEventForSecondqueue(Base_Event baseevent)
        {
            //向第二优先级队列中插入元素;
            if (baseevent != null)
            {
                _secondqueue.Enqueue(baseevent);

            }
        }

        //----------------------------------------------------------------
        private EventQueue()
        {
            _firstqueue = new Queue<Base_Event>();
            _secondqueue = new Queue<Base_Event>();
            base_event = null;

        }
        //----------------------------------------------------------------
    }
}
