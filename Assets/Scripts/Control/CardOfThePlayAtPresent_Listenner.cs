/********************************************************************
	created:	2017/12/25
	created:	25:12:2017   10:48
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者\CardOfThePlayAtPresent_Listenner.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\观察者
	file base:	CardOfThePlayAtPresent_Listenner
	file ext:	cs
	author:		DLJ
	
	purpose:	当前打出卡牌的观察者;
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Munchkin
{
    class CardOfThePlayAtPresent_Listenner : Base_Listenner
    {
        //当前打出的卡牌,根据当前的游戏阶段来设置;
        //----------------------------------------------------------------
        //Data:
        private Card _cardOfThePlayAtPresent;//当前玩家出的卡牌;
        private Card _double;//替身;
        private string _name;//名字;
        //----------------------------------------------------------------
        public CardOfThePlayAtPresent_Listenner(string name)
        {
            _name = name;
            _cardOfThePlayAtPresent = null;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }
        public CardOfThePlayAtPresent_Listenner()
        {
            //..........
            _name = "CardOfThePlayAtPresent_Listenner";
            _cardOfThePlayAtPresent = null;
            _double = null;
            //加入订阅者容器内部;
            CoreDataObserver.GetInstance().AddListenner(this);

        }
        //----------------------------------------------------------------
        //事件组合器;
        public override void Update()
        {
            _double = CoreDataObserver.GetInstance().Get_CardOfThePlayAtPresent();//获取最新的打出卡牌数据;
            if (_double != _cardOfThePlayAtPresent)
            {
                _cardOfThePlayAtPresent = _double;
                //-------------------------------------------------------------------------------------------------
                //Do something:
                //Put event;
                switch (_cardOfThePlayAtPresent.GetCardType())
                {
                    case CardType.MagicCard:
                        //-----------------------------------------------------------------------------------------
                        //当前出的卡片为魔法卡;
                        //EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("Debuff_CreatEventOne"));//投递事件;
                       if(CoreDataObserver.GetInstance().GetMomentTypeAtPresent()==MomentType.DisruptivePhase || CoreDataObserver.GetInstance().GetMomentTypeAtPresent() == MomentType.A_HandoutPhase)
                        {
                            //如果当前阶段为捣乱阶段或者施舍阶段;
                            EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("PushAttackEnemyCards"));//投递事件;

                        }
                       else
                        {
                            //为其他阶段;
                            //表明作用对象为本人或者为本人所面对的怪物;
                            EventQueue.GetInstance().PushEventForSecondqueue(EventFactory.GetInstance().GetEvent("Magic_CreatEvent"));//投递事件;


                        }
                        //-----------------------------------------------------------------------------------------
                        break;
                    case CardType.MonsterCard:
                        //-----------------------------------------------------------------------------------------
                        //当前出的卡片为怪兽卡;


                        //-----------------------------------------------------------------------------------------
                        break;
                    case CardType.EquipmentCard:
                        //-----------------------------------------------------------------------------------------
                        //当前出的卡牌为装备卡;


                        //-----------------------------------------------------------------------------------------
                        break;

                    case CardType.OccupationCard:
                        //-----------------------------------------------------------------------------------------
                        //当前出的卡牌为职业卡;


                        //-----------------------------------------------------------------------------------------
                        break;
                    case CardType.RaceCard:
                        //-----------------------------------------------------------------------------------------
                        //当前出的卡牌为种族卡;


                        //-----------------------------------------------------------------------------------------
                        break;

                    case CardType.DebuffCard:

                        //-----------------------------------------------------------------------------------------
                        //当前出的卡牌为诅咒卡;


                        //-----------------------------------------------------------------------------------------
                        break;



                    default:
                        //-----------------------------------------------------------------------------------------


                        //-----------------------------------------------------------------------------------------
                        break;
                }

                //-------------------------------------------------------------------------------------------------

            }
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
