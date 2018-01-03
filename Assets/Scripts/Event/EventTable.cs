/********************************************************************
	created:	2017/12/04
	created:	4:12:2017   15:05
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\EventTable.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test
	file base:	EventTable
	file ext:	cs
	author:		DLJ
	
	purpose:	将String与EventType进行映射;
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin
{
    class EventTable
    {
        //----------------------------------------------------------------
        private EventType _eventtype;
        private Dictionary<string, EventType> _dictionary;
        private static EventTable instance = null;
        private static object _lock = new object();
        //----------------------------------------------------------------
        public static EventTable GetInstance()
        {
            //获取当前对象的实例;
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new EventTable();
                    }
                }
            }
            return instance;
        }
        //----------------------------------------------------------------
        public EventType GetEventType(string fp_string)
        {
            //根据传入的string返回对应的EventType;
            EventType eventtype;
            if(_dictionary.TryGetValue(fp_string, out eventtype))
            {
                return eventtype;
            }
            else
            {
                return EventType.None;
            }
            
        }
        //----------------------------------------------------------------
        public bool RegisterEventType(string fp_string,EventType eventtype)
        {
            //对所传EventType进行注册;
            if(!(_dictionary.ContainsKey(fp_string)))
            {
                _dictionary.Add(fp_string, eventtype);
                return true;
            }
            else
            {
                return false;
            }


        }
        //----------------------------------------------------------------
        public bool DeleteEventType(String fp_string)
        {
            //将字符串对应的EventType删除;
            if(_dictionary.ContainsKey(fp_string))
            {
                return _dictionary.Remove(fp_string);

            }
            else
            {
                return false;
            }
        }
        //----------------------------------------------------------------

        private EventTable()
        {
            _dictionary = new Dictionary<string, EventType>();
            _eventtype = EventType.None;
        }
        //----------------------------------------------------------------
    }
}
