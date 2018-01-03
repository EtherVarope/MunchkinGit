/********************************************************************
	创建时间:	2017/12/23;23:12:2017   19:37
	文件路径: 	F:\Unity3D Project5.6\Munchkin\Assets\Scripts\Card\Card.cs
	文件名:	Card
	文件类型t:	cs
	文件作者:		Author
//-------------------------------------------------------------------------------/
	主题:	  卡牌的基本数据结构定义
	功能:      卡牌基本数据套用模板 将基本属性与数据序列化
*********************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Munchkin
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Card_Define", menuName = "ProjectMunchkin/Player/Card_Define")]
    public class Card : Card_Base
    {

        //Data:
        //-----------------------------------------------
        [Header("卡牌名字")]
        public string _name = "卡牌名字八个字";//卡牌名字;

        [Header("卡牌描述")]
        public string _describe = "卡牌描述56个字";//卡牌描述;
        
        [Header("对应于所属的玩家")]
        public int _playerId;//对应于所属的玩家;

        [Header("卡牌ID")]
        public int _id;//卡牌ID;

        [Header("卡牌组")]
        public CardSeries _cardseries=CardSeries.KickDoorCard;//卡牌组;

        [Header("卡牌类型")]
        public CardType _cardtype=CardType.None;//卡牌类型;

       [Header("卡牌可以发动的阶段")]
        public MomentType _stage=MomentType.None;//卡牌可以发动的阶段;(卡牌发动时机)

        [Header("装备")]
        public  Equipment _equipment;//装备;

        [Header("职业")]
        public Occupation _occupation;//职业;

        [Header("种族")]
        public Race _race;//种族;

        [Header("怪兽卡")]
        public Monster _monster;//怪兽卡;

        [Header("诅咒卡")]
        public Debuff _debuff;//诅咒卡;

        [Header("魔法卡")]
        public Magic _magic;//魔法卡;

        //-----------------------------------------------
        public Equipment GetEquipmentCard()
        {
            //获取装备卡片;
            return _equipment;
        }
        public Occupation GetOccupationCard()
        {
            //获取职业卡片;
            return _occupation;
        }
        public Race GetRaceCard()
        {
            //获取种族卡片;
            return _race;
        }
        public Monster GetMonsterCard()
        {
            //获取怪兽卡片;
            return _monster;
        }
        public Debuff GetDebuffCard()
        {
            //获取诅咒卡;
            return _debuff;
        }
        public Magic GetMagic()
        {
            //获取魔法卡;
            return _magic;
        }

        //-----------------------------------------------
        public int GetId()
        {
            //获取卡牌ID;
            return _id;

        }
        public void SetId(int id)
        {
            //设置卡牌ID;
            _id = id;
        }
        //-----------------------------------------------
        public CardSeries GetCardSeries()
        {
            //获取卡牌组信息;
            return _cardseries;
        }
        public void SetCardSeries(CardSeries cardseries)
        {
            //设置卡牌组信息;
            _cardseries = cardseries;
        }
        //-----------------------------------------------
        public CardType GetCardType()
        {
            //获取卡牌类型;
            return _cardtype;
        }
        public void SetCardType(CardType cardtype)
        {
            //设置卡牌类型;
            _cardtype = cardtype;
        }
        //-----------------------------------------------
        public string GetDescribe()
        {
            //获取卡牌描述;
            return _describe;
        }
        public void SetDescribe(string describe)
        {
            //设置卡牌描述;
            _describe = describe;
        }
        //-----------------------------------------------
        public string GetName()
        {
            //获取卡牌名字;
            return _name;
        }
        public void SetName(string name)
        {
            //设置卡牌名字;
            _name = name;
        }
        //-----------------------------------------------
        public MomentType GetMomentType()
        {
            //获取卡牌发动时机;
            return _stage;
        }
        public void SetMomentType(MomentType momenttype)
        {
            //设置卡牌发动时机;
            _stage = momenttype;
        }

        //-----------------------------------------------
        public int GetPlayerId()
        {
            //获取玩家ID;
            return _playerId;
        }
        public void SetPlayerId(int id)
        {
            //设置玩家ID;
            _playerId = id;
        }
        //-----------------------------------------------
    }
}
