/********************************************************************
	created:	2017/12/06
	created:	6:12:2017   16:02
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\卡牌对象\Equipment.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\卡牌对象
	file base:	Equipment
	file ext:	cs
	author:		DLJ
	
	purpose:	装备卡牌;
*********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Munchkin
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Monster_Define", menuName = "ProjectMunchkin/Card/Monster_Define")]
    public class Monster : SerializeObj
    {
        //Data:
        //-----------------------------------------------
        [SerializeField, Header("怪物名字")]
        private string _name;//名字
        [SerializeField, Header("怪物等级")]
        private int _level; //等级;
        [SerializeField,Header("怪物类型")]
        private MonsterType _monstertype;  //怪物类型;
                                           //-----------------------------------------------
        [SerializeField, Header("针对种族")]
        private List<RaceType> _aimAtRaceType;//针对种族;
        [SerializeField, Header("针对职业")]
        private List<OccupationType> _aimAtOccupationType;//针对职业;
        [SerializeField, Header("怪物天赋")]
        private List<string> _genius;//怪物天赋;
        [SerializeField, Header("特殊奖励")]
        private Reward _reward; //特殊奖励;(对抗精灵-4)
        [SerializeField, Header("特殊的恩惠")]
        private int _specialFavor;//特殊的恩惠;(不会追赶int等级的小白)
                                  //-----------------------------------------------
        [SerializeField, Header("获胜奖励data")]
        private List<Reward> _awardWinning;//获胜奖励data;
        [SerializeField, Header("失败奖励data")]
        private List<Reward> _awardFailure;//失败奖励data;
        [SerializeField, Header("恶果")]
        private List<string> _badResult;//恶果;

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

        public MonsterType Monstertype
        {
            get
            {
                return _monstertype;
            }

            set
            {
                _monstertype = value;
            }
        }

        public List<RaceType> AimAtRaceType
        {
            get
            {
                return _aimAtRaceType;
            }

            set
            {
                _aimAtRaceType = value;
            }
        }

        public List<OccupationType> AimAtOccupationType
        {
            get
            {
                return _aimAtOccupationType;
            }

            set
            {
                _aimAtOccupationType = value;
            }
        }

        public List<string> Genius
        {
            get
            {
                return _genius;
            }

            set
            {
                _genius = value;
            }
        }

        public Reward Reward
        {
            get
            {
                return _reward;
            }

            set
            {
                _reward = value;
            }
        }

        public int SpecialFavor
        {
            get
            {
                return _specialFavor;
            }

            set
            {
                _specialFavor = value;
            }
        }

        public List<Reward> AwardWinning
        {
            get
            {
                return _awardWinning;
            }

            set
            {
                _awardWinning = value;
            }
        }

        public List<Reward> AwardFailure
        {
            get
            {
                return _awardFailure;
            }

            set
            {
                _awardFailure = value;
            }
        }

        public List<string> BadResult
        {
            get
            {
                return _badResult;
            }

            set
            {
                _badResult = value;
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
        //-----------------------------------------------

    }

}