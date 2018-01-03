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
    [CreateAssetMenu(fileName = "Magic_Define", menuName = "ProjectMunchkin/Card/Magic_Define")]
    public class Magic : SerializeObj
    {
        //Data:
        //-----------------------------------------------
        [SerializeField,Header("加成奖励")]
        Reward _reward;  //奖励;
        [SerializeField, Header("作用对象")]
        FunctionObjectType _functionObject; //作用对象;
        [SerializeField, Header("特殊效果")]
        List<string> _magicFunction; //特殊效果;
        #region GetSet
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

        public FunctionObjectType FunctionObject
        {
            get
            {
                return _functionObject;
            }

            set
            {
                _functionObject = value;
            }
        }

        public List<string> MagicFunction
        {
            get
            {
                return _magicFunction;
            }

            set
            {
                _magicFunction = value;
            }
        }
        #endregion
        //-----------------------------------------------
        public List<string> GetMagicFunction()
        {
            //获取特殊效果链表;
            return _magicFunction;

        }
    }

  
}