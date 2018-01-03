/********************************************************************
	created:	2017/12/11
	created:	11:12:2017   11:17
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件处理\Base_Notifier.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\事件处理
	file base:	Base_Notifier
	file ext:	cs
	author:		DLJ
	
	purpose:	发布者基类;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Munchkin
{
     class CoreDataObserver
    {
        //Data:
        //----------------------------------------------------------------
        private static CoreDataObserver instance = null;
        private static object _lock = new object();
        private List<Base_Listenner> _listennerList;//观察者集合;
        private Card _cardOfKickTheDoorAtPresent;//当前抽到的踢门牌;(***)
        private Card _cardOfThePlayAtPresent;//当前打出的卡牌;(***)
        private bool _isYouRound;//是否是你的回合;
        Queue<Card> _attackEnemyCards; //对敌人释放的卡片;
        private MomentType _momentTypeAtPresent;//当前处于的游戏阶段;
        //----------------------------------------------------------------
        //全场地数据;
        //<player,踢门牌>;
        //----------------------------------------------------------------
        //CoreData:
        //本人中心数据;

        PlayerDefine _mySelf;//自己角色;
        Queue<Card> _enemyCards;//敌人对本人所使用的卡牌;
        //其余角色[];


        //敌对玩家的出牌场所;//每个阶段固定清空;
        //敌对玩家的事件投放场所;list[];

        //----------------------------------------------------------------
        //对于职业;
        private bool _haveOccupation;//是否拥有了新的职业;
        private bool _loseOccupation;//是否要失去一个职业;
        //----------------------------------------------------------------
        //对于装备;
        private bool _haveEquipment;//是否拥有了一个新的装备;
        private bool _loseEquipment;//是否失去了一个装备;
        //----------------------------------------------------------------
        //对于诅咒;
        private bool _haveDebuff;//身上是否存在诅咒;
        private bool _loseDebuff;//是否失去了诅咒;
        //对于种族;
        private bool _haveRace;//是否拥有了一个种族;
        private bool _loseRace;//是否失去了一个种族;

        //----------------------------------------------------------------
        //对于怪兽;
        private List<Card> _cardOfTheMonsterAtPresent;//当前场地上的怪兽卡牌;
        //----------------------------------------------------------------
        //对于魔法;

        //----------------------------------------------------------------
        //对于流程;
        //出售：当前需要出售的物品;
        private Card _soldCard;//
        private bool _currentRoundOf;//自己的当前回合是否结束;
        //private int _playerHandCard;//玩家当前的手牌数量;
 
        //----------------------------------------------------------------
        private int _numberOfTrouble;//每个玩家可以捣乱的次数;
        private List<Base_Event> _myEvent;//自己角色事件的投放地方;与_cardOfThePlayAtPresent关联;
 
        private Card _giveupCardAtPresent;//当前丢弃的卡牌;       
       
        private CombatType _combat;//战斗状态;(输/赢)
        private RunStateType _runState;//逃跑状态;
        private TurnToStateType _turnToState;//求助状态;

        //.......
        //----------------------------------------------------------------
        private CoreDataObserver()
        {

            //------------------------------------------------------------
            _listennerList = new List<Base_Listenner>();
            Debug.Log(_listennerList.Count);
            _cardOfKickTheDoorAtPresent = null;
            _cardOfThePlayAtPresent = null;
            _mySelf = null;
            _isYouRound = false;//是否为自己回合;
            _attackEnemyCards = new Queue<Card>();//对敌人释放的卡片;
            _momentTypeAtPresent = MomentType.None;//当前所属的游戏阶段;
            _cardOfTheMonsterAtPresent = new List<Card>();
            //.........
            //.....
            //...

            //------------------------------------------------------------


        }
        //-----------------------------------------------------------------
        public static CoreDataObserver GetInstance()
        {
            if (instance == null)
            {
             
                instance = new CoreDataObserver();
                return instance;
            }
            return instance;
        }
        //----------------------------------------------------------------
        //当前所属的游戏阶段;
        public MomentType GetMomentTypeAtPresent()
        {
            //获取当前的游戏阶段;
            return _momentTypeAtPresent;
        }
        public void SetMomentTypeAtPresent(MomentType momenttype)
        {
            //设置当前的游戏阶段;
             _momentTypeAtPresent = momenttype;

            //------------------------------------------------------------
            //通知观察者;
            Notify();
            //------------------------------------------------------------
           
           

        }
        public List<Base_Listenner> GetList()
        {
            return _listennerList;
        }
        //----------------------------------------------------------------
        //当前场地上的怪兽卡牌;
        public List<Card> GetCardOfTheMonsterAtPresent()
        {
            //获取当前场地上的怪兽卡;
            return _cardOfTheMonsterAtPresent;
        }

        public void SetCardOfTheMonsterAtPresent(Card monstercard)
        {
            //向链表中添加怪兽卡牌;
            if (monstercard != null)
            {
                //添加怪兽卡牌;
                _cardOfTheMonsterAtPresent.Add(monstercard);
                //------------------------------------------------------------
                //通知观察者;
                Notify();
                //------------------------------------------------------------

            }
        }
        //----------------------------------------------------------------
        //对敌人释放的卡片;
        public Queue<Card> GetQueueOfAttackEnemyCards()
        {
            //获取对敌人释放的卡片队列;
            return _attackEnemyCards;
        }
        public void SetQueueOfAttackEnemyCards(Card card)
        {
            //设置对敌人释放的卡片;
            if(card!=null)
            {
                _attackEnemyCards.Enqueue(card);

            }
            //------------------------------------------------------------
            //通知观察者;
            Notify();
            //------------------------------------------------------------
        }
        //----------------------------------------------------------------

        //是否是你的回合;
        public bool GetIsYouRound()
        {
            //是否为你的回合;
            return _isYouRound;
        }
        public void SetIsYouRound(bool youround)
        {
            //设置事发后为你的回合;
            _isYouRound = youround;
        }
        //----------------------------------------------------------------
        //玩家;
        public PlayerDefine GetPlayer()
        {
            //获取玩家;
            return _mySelf;
        }
        public void SetPlayer(PlayerDefine player)
        {
            //设置玩家;
            _mySelf = player;
        }

        //----------------------------------------------------------------
        //踢门牌;
        public Card Get_CardOfKickTheDoorAtPresent()
        {
            //获取当前抽到的踢门牌;
            return _cardOfKickTheDoorAtPresent;
      
        }
        public void Set_CardOfKickTheDoorAtPresent(Card card)
        {
            //设置当前踢门牌;
            if(card!=null)
            {
                _cardOfKickTheDoorAtPresent = card;
                //------------------------------------------------------------
                //通知观察者;
                Notify();
                //------------------------------------------------------------
            }

        }
        //----------------------------------------------------------------
        //当前出的卡牌;
        public Card Get_CardOfThePlayAtPresent()
        {
            //获取当前打出的卡牌;
            return _cardOfThePlayAtPresent;
        }
        public void Set_CardOfThePlayAtPresent(Card card)
        {
            //设置当前打出的卡牌;
            if (card != null)
            {
                _cardOfThePlayAtPresent = card;
                //------------------------------------------------------------
                //通知观察者;
                Notify();
                //------------------------------------------------------------
            }

        }


        //----------------------------------------------------------------

        public void AddListenner(Base_Listenner base_listenner)
        {

            //添加观察者;

            if (!_listennerList.Contains(base_listenner))
            {
                 _listennerList.Add(base_listenner);
            }

       
        }

        public bool removeListenner(string listennername)
        {
            //移除观察者;
            foreach(Base_Listenner it in _listennerList)
            {
                if(it.GetLinstennerName()== listennername)
                {
                    _listennerList.Remove(it);
                    return true;
                }

            }
            return false;
        }

        //----------------------------------------------------------------

        private void Notify()
        {
            //通知观察者;
            foreach (Base_Listenner listener in _listennerList)
            {

                listener.Update();
            }
        }
        //----------------------------------------------------------------
    }
}
