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
    [CreateAssetMenu(fileName = "Debuff_Define", menuName = "ProjectMunchkin/Card/Debuff_Define")]
    public class Debuff : SerializeObj
    {
        //Data:
        //-----------------------------------------------
        [SerializeField, Header("作用对象类型")]
        FunctionObjectType _functionobject;//作用对象类型;
        [SerializeField, Header("诅咒坏奖励")]
        Reward _badReward;//诅咒坏奖励;
        [SerializeField, Header("失去装备的类型")]
        EquipmentType _lostEquipment;//失去装备的类型;
        [SerializeField, Header("诅咒持续时间")]
        int _buffTime;//诅咒持续时间;
        [SerializeField, Header("诅咒持续时间记录")]
        int _buffTimeRecord;//诅咒持续时间记录;
        [SerializeField, Header("诅咒列表")]
        List<string> _curse;//诅咒;

        #region GetSet
        public FunctionObjectType Functionobject
        {
            get
            {
                return _functionobject;
            }

            set
            {
                _functionobject = value;
            }
        }

        public Reward BadReward
        {
            get
            {
                return _badReward;
            }

            set
            {
                _badReward = value;
            }
        }

        public EquipmentType LostEquipment
        {
            get
            {
                return _lostEquipment;
            }

            set
            {
                _lostEquipment = value;
            }
        }

        public int BuffTime
        {
            get
            {
                return _buffTime;
            }

            set
            {
                _buffTime = value;
            }
        }

        public int BuffTimeRecord
        {
            get
            {
                return _buffTimeRecord;
            }

            set
            {
                _buffTimeRecord = value;
            }
        }

        public List<string> Curse
        {
            get
            {
                return _curse;
            }

            set
            {
                _curse = value;
            }
        }
        #endregion

        public List<string> GetCurse()
        {
            //获取诅咒事件;
            return _curse;
        }

        public void SetCurse(string fp_string)
        {
            //设置一个诅咒事件;
            if (!_curse.Contains(fp_string))
                _curse.Add(fp_string);
        }
        public void SetBuffTimeRecord(int time)
        {
            //设置持续时间记录;
            _buffTimeRecord = time;
        }
        public int GetBuffTimeRecord()
        {
            //获取持续时间记录;
            return _buffTimeRecord;
        }
        public FunctionObjectType GetFunctionobject()
        {
            //设置作用对象类型;
            return _functionobject;
        }
        public void SetFunctionobject(FunctionObjectType functionobjecttype)
        {
            //获取作用对象类型;
            _functionobject = functionobjecttype;
        }
        //-----------------------------------------------
        public Reward GetBadReward()
        {
            //获取坏奖励;
            return _badReward;
        }
        public void SetBadReward(Reward reward)
        {
            //设置坏奖励;
            _badReward = reward;
        }
        //-----------------------------------------------
        public EquipmentType GetLostEquipmentType()
        {
            //获取失去装备类型;
            return _lostEquipment;
        }

        public int GetBuffTime()
        {
            //获取诅咒持续时间;
            return _buffTime;
        }
        //-----------------------------------------------
    }

}