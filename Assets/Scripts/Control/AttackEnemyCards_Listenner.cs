/********************************************************************
	created:	2017/12/27
	created:	27:12:2017   9:57
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者\AttackEnemyCards_Listenner.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者
	file base:	AttackEnemyCards_Listenner
	file ext:	cs
	author:		DLJ
	
	purpose:	Queue<Card> _attackEnemyCards(对敌人释放的卡片)数据的观察者,当此队列中的数据不为空时触发此观察者;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class AttackEnemyCards_Listenner : Base_Listenner
    {
        //----------------------------------------------------------------
        //Data:

        private Card _attackEnemyCard;//对敌人释放的卡片;
        private Card _double;//替身;
        private string _name;//名字;

        //----------------------------------------------------------------
        public AttackEnemyCards_Listenner(string name)
        {
            _name = name;
            _attackEnemyCard = null;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }

        public AttackEnemyCards_Listenner()
        {

            //..........
            _name = "AttackEnemyCards_Listenner";
            _attackEnemyCard = null;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);


        }

        //----------------------------------------------------------------
        //事件组合器;
        public override void Update()
        {

            //-------------------------------------------------------------
            if(CoreDataObserver.GetInstance().GetQueueOfAttackEnemyCards().Count>0)
            {
                //当前的队列不为空;
                _attackEnemyCard = CoreDataObserver.GetInstance().GetQueueOfAttackEnemyCards().Dequeue();

                //---------------------------------------------------------
                //通过网络将数据(AttackEnemyCard)发送给特定的玩家;(需要启动协程么？！)

                //---------------------------------------------------------

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


