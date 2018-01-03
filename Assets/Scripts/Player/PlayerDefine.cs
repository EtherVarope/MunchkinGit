/********************************************************************
	创建时间:	2017/12/23;23:12:2017   19:35
	文件路径: 	F:\Unity3D Project5.6\Munchkin\Assets\Scripts\Player\PlayerDefine.cs
	文件名:	PlayerDefine
	文件类型t:	cs
	文件作者:		Author
//-------------------------------------------------------------------------------/
	主题:	玩家的基本数据结构定义
	功能:    玩家基本数据套用模板 将基本属性与数据序列化
*********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Munchkin
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Player_Define", menuName = "ProjectMunchkin/Player/Player_Define")]
    public class PlayerDefine : ScriptableObject
    {
        [Header("--------------玩家的基本数据结构模板-------------")]
        //Data;
        //-----------------------------------------------
        [SerializeField]
        private int _iD;//id;
        [SerializeField]
        private string _name;//姓名;
        [SerializeField]
        private int _level;//等级;
        [SerializeField]
        private int _fightingCapacity;//战斗力;
        [SerializeField]
        private int _diceNumber;//骰子点数;
        [SerializeField]
        private int _money;//钱;
                           //-----------------------------------------------
                           //种族;
        [SerializeField]
      
        private List<Card> _raceCard;//种族卡牌;
        [SerializeField]
        private int _raceNumber = 1;//拥有个数限制;
                                    //-----------------------------------------------
                                    //职业;

        [ SerializeField, Range(0,1)]
        private List<Card> _occupationCard;//职业卡牌;
        [SerializeField]
        private int _occupationNumber = 1;//拥有个数限制;
                                          //-----------------------------------------------
                                          //装备;
        [SerializeField]
        private List<Card> _equipmentCard;//装备卡牌;
        [SerializeField]
        private int _bigEquipmentNumber;//大装备拥有个数限制;
                                        //-----------------------------------------------
                                        //手牌;
        [SerializeField]
        private List<Card> _cardInMyHand;//手牌;
        [SerializeField]
        private int _myCardNumber = 5;//手牌数量限制;
                                      //-----------------------------------------------
                                      //诅咒;
        [SerializeField]
        private List<Card> _debuffCard;//诅咒卡牌;
        #region GetSet
        public int ID
        {
            get
            {
                return _iD;
            }

            set
            {
                _iD = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
            }
        }

        public int FightingCapacity
        {
            get
            {
                return _fightingCapacity;
            }

            set
            {
                _fightingCapacity = value;
            }
        }

        public int DiceNumber
        {
            get
            {
                return _diceNumber;
            }

            set
            {
                _diceNumber = value;
            }
        }

        public int Money
        {
            get
            {
                return _money;
            }

            set
            {
                _money = value;
            }
        }

        public List<Card> RaceCard
        {
            get
            {
                return _raceCard;
            }

            set
            {
                _raceCard = value;
            }
        }

        public int RaceNumber
        {
            get
            {
                return _raceNumber;
            }

            set
            {
                _raceNumber = value;
            }
        }

        public List<Card> OccupationCard
        {
            get
            {
                return _occupationCard;
            }

            set
            {
                _occupationCard = value;
            }
        }

        public int OccupationNumber
        {
            get
            {
                return _occupationNumber;
            }

            set
            {
                _occupationNumber = value;
            }
        }

        public List<Card> EquipmentCard
        {
            get
            {
                return _equipmentCard;
            }

            set
            {
                _equipmentCard = value;
            }
        }

        public int BigEquipmentNumber
        {
            get
            {
                return _bigEquipmentNumber;
            }

            set
            {
                _bigEquipmentNumber = value;
            }
        }

        public List<Card> CardInMyHand
        {
            get
            {
                return _cardInMyHand;
            }

            set
            {
                _cardInMyHand = value;
            }
        }

        public int MyCardNumber
        {
            get
            {
                return _myCardNumber;
            }

            set
            {
                _myCardNumber = value;
            }
        }

        public List<Card> DebuffCard
        {
            get
            {
                return _debuffCard;
            }

            set
            {
                _debuffCard = value;
            }
        }
        #endregion
        public  PlayerDefine(int id, string name)
        {
            //-----------------------------------------------
            _iD = id;//玩家id;
            _name = name;//玩家姓名;
            _level = 1;//玩家等级;
            _fightingCapacity = 1;//玩家战斗力;
            _diceNumber = 0;//骰子点数;
            _money = 0;//钱;
            //-----------------------------------------------
            _raceCard = new List<Card>(); //种族卡牌;
            _raceNumber = 1;//拥有个数限制;
            _occupationCard = new List<Card>();//职业卡牌;
            _occupationNumber = 1;//拥有个数限制;
            _equipmentCard = new List<Card>();//装备卡牌;
            _bigEquipmentNumber = 1;//大装备拥有个数限制;
            _cardInMyHand = new List<Card>();//手牌;
            _myCardNumber = 5;//手牌数量限制;
            _debuffCard = new List<Card>();//诅咒卡牌;
            //-----------------------------------------------
        }
        public bool SetCardInMyHand(Card cardinmyhand)
        {
            //获取手牌;
            _cardInMyHand.Add(cardinmyhand);
            return true;
        }
        public List<Card> GetCardInMyHand()
        {
            //返回当前的手牌;
            return _cardInMyHand;
        }

        public int GetId()
        {
            return _iD;
        }

    }
}
