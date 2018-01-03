/********************************************************************
	created:	2017/12/06
	created:	6:12:2017   10:55
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\卡牌对象\Profession.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test\卡牌对象
	file base:	Profession
	file ext:	cs
	author:		DLJ
	
	purpose:	卡牌职业;
*********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Munchkin
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Occupation_Define", menuName = "ProjectMunchkin/Card/Occupation_Define")]
    public class Occupation : Card
    {
        //Data:
        //-----------------------------------------------
        [SerializeField,Header("职业类型")]
        private OccupationType _occupationtype=OccupationType.None;//职业类型; 
        [SerializeField, Header("种族天赋事件")]
        private List<string> _genius;//种族天赋事件;
        //private String _name;//职业名称;
        //-----------------------------------------------
        public List<string> Genius
        {
            //获取种族天赋事件集合;
            get { return _genius; }
            set { _genius = value; }
        }

        public OccupationType Occupationtype
        {
            get
            {
                return _occupationtype;
            }

            set
            {
                _occupationtype = value;
            }
        }

        public void SetOneGenius(string fp_string)
        {
            //设置一个种族天赋;
            if (!_genius.Contains(fp_string))
                _genius.Add(fp_string);

        }

    }

}