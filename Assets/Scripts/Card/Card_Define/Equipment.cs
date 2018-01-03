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
    [CreateAssetMenu(fileName = "Equipment_Define", menuName = "ProjectMunchkin/Card/Equipment_Define")]
    public class Equipment : SerializeObj
    {
        //Data:
        //-----------------------------------------------
        //private RewardType _reward;//奖励类型;
        //private int _number;//奖励大小;
        [SerializeField,Header("奖励")]
        private Reward _reward;//奖励;
        [SerializeField, Header("是否被穿着")]
        private bool _beEquipOn=false;//是否被穿着;
                                  //-----------------------------------------------
        [SerializeField, Header("价值")]
        private int _value=0;    //价值;
        [SerializeField, Header("装备特性")]
        private List<string> _peculiarity;//装备特性(event);  
        [SerializeField, Header("装备性质(大物品/小物品)")]
        private EquipmentKind _equipmentKind= EquipmentKind.None;//装备性质(大物品/小物品);
        [SerializeField, Header("装备类型")]
        private EquipmentType _equipmentType=EquipmentType.None;//装备类型;
                                             //-----------------------------------------------
                                             //专用;
        [SerializeField, Header("种族专用")]
        private RaceType _specialRaceType=RaceType.None;//种族专用;       
        [SerializeField, Header("职业专用")]
        private OccupationType _specialOccupationType=OccupationType.None;//职业专用;
                                                      //-----------------------------------------------
                                                      //限制;
        [SerializeField, Header("种族限制")]
        private RaceType _confineRaceType = RaceType.None;//种族限制;       
        [SerializeField, Header("职业限制")]
        private OccupationType _confineOccupationType = OccupationType.None;//职业限制;
        //-----------------------------------------------

    }

}