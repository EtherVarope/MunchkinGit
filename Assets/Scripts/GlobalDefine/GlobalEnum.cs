/********************************************************************
	created:	2017/12/04
	created:	4:12:2017   14:58
	filename: 	C:\Users\Administrator\Desktop\UI模型\Test\Test\EventType.cs
	file path:	C:\Users\Administrator\Desktop\UI模型\Test\Test
	file base:	EventType
	file ext:	cs
	author:		DLJ
	
	purpose:	事件类型;
*********************************************************************/

namespace Munchkin
{
    public enum EventType
    {
        //事件类型;
        None = 0,
        Debuff_CreatEventOne,
        GetACardOfKickTheDoor,
        Magic_CreatEvent,
        PushAttackEnemyCards,
        GetMonsterCardAndPushItToList,//
        SetACardOfKickTheDoor,
        ChangeMomentType_CombatPhase,
        //.................
        //............
        //.....
        //-------------------------------------------------------------------------
        //Test:
        TestOneEvent,
        TestTwoEvent,
        TestThreeEvent
        //.................
    }
    public enum RaceType
    {
        //种族类型;
        None = 1,
        SmallWhite,//小白;
        Dwarf,//矮人;
        Halfling,//半身人;
        Sprite,//精灵;


    }

    public enum OccupationType
    {
        //职业类型;
        None = 1,//无业;
        Warrior,//战士;
        Vicar,//牧师;
        Thieves,//盗贼;
        Mages//法师;

    }
   public enum EquipmentType
    {
        //装备类型;
        None = 1,
        Shoes,//鞋子;
        Cap,//帽子;
        Armor,//盔甲;
        SingleHand,//单手;
        WithBothHands,//双手;
        Other//自由选择;(应对于诅咒失去卡片)

    }
   public enum EquipmentKind
    {
        //装备性质;
        None = 1,
        Dig,//大装备;
        Small//小装备;


    }

    enum WeaponsKind
    {
        //武器性质;


    }


    public enum CardType
    {
        //卡牌类型;
        None = 1,
        EquipmentCard,//装备卡;
        MonsterCard,//怪兽卡;
        OccupationCard,//职业卡;
        RaceCard,//种族卡;
        DebuffCard,//buff卡（诅咒卡）;
        MagicCard//魔法卡;
        
    }

   public enum CardSeries
    {
        //卡牌系列;
        None = 1,
        TreasureCard,//宝藏卡;
        KickDoorCard//踢门卡;


    }



    public enum RewardType
    {
        //奖励类型;
        None = 1,
        LevelReward,//等级奖励;
        DiceReward,//掷骰子奖励;
        FleeReward,//逃跑奖励;
        TreasureReward,//宝藏奖励;
        AttackReward,//怪物攻击奖励;(不会攻击int等级以下的玩家)
        Die,//死亡;
        Hands//手牌;

    }


    public class Reward
    {
        //奖励;
        private RewardType _rewardtype;//奖励类型;
        private int _number;//奖励数值;
        public Reward()
        {

        }
        public Reward(RewardType rewardtype, int number)
        {
            _rewardtype = rewardtype;
            _number = number;

        }
        public RewardType Rewardtype
        {
            //奖励类型;
            get { return _rewardtype; }
            set { _rewardtype = value; }
        }
        public int Number
        {
            //奖励数值;
            get { return _number; }
            set { _number = value; }
        }


    }

    public enum MonsterType
    {
        //怪物类型;
        None = 1,
        Undead//不死族;
    }

    public enum MomentType
    {
        //游戏阶段类型;
        None = 1,
        RollTheDice,//骰子投递;(决定玩家游戏先后顺序)
        KickTheDoor,//踢门抽牌阶段;
        FreePhase,//自由阶段;(踢门卡不是怪物)
        SellPhase,//出售阶段;
        PY_Phase,//交易阶段;
        CombatPhase,//战斗阶段;
        A_HandoutPhase,//施舍阶段;(别的玩家自动帮助于你,不用自己请求)
        PreparationFor,//自己备战阶段;
        DisruptivePhase,//捣乱阶段;
        AttackPhase,//攻击阶段;
        AskForHelp,//求助阶段;
        EscapeStage,//逃跑阶段;
        PickUpFastFood,//领盒饭阶段;(击败怪物后领取奖励)
        PunishmentStage,//惩罚阶段;
        EndOfTurn,//回合结束;
        VictoryStage,//胜利阶段;(最后的胜利阶段)
                     //       HelpVictoryStage,//帮助别人胜利;
                     //       BeHelpedVictoryStage,//被别人帮助胜利;
        Die,//死亡;
        DonationCard//捐赠手牌;

    }
    //-----------------------------------------------------------------------------
    //战斗状态;
    enum CombatType
    {
        //战斗状态类型;
        None = 1,
        //Win,//成功;
        SoloWin,//自己战斗获胜;
        HelpWin,//帮助别人战斗获胜;
        BeHelpedWin,//被帮助获胜;
        Fail//失败;

    }
    enum RunStateType
    {
        //逃跑状态类型;
        None = 1,
        Win,//成功;
        Fail//失败;

    }
    enum TurnToStateType
    {
        //求助状态类型;
        None = 1,
        Win,//成功;
        Fail//失败;

    }
    //-----------------------------------------------------------------------------
    enum TimeOfDuration
    {
        //事件持续时间;
        None = 1,
    }


    public enum FunctionObjectType
    {
        //事件作用对象;
        None = 1,//
        AnyAppointOnePlayer,//任何指定玩家;(作用对象数目为1)
        AnyAppointSomePlayer,//任何指定数目的玩家;(作用对象数目为任意指定玩家)
        ALLPlayer,//作用于所有玩家;
        //AllPlayerInTheFighting,//作用于在战斗中的所有玩家;
        Myself,//只能作用于自己;
        AnyAppointOneOtherPlayer,//作用于其余指定玩家(不包括自己,单一指定敌对玩家);
        AnyAppointSomeOtherPlayer,//作用于其余指定的多玩家;(不包括自己,多指定敌对玩家)
        AllOtherPlayer,//所有敌对玩家;
        //----------------------------------------------------------------------------------
        OnlyOneMonster,//只能是一只怪兽;
        SomeMonster,//一些怪兽;
        AllMonster,//所有怪兽;
        //----------------------------------------------------------------------------------
        All//适用所有对象;
        

    }



}
