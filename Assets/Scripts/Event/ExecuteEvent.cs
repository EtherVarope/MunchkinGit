/********************************************************************
	created:	2017/12/05
	created:	5:12:2017   9:27
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\ExecuteEvent.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test
	file base:	ExecuteEvent
	file ext:	cs
	author:		DLJ
	
	purpose:	事件执行;
*********************************************************************/
using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Munchkin
{
    class ExecuteEvent:MonoBehaviour
    {
        //----------------------------------------------------------------
        private static ExecuteEvent instance ;

        private Base_Event baseevent;
        //----------------------------------------------------------------
        public static ExecuteEvent GetInstance()
        {
   
            return instance;
        }

        //----------------------------------------------------------------
        public void EventProcessing()
        {
            Debug.Log(2333333);
            StartCoroutine(Processing());
        }

       IEnumerator Processing()
        {
            while (true)
            {
                baseevent = EventQueue.GetInstance().PopEvent();
                if (baseevent != null)
                {
                    baseevent.Execute();
                }
                yield return new WaitForSeconds(0.5f);

            }
        }
        //----------------------------------------------------------------
        void Start()
        {
          
            baseevent = null;
        }
        void Awake()
        {
            instance = this;

        }
        //----------------------------------------------------------------
    }
}
