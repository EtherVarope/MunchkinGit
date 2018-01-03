/********************************************************************
	created:	2017/12/11
	created:	11:12:2017   11:20
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件处理\Base_Listenner.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件处理
	file base:	Base_Listenner
	file ext:	cs
	author:		DLJ
	
	purpose:	观察者基类;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    abstract class Base_Listenner
    {
        //----------------------------------------------------------------
        //事件组合器;
        public abstract void Update( );//游戏阶段更新;
        public abstract string GetLinstennerName();//获取观察者名字;
        //public abstract void PushEvent(Base_Event base_event);//事件投递;

        //----------------------------------------------------------------
    }
}
