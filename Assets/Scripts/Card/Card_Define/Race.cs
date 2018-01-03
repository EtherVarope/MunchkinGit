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
    [CreateAssetMenu(fileName = "Race_Define", menuName = "ProjectMunchkin/Card/Race_Define")]
    public class Race : SerializeObj
    {
        //Data:
        //-----------------------------------------------
        [SerializeField, Header("种族名称")]
        private string _name;//种族名称;
        [SerializeField,Header("种族类型")]
        private RaceType _racetype = RaceType.None;//种族类型;
        [SerializeField, Header("种族优势事件")]
        private List<string> _ascendancy;//种族优势事件;
        [SerializeField, Header("种族劣势事件")]
        private List<string> _disadvantage;//种族劣势事件;

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

        public RaceType Racetype
        {
            get
            {
                return _racetype;
            }

            set
            {
                _racetype = value;
            }
        }

        public List<string> Ascendancy
        {
            get
            {
                return _ascendancy;
            }

            set
            {
                _ascendancy = value;
            }
        }

        public List<string> Disadvantage
        {
            get
            {
                return _disadvantage;
            }

            set
            {
                _disadvantage = value;
            }
        }


        //-----------------------------------------------

    }

}