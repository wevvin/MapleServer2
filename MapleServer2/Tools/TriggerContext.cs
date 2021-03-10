using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using Maple2.Trigger;
using Maple2.Trigger.Enum;
using MapleServer2.Packets;
using MapleServer2.Servers.Game;
using MapleServer2.Types;

namespace MapleServer2.Tools
{
    public class TriggerContext : ITriggerContext
    {
        public int TickDelay = 0;
        public int NextTick = 0;
        private readonly FieldManager FieldManager;
        private readonly Dictionary<string, int> UserValues = new Dictionary<string, int>();
        private readonly Dictionary<string, TickTimer> Timers = new Dictionary<string, TickTimer>();
        private float RandomConditionValue = 101;

        public TriggerContext(FieldManager fieldManager)
        {
            FieldManager = fieldManager;
            UserValues.Add("gameStart", 0);
        }

        public void AddBalloonTalk(int spawnPointId = 0, string msg = "", int duration = 0, int delayTick = 0,
            bool npcId = false)
        {
            Console.WriteLine($"Not implemented: AddBalloonTalk");
        }

        public void AddBuff(int[] boxIds = null, int skillId = 0, byte arg3 = 0, bool arg4 = false, bool arg5 = false, string feature = "")
        {
            Console.WriteLine($"Not implemented: AddBuff: int[] boxIds = {string.Join(", ", boxIds ?? new int[1])}, int skillId = {skillId}, byte arg3 = {arg3}, bool arg4 = {arg4}, bool arg5 = {arg5}, string feature = {feature}");
        }

        public void AddCinematicTalk(int npcId = 0, string illustId = "", string script = "", int duration = 0,
            Align align = Align.Top,
            int delayTick = 0)
        {
            Console.WriteLine($"Not implemented: AddCinematicTalk");
        }

        public void AddEffectNif(int spawnPointId = 0, string nifPath = "", bool isOutline = false, float scale = 0,
            int rotateZ = 0)
        {
            Console.WriteLine($"Not implemented: AddEffectNif");
        }

        public void AddUserValue(string key = "", int value = 0)
        {
            Console.WriteLine($"Not implemented: AddUserValue");
        }

        public void ArcadeBoomBoomOceanSetSkillScore(int id = 0, int score = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeBoomBoomOceanSetSkillScore");
        }

        public void ArcadeBoomBoomOceanStartGame(byte lifeCount = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeBoomBoomOceanStartGame");
        }

        public void ArcadeBoomBoomOceanEndGame()
        {
            Console.WriteLine($"Not implemented: ArcadeBoomBoomOceanEndGame");
        }

        public void ArcadeBoomBoomOceanStartRound(byte round = 0, int roundDuration = 0, int timeScoreRate = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeBoomBoomOceanStartRound");
        }

        public void ArcadeBoomBoomOceanClearRound(byte round = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeBoomBoomOceanClearRound");
        }

        public void ArcadeSpringFarmSetInteractScore(int id = 0, int score = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeSpringFarmSetInteractScore");
        }

        public void ArcadeSpringFarmSpawnMonster(int[] spawnId = null, int score = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeSpringFarmSpawnMonster");
        }

        public void ArcadeSpringFarmStartGame(byte lifeCount = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeSpringFarmStartGame");
        }

        public void ArcadeSpringFarmEndGame()
        {
            Console.WriteLine($"Not implemented: ArcadeSpringFarmEndGame");
        }

        public void ArcadeSpringFarmStartRound(byte round = 0, int uiDuration = 0, string timeScoreType = "",
            int timeScoreRate = 0,
            int roundDuration = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeSpringFarmStartRound");
        }

        public void ArcadeSpringFarmClearRound(byte round = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeSpringFarmClearRound");
        }

        public void ArcadeThreeTwoOneStartGame(byte lifeCount = 0, int initScore = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeThreeTwoOneStartGame");
        }

        public void ArcadeThreeTwoOneEndGame()
        {
            Console.WriteLine($"Not implemented: ArcadeThreeTwoOneEndGame");
        }

        public void ArcadeThreeTwoOneStartRound(byte round = 0, int uiDuration = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeThreeTwoOneStartRound");
        }

        public void ArcadeThreeTwoOneResultRound(byte resultDirection = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeThreeTwoOneResultRound");
        }

        public void ArcadeThreeTwoOneResultRound2(byte round = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeThreeTwoOneResultRound2");
        }

        public void ArcadeThreeTwoOneClearRound(byte round = 0)
        {
            Console.WriteLine($"Not implemented: ArcadeThreeTwoOneClearRound");
        }

        public void ChangeBackground(string dds = "")
        {
            Console.WriteLine($"Not implemented: ChangeBackground");
        }

        public void ChangeMonster(int arg1 = 0, int arg2 = 0)
        {
            Console.WriteLine($"Not implemented: ChangeMonster");
        }

        public void CameraReset(float interpolationTime = 0)
        {
            Console.WriteLine($"Not implemented: CameraReset");
        }

        public void CameraSelect(int arg1 = 0, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: CameraSelect");
        }

        public void CameraSelectPath(int[] pathIds = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: CameraSelectPath");
        }

        public void CloseCinematic()
        {
            Console.WriteLine($"Not implemented: CloseCinematic");
        }

        public void CreateFieldGame(FieldGame type = FieldGame.Unknown, bool reset = false)
        {
            Console.WriteLine($"Not implemented: CreateFieldGame");
        }

        public void CreateItem(int[] arg1 = null, int arg2 = 0, int arg3 = 0, int arg5 = 0)
        {
            Console.WriteLine($"Not implemented: CreateItem");
        }

        public void CreateMonster(int[] arg1 = null, bool arg2 = false, int arg3 = 0)
        {
            Console.WriteLine($"Not implemented: CreateMonster");
        }

        public void CreateWidget(WidgetType type = WidgetType.Unknown)
        {
            Console.WriteLine($"Not implemented: CreateWidget");
        }

        public void DarkStreamSpawnMonster(int[] spawnId = null, int score = 0)
        {
            Console.WriteLine($"Not implemented: DarkStreamSpawnMonster");
        }

        public void DarkStreamStartGame(byte round = 0)
        {
            Console.WriteLine($"Not implemented: DarkStreamStartGame");
        }

        public void DarkStreamStartRound(byte round = 0, int uiDuration = 0, int damagePenalty = 0)
        {
            Console.WriteLine($"Not implemented: DarkStreamStartRound");
        }

        public void DarkStreamClearRound(byte round = 0)
        {
            Console.WriteLine($"Not implemented: DarkStreamClearRound");
        }

        public void DebugString(string message = "", string feature = "")
        {
            Console.WriteLine($"Not implemented: DebugString");
        }

        public void DestroyMonster(int[] arg1 = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: DestroyMonster");
        }

        public void DungeonClear(string uiType = "None")
        {
            Console.WriteLine($"Not implemented: DungeonClear");
        }

        public void DungeonClearRound(byte round = 0)
        {
            Console.WriteLine($"Not implemented: DungeonClearRound");
        }

        public void DungeonCloseTimer()
        {
            Console.WriteLine($"Not implemented: DungeonCloseTimer");
        }

        public void DungeonDisableRanking()
        {
            Console.WriteLine($"Not implemented: DungeonDisableRanking");
        }

        public void DungeonEnableGiveUp(bool isEnable = false)
        {
            Console.WriteLine($"Not implemented: DungeonEnableGiveUp");
        }

        public void DungeonFail()
        {
            Console.WriteLine($"Not implemented: DungeonFail");
        }

        public void DungeonMissionComplete(int missionId = 0, string feature = "")
        {
            Console.WriteLine($"Not implemented: DungeonMissionComplete");
        }

        public void DungeonMoveLapTimeToNow(bool id = false)
        {
            Console.WriteLine($"Not implemented: DungeonMoveLapTimeToNow");
        }

        public void DungeonResetTime(int seconds = 0)
        {
            Console.WriteLine($"Not implemented: DungeonResetTime");
        }

        public void DungeonSetEndTime()
        {
            Console.WriteLine($"Not implemented: DungeonSetEndTime");
        }

        public void DungeonSetLapTime(byte id = 0, int lapTime = 0)
        {
            Console.WriteLine($"Not implemented: DungeonSetLapTime");
        }

        public void DungeonStopTimer()
        {
            Console.WriteLine($"Not implemented: DungeonStopTimer");
        }

        public void SetDungeonVariable(int varId = 0, bool value = false)
        {
            Console.WriteLine($"Not implemented: SetDungeonVariable");
        }

        public void EnableLocalCamera(bool isEnable = false)
        {
            Console.WriteLine($"Not implemented: EnableLocalCamera");
        }

        public void EnableSpawnPointPc(int spawnPointId = 0, bool isEnable = false)
        {
            Console.WriteLine($"Not implemented: EnableSpawnPointPc");
        }

        public void EndMiniGame(int winnerBoxId = 0, MiniGame type = MiniGame.Unknown, bool isOnlyWinner = false)
        {
            Console.WriteLine($"Not implemented: EndMiniGame: int winnerBoxId = {winnerBoxId}, MiniGame type = {type}, bool isOnlyWinner = {isOnlyWinner}");
        }

        public void EndMiniGameRound(int winnerBoxId = 0, float expRate = 0, bool isOnlyWinner = false, bool isGainLoserBonus = false, bool meso = false, MiniGame type = MiniGame.Unknown)
        {
            Console.WriteLine($"Not implemented: EndMiniGameRound: int winnerBoxId = {winnerBoxId}, float expRate = {expRate}, bool isOnlyWinner = {isOnlyWinner}, bool isGainLoserBonus = {isGainLoserBonus}, bool meso = {meso}, MiniGame type = {type}");
        }

        public void FaceEmotion(int spawnPointId = 0, string emotionName = "")
        {
            Console.WriteLine($"Not implemented: FaceEmotion");
        }

        public void FieldGameConstant(string key = "", string value = "", string feature = "",
            Locale locale = Locale.ALL)
        {
            Console.WriteLine($"Not implemented: FieldGameConstant");
        }

        public void FieldGameMessage(byte custom = 0, string type = "", byte arg1 = 0, string arg2 = "", int arg3 = 0)
        {
            Console.WriteLine($"Not implemented: FieldGameMessage");
        }

        public void FieldWarEnd(bool isClear = false)
        {
            Console.WriteLine($"Not implemented: FieldWarEnd");
        }

        public void GiveExp(byte arg1 = 0, byte arg2 = 0)
        {
            Console.WriteLine($"Not implemented: GiveExp");
        }

        public void GiveGuildExp(bool boxId = false, byte type = 0)
        {
            Console.WriteLine($"Not implemented: GiveGuildExp: bool boxId = {boxId}, byte type = {type}");
        }

        public void GiveRewardContent(int rewardId = 0)
        {
            Console.WriteLine($"Not implemented: GiveRewardContent");
        }

        public void GuideEvent(int eventId = 0)
        {
            Console.WriteLine($"Not implemented: GuideEvent");
        }

        public void GuildVsGameEndGame()
        {
            Console.WriteLine($"Not implemented: GuildVsGameEndGame");
        }

        public void GuildVsGameGiveContribution(int teamId = 0, bool isWin = false, string desc = "")
        {
            Console.WriteLine($"Not implemented: GuildVsGameGiveContribution");
        }

        public void GuildVsGameGiveReward(GuildReward type = GuildReward.None, int teamId = 0, bool isWin = false,
            string desc = "")
        {
            Console.WriteLine($"Not implemented: GuildVsGameGiveReward");
        }

        public void GuildVsGameLogResult(string desc = "")
        {
            Console.WriteLine($"Not implemented: GuildVsGameLogResult");
        }

        public void GuildVsGameLogWonByDefault(int teamId = 0, string desc = "")
        {
            Console.WriteLine($"Not implemented: GuildVsGameLogWonByDefault");
        }

        public void GuildVsGameResult(string desc = "")
        {
            Console.WriteLine($"Not implemented: GuildVsGameResult");
        }

        public void GuildVsGameScoreByUser(int triggerBoxId = 0, bool score = false, string desc = "")
        {
            Console.WriteLine($"Not implemented: GuildVsGameScoreByUser");
        }

        public void HideGuideSummary(int entityId = 0, int textId = 0)
        {
            FieldManager.BroadcastPacket(TriggerPacket.Banner(TriggerPacket.BannerState.Off, entityId));
        }

        public void InitNpcRotation(int[] arg1 = null)
        {
            Console.WriteLine($"Not implemented: InitNpcRotation");
        }

        public void KickMusicAudience(int targetBoxId = 0, int targetPortalId = 0)
        {
            Console.WriteLine($"Not implemented: KickMusicAudience");
        }

        public void LimitSpawnNpcCount(byte limitCount = 0)
        {
            Console.WriteLine($"Not implemented: LimitSpawnNpcCount");
        }

        public void LockMyPc(bool isLock = false)
        {
            Console.WriteLine($"Not implemented: LockMyPc");
        }

        public void MiniGameCameraDirection(int boxId = 0, int cameraId = 0)
        {
            Console.WriteLine($"Not implemented: MiniGameCameraDirection");
        }

        public void MiniGameGiveExp(int boxId = 0, float expRate = 0, bool isOutSide = true)
        {
            Console.WriteLine($"Not implemented: MiniGameGiveExp");
        }

        public void MiniGameGiveReward(int winnerBoxId = 0, string contentType = "", MiniGame type = MiniGame.Unknown)
        {
            Console.WriteLine($"Not implemented: MiniGameGiveReward: int winnerBoxId = {winnerBoxId}, string contentType = {contentType}, MiniGame type = {type}");
        }

        public void MoveNpc(int arg1 = 0, string arg2 = "")
        {
            Console.WriteLine($"Not implemented: MoveNpc");
        }

        public void MoveNpcToPos(int spawnPointId = 0, Vector3 pos = new Vector3(), Vector3 rot = new Vector3())
        {
            Console.WriteLine($"Not implemented: Vector3");
        }

        public void MoveRandomUser(int arg1 = 0, byte arg2 = 0, int arg3 = 0, byte arg4 = 0)
        {
            Console.WriteLine($"Not implemented: MoveRandomUser");
        }

        public void MoveToPortal(int userTagId = 0, int portalId = 0, int boxId = 0)
        {
            Console.WriteLine($"Not implemented: MoveToPortal");
        }

        public void MoveUser(int arg1 = 0, int arg2 = 0, int arg3 = 0)
        {
            Console.WriteLine($"Not implemented: MoveUser: int arg1 = {arg1}, int arg2 = {arg2}, int arg3 = {arg3}");
        }

        public void MoveUserPath(string arg1 = "")
        {
            Console.WriteLine($"Not implemented: MoveUserPath");
        }

        public void MoveUserToBox(int boxId = 0, bool portalId = false)
        {
            Console.WriteLine($"Not implemented: MoveUserToBox: int boxId = {boxId}, bool portalId = {portalId}");
        }

        public void MoveUserToPos(Vector3 pos = new Vector3(), Vector3 rot = new Vector3())
        {
            Console.WriteLine($"Not implemented: Vector3");
        }

        public void Notice(bool arg1 = false, string arg2 = "", bool arg3 = false)
        {
            Console.WriteLine($"Not implemented: Notice");
        }

        public void NpcRemoveAdditionalEffect(int spawnPointId = 0, int additionalEffectId = 0)
        {
            Console.WriteLine($"Not implemented: NpcRemoveAdditionalEffect");
        }

        public void NpcToPatrolInBox(int boxId = 0, int npcId = 0, string spawnId = "", string patrolName = "")
        {
            Console.WriteLine($"Not implemented: NpcToPatrolInBox");
        }

        public void PatrolConditionUser(string patrolName = "", byte patrolIndex = 0, int additionalEffectId = 0)
        {
            Console.WriteLine($"Not implemented: PatrolConditionUser");
        }

        public void PlaySceneMovie(string fileName = "", int movieId = 0, string skipType = "")
        {
            Console.WriteLine($"Not implemented: PlaySceneMovie");
        }

        public void PlaySystemSoundByUserTag(int userTagId = 0, string soundKey = "")
        {
            Console.WriteLine($"Not implemented: PlaySystemSoundByUserTag");
        }

        public void PlaySystemSoundInBox(int[] arg1 = null, string filename = "")
        {
            FieldManager.BroadcastPacket(FieldPacket.PlaySystemSound(filename));
        }

        public void RandomAdditionalEffect(string target = "", int triggerBoxId = 0, int spawnPointId = 0,
            byte targetCount = 0,
            int tick = 0, int waitTick = 0, string targetEffect = "", int additionalEffectId = 0)
        {
            Console.WriteLine($"Not implemented: RandomAdditionalEffect");
        }

        public void RemoveBalloonTalk(int spawnPointId = 0)
        {
            Console.WriteLine($"Not implemented: RemoveBalloonTalk");
        }

        public void RemoveBuff(int arg1 = 0, int arg2 = 0, bool arg3 = false)
        {
            Console.WriteLine($"Not implemented: RemoveBuff");
        }

        public void RemoveCinematicTalk()
        {
            Console.WriteLine($"Not implemented: RemoveCinematicTalk");
        }

        public void RemoveEffectNif(int spawnPointId = 0)
        {
            Console.WriteLine($"Not implemented: RemoveEffectNif");
        }

        public void ResetTimer(string id = "")
        {
            if (!Timers.TryGetValue(id, out TickTimer timer))
            {
                return;
            }

            timer.GetTimer().Change(new TimeSpan(0, 0, 0, 0, 0), new TimeSpan(0, 0, 0, timer.GetStartInterval(), 0));
        }

        public void RoomExpire()
        {
            Console.WriteLine($"Not implemented: RoomExpire");
        }

        public void ScoreBoardCreate(string type = "", int maxScore = 0)
        {
            Console.WriteLine($"Not implemented: ScoreBoardCreate");
        }

        public void ScoreBoardRemove()
        {
            Console.WriteLine($"Not implemented: ScoreBoardRemove");
        }

        public void ScoreBoardSetScore(bool score = false)
        {
            Console.WriteLine($"Not implemented: ScoreBoardSetScore");
        }

        public void SetAchievement(int arg1 = 0, string arg2 = "", string arg3 = "")
        {
            Console.WriteLine($"Not implemented: SetAchievement: int arg1 = {arg1}, string arg2 = {arg2}, string arg3 = {arg3}");
        }

        public void SetActor(int arg1 = 0, bool arg2 = false, string arg3 = "", bool arg4 = false, bool arg5 = false)
        {
            Console.WriteLine($"Not implemented: SetActor");
        }

        public void SetAgent(int[] arg1 = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: SetAgent");
        }

        public void SetAiExtraData(string key = "", int value = 0, bool isModify = false, int boxId = 0)
        {
            Console.WriteLine($"Not implemented: SetAiExtraData");
        }

        public void SetAmbientLight(Vector3 arg1 = new Vector3(), Vector3 arg2 = new Vector3(),
            Vector3 arg3 = new Vector3())
        {
            Console.WriteLine($"Not implemented: Vector3");
        }

        public void SetCinematicIntro(string text = "")
        {
            Console.WriteLine($"Not implemented: SetCinematicIntro");
        }

        public void SetConversation(byte arg1 = 0, int arg2 = 0, string script = "", int arg4 = 0, byte arg5 = 0,
            Align align = Align.Top)
        {
            Console.WriteLine($"Not implemented: SetConversation");
        }

        public void SetCube(int[] ids = null, bool isVisible = false, byte randomCount = 0)
        {
            Console.WriteLine($"Not implemented: SetCube");
        }

        public void SetDirectionalLight(Vector3 arg1 = new Vector3(), Vector3 arg2 = new Vector3())
        {
            Console.WriteLine($"Not implemented: Vector3");
        }

        public void SetEffect(int[] arg1 = null, bool arg2 = false, int arg3 = 0, byte arg4 = 0)
        {
            //Console.WriteLine($"Not implemented: SetEffect - int[] arg1 = {string.Join(", ", arg1)}, bool arg2 = {arg2}, int arg3 = {arg3}, byte arg4 = {arg4}");
        }

        public void SetEventUI(byte type = 0, string script = "", int duration = 0, string boxId = "")
        {
            Console.WriteLine($"SetEventUI: byte type = {type}, string script = {script}, int duration = {duration}, string boxId = {boxId}");
            FieldManager.BroadcastPacket(MassiveEventPacket.TextBanner(6, script, duration));
        }

        public void SetGravity(float gravity = 0)
        {
            Console.WriteLine($"Not implemented: SetGravity");
        }

        public void SetInteractObject(int[] arg1 = null, byte arg2 = 0, bool arg4 = false, bool arg3 = false)
        {
            //Console.WriteLine($"Not implemented: SetInteractObject - int[] arg1 = {string.Join(", ", arg1)}, byte arg2 = {arg2}, bool {arg4} = false, bool {arg3} = false");
        }

        public void SetLadder(int arg1 = 0, bool arg2 = false, bool arg3 = false, byte arg4 = 0)
        {
            Console.WriteLine($"Not implemented: SetLadder");
        }

        public void SetLocalCamera(int cameraId = 0, bool enable = false)
        {
            Console.WriteLine($"Not implemented: SetLocalCamera");
        }

        public void SetMesh(int[] arg1 = null, bool arg2 = false, int arg3 = 0, int arg4 = 0, float arg5 = 0)
        {
            //Console.WriteLine($"Not implemented: SetMesh - int[] arg1 = {string.Join(", ", arg1)}, bool arg2 = {arg2}, int arg3 = {arg3}, int arg4 = {arg4}, float arg5 = {arg5}");
        }

        public void SetMeshAnimation(int[] arg1 = null, bool arg2 = false, byte arg3 = 0, byte arg4 = 0)
        {
            Console.WriteLine($"Not implemented: SetMeshAnimation");
        }

        public void SetMiniGameAreaForHack(int boxId = 0)
        {
            Console.WriteLine($"Not implemented: SetMiniGameAreaForHack");
        }

        public void SetBreakable(int[] arg1 = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: SetBreakable");
        }

        public void SetNpcDuelHpBar(bool isOpen = false, int spawnPointId = 0, int durationTick = 0, byte npcHpStep = 0)
        {
            Console.WriteLine($"Not implemented: SetNpcDuelHpBar");
        }

        public void SetNpcEmotionLoop(int arg1 = 0, string arg2 = "", float arg3 = 0)
        {
            Console.WriteLine($"Not implemented: SetNpcEmotionLoop");
        }

        public void SetNpcEmotionSequence(int arg1 = 0, string arg2 = "", int arg3 = 0)
        {
            Console.WriteLine($"Not implemented: SetNpcEmotionSequence");
        }

        public void SetNpcRotation(int arg1 = 0, int arg2 = 0)
        {
            Console.WriteLine($"Not implemented: SetNpcRotation");
        }

        public void SetOnetimeEffect(int id = 0, bool enable = false, string path = "")
        {
            Console.WriteLine($"Not implemented: SetOnetimeEffect");
        }

        public void SetPcEmotionLoop(string arg1 = "", float arg2 = 0, bool arg3 = false)
        {
            Console.WriteLine($"Not implemented: SetPcEmotionLoop");
        }

        public void SetPcEmotionSequence(string arg1 = "")
        {
            Console.WriteLine($"Not implemented: SetPcEmotionSequence");
        }

        public void SetPcRotation(Vector3 rotation = new Vector3())
        {
            Console.WriteLine($"Not implemented: Vector3");
        }

        public void SetPhotoStudio(bool isEnable = false)
        {
            Console.WriteLine($"Not implemented: SetPhotoStudio");
        }

        public void SetPortal(int portalId = 0, bool visible = false, bool enabled = false, bool minimapVisible = false,
            bool arg5 = false)
        {
            // TODO: This requires GameToGame to be implemented first.
            //Console.WriteLine($"Not implemented: SetPortal");
        }

        public void SetCinematicUI(byte type = 0, string script = "", bool arg3 = false)
        {
            Console.WriteLine($"Not implemented: SetCinematicUI");
        }

        public void SetPvpZone(byte arg1 = 0, byte arg2 = 0, int arg3 = 0, int arg4 = 0, byte arg5 = 0,
            byte[] arg6 = null)
        {
            Console.WriteLine($"Not implemented: SetPvpZone");
        }

        public void SetQuestAccept(int questId = 0, int arg1 = 0)
        {
            Console.WriteLine($"Not implemented: SetQuestAccept");
        }

        public void SetQuestComplete(int questId = 0)
        {
            Console.WriteLine($"Not implemented: SetQuestComplete");
        }

        public void SetRandomMesh(int[] arg1 = null, bool arg2 = false, byte arg3 = 0, int arg4 = 0, int arg5 = 0)
        {
            Console.WriteLine($"Not implemented: SetRandomMesh");
        }

        public void SetRope(int arg1 = 0, bool arg2 = false, bool arg3 = false, byte arg4 = 0)
        {
            Console.WriteLine($"Not implemented: SetRope");
        }

        public void SetSceneSkip(TriggerState state = null, string arg2 = "")
        {
            Console.WriteLine($"Not implemented: SetSceneSkip");
        }

        public void SetSkill(int[] arg1 = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: SetSkill");
        }

        public void SetSkip(TriggerState state = null)
        {
            Console.WriteLine($"Not implemented: SetSkip");
        }

        public void SetSound(int arg1 = 0, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: SetSound");
        }

        public void SetState(byte arg1 = 0, string arg2 = "", bool arg3 = false)
        {
            Console.WriteLine($"Not implemented: SetState");
        }

        public void SetTimer(string id = "", int interval = 0, bool arg3 = false, bool arg4 = false, int arg5 = 0, string arg6 = "")
        {
            if (Timers.TryGetValue(id, out _))
            {
                return;
            }

            Timer timer = new(state => CheckTimerStatus(id, state), false, new TimeSpan(0, 0, 0, 0, 0), new TimeSpan(0, 0, 0, interval, 0));
            Timers.Add(id, new TickTimer(id, timer, interval));
        }

        private void CheckTimerStatus(string id, object state)
        {
            if (!Timers.TryGetValue(id, out TickTimer timer))
            {
                return;
            }

            timer.GetTimer().Change(Timeout.Infinite, Timeout.Infinite);
            timer.SetCurrentInterval(Timeout.Infinite);
        }

        public void SetTimeScale(bool enable = false, float startScale = 0, float endScale = 0, float duration = 0,
            byte interpolator = 0)
        {
            Console.WriteLine($"Not implemented: SetTimeScale");
        }

        public void SetUserValue(int triggerId = 0, string key = "", int value = 0)
        {
            if(UserValues.TryGetValue(key, out int userValue))
            {
                UserValues[key] = userValue;
                return;
            }
            UserValues.Add(key, value);
        }

        public void SetUserValueFromDungeonRewardCount(string key = "", int dungeonRewardId = 0)
        {
            Console.WriteLine($"Not implemented: SetUserValueFromDungeonRewardCount");
        }

        public void SetUserValueFromGuildVsGameScore(int teamId = 0, string key = "")
        {
            Console.WriteLine($"Not implemented: SetUserValueFromGuildVsGameScore");
        }

        public void SetUserValueFromUserCount(int triggerBoxId = 0, string key = "", int userTagId = 0)
        {
            Console.WriteLine($"Not implemented: SetUserValueFromUserCount");
        }

        public void SetVisibleBreakableObject(int[] arg1 = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: SetVisibleBreakableObject");
        }

        public void SetVisibleUI(string uiName = "", bool visible = false)
        {
            Console.WriteLine($"Not implemented: SetVisibleUI");
        }

        public void ShadowExpeditionOpenBossGauge(int maxGaugePoint = 0, string title = "")
        {
            Console.WriteLine($"Not implemented: ShadowExpeditionOpenBossGauge");
        }

        public void ShadowExpeditionCloseBossGauge()
        {
            Console.WriteLine($"Not implemented: ShadowExpeditionCloseBossGauge");
        }

        public void ShowCaption(CaptionType type = CaptionType.Horizontal, string title = "", string script = "",
            Align align = Align.Top,
            float offsetRateX = 0, float offsetRateY = 0, int duration = 0, float scale = 0)
        {
            Console.WriteLine($"Not implemented: ShowCaption");
        }

        public void ShowCountUI(string text = "", byte stage = 0, byte count = 0, byte soundType = 1)
        {
            Console.WriteLine($"Not implemented: ShowCountUI: string text = {text}, byte stage = {stage}, byte count = {count}, byte soundType = {soundType}");
            FieldManager.BroadcastPacket(MassiveEventPacket.Round(text, stage, count, soundType));
        }

        public void ShowEventResult(EventResultType type = EventResultType.Unknown, string text = "", int duration = 0,
            int userTagId = 0,
            int triggerBoxId = 0, bool isOutSide = false)
        {
            Console.WriteLine($"Not implemented: ShowEventResult");
        }

        public void ShowGuideSummary(int entityId = 0, int textId = 0, int duration = 0)
        {
            FieldManager.BroadcastPacket(TriggerPacket.Banner(TriggerPacket.BannerState.On, entityId));
        }

        public void ShowRoundUI(byte round = 0, int duration = 0)
        {
            FieldManager.BroadcastPacket(MassiveEventPacket.RoundHeader(round, false, duration));
        }

        public void SideNpcTalk(int npcId = 0, string illust = "", int duration = 0, string script = "",
            string voice = "",
            SideNpcTalkType type = SideNpcTalkType.Default, string usm = "")
        {
            Console.WriteLine($"Not implemented: SideNpcTalk");
        }

        public void SightRange(bool enable = false, byte range = 0, int rangeZ = 0, byte border = 0)
        {
            Console.WriteLine($"Not implemented: SightRange");
        }

        public void SpawnItemRange(int[] rangeId = null, byte randomPickCount = 0)
        {
            Console.WriteLine($"Not implemented: SpawnItemRange");
        }

        public void SpawnNpcRange(int[] rangeId = null, bool isAutoTargeting = false, byte randomPickCount = 0,
            int score = 0)
        {
            Console.WriteLine($"Not implemented: SpawnNpcRange");
        }

        public void StartCombineSpawn(int[] groupId = null, bool isStart = false)
        {
            Console.WriteLine($"Not implemented: StartCombineSpawn");
        }

        public void StartMiniGame(int boxId = 0, byte round = 0, MiniGame type = MiniGame.Unknown, bool isShowResultUI = true)
        {
            Console.WriteLine($"Not implemented: StartMiniGame: int boxId = {boxId}, byte round = {round}, MiniGame type = {type}, bool isShowResultUI = {isShowResultUI}");
        }

        public void StartMiniGameRound(int boxId = 0, byte round = 0)
        {
            Console.WriteLine($"Not implemented: StartMiniGameRound: int boxId = {boxId}, byte round = {round}");
        }

        public void StartTutorial()
        {
            Console.WriteLine($"Not implemented: StartTutorial");
        }

        public void TalkNpc(int spawnPointId = 0)
        {
            Console.WriteLine($"Not implemented: TalkNpc");
        }

        public void UnSetMiniGameAreaForHack()
        {
            Console.WriteLine($"Not implemented: UnSetMiniGameAreaForHack");
        }

        public void UserTagSymbol(string symbol1 = "", string symbol2 = "")
        {
            Console.WriteLine($"Not implemented: UserTagSymbol");
        }

        public void UserValueToNumberMesh(string key = "", int startMeshId = 0, byte digitCount = 0)
        {
            Console.WriteLine($"Not implemented: UserValueToNumberMesh");
        }

        public void UseState(byte arg1 = 0, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: UseState");
        }

        public void VisibleMyPc(bool isVisible = false)
        {
            Console.WriteLine($"Not implemented: VisibleMyPc");
        }

        public void Weather(WeatherType type = WeatherType.None)
        {
            Console.WriteLine($"Not implemented: Weather");
        }

        public void WeddingBroken()
        {
            Console.WriteLine($"Not implemented: WeddingBroken");
        }

        public void WeddingMoveUser(WeddingEntryType type = WeddingEntryType.Guest, int arg1 = 0, byte[] arg2 = null,
            int arg3 = 0)
        {
            Console.WriteLine($"Not implemented: WeddingMoveUser");
        }

        public void WeddingMutualAgree(WeddingAgreeType type = WeddingAgreeType.Unknown)
        {
            Console.WriteLine($"Not implemented: WeddingMutualAgree");
        }

        public void WeddingMutualCancel(WeddingAgreeType type = WeddingAgreeType.Unknown)
        {
            Console.WriteLine($"Not implemented: WeddingMutualCancel");
        }

        public void WeddingSetUserEmotion(WeddingEntryType type = WeddingEntryType.Guest, byte id = 0)
        {
            Console.WriteLine($"Not implemented: WeddingSetUserEmotion");
        }

        public void WeddingSetUserLookAt(WeddingEntryType type = WeddingEntryType.Guest,
            WeddingEntryType lookAtType = WeddingEntryType.Guest, bool immediate = false)
        {
            Console.WriteLine($"Not implemented: WeddingSetUserLookAt");
        }

        public void WeddingSetUserRotation(WeddingEntryType type = WeddingEntryType.Guest,
            Vector3 rotation = new Vector3(), bool immediate = false)
        {
            Console.WriteLine($"Not implemented: Vector3");
        }

        public void WeddingUserToPatrol(string patrolName = "", WeddingEntryType type = WeddingEntryType.Guest,
            byte patrolIndex = 0)
        {
            Console.WriteLine($"Not implemented: WeddingUserToPatrol");
        }

        public void WeddingVowComplete()
        {
            Console.WriteLine($"Not implemented: WeddingVowComplete");
        }

        public void WidgetAction(WidgetType type = WidgetType.Unknown, string name = "", string args = "",
            int widgetArgNum = 1)
        {
            Console.WriteLine($"Not implemented: WidgetAction");
        }

        public void WriteLog(string arg1 = "", int arg2 = 0, string arg3 = "", byte arg4 = 0, string arg5 = "")
        {
            Console.WriteLine($"Not implemented: WriteLog");
        }

        public bool BonusGameRewardDetected(byte arg1 = 0)
        {
            Console.WriteLine($"Not implemented: BonusGameRewardDetected");
            return false;
        }

        public bool CheckAnyUserAdditionalEffect(int triggerBoxId = 0, int additionalEffectId = 0, byte level = 0)
        {
            Console.WriteLine($"Not implemented: CheckAnyUserAdditionalEffect");
            return false;
        }

        public bool CheckDungeonLobbyUserCount()
        {
            Console.WriteLine($"Not implemented: CheckDungeonLobbyUserCount");
            return false;
        }

        public bool CheckNpcAdditionalEffect(int spawnPointId = 0, int additionalEffectId = 0, byte level = 0)
        {
            Console.WriteLine($"Not implemented: CheckNpcAdditionalEffect");
            return false;
        }

        public bool CheckSameUserTag(int triggerBoxId = 0)
        {
            Console.WriteLine($"Not implemented: CheckSameUserTag");
            return false;
        }

        public bool DayOfWeek(byte[] dayOfWeeks = null, string desc = "")
        {
            Console.WriteLine($"Not implemented: DayOfWeek");
            return false;
        }

        public bool DetectLiftableObject(int[] triggerBoxIds = null, int itemId = 0)
        {
            Console.WriteLine($"Not implemented: DetectLiftableObject");
            return false;
        }

        public bool DungeonTimeOut()
        {
            Console.WriteLine($"Not implemented: DungeonTimeOut");
            return false;
        }

        public bool GuildVsGameScoredTeam(int teamId = 0)
        {
            Console.WriteLine($"Not implemented: GuildVsGameScoredTeam");
            return false;
        }

        public bool GuildVsGameWinnerTeam(int teamId = 0)
        {
            Console.WriteLine($"Not implemented: GuildVsGameWinnerTeam");
            return false;
        }

        public bool IsDungeonRoom()
        {
            Console.WriteLine($"Not implemented: IsDungeonRoom");
            return false;
        }

        public bool IsPlayingMapleSurvival()
        {
            Console.WriteLine($"Not implemented: IsPlayingMapleSurvival");
            return false;
        }

        public bool MonsterDead(int[] arg1 = null, bool arg2 = false)
        {
            Console.WriteLine($"Not implemented: MonsterDead");
            return false;
        }

        public bool MonsterInCombat(int[] arg1 = null)
        {
            Console.WriteLine($"Not implemented: MonsterInCombat");
            return false;
        }

        public bool NpcDetected(int arg1 = 0, int[] arg2 = null)
        {
            Console.WriteLine($"Not implemented: NpcDetected");
            return false;
        }

        public bool NpcIsDeadByStringId(string stringId = "")
        {
            Console.WriteLine($"Not implemented: NpcIsDeadByStringId");
            return false;
        }

        public bool ObjectInteracted(int[] arg1 = null, byte arg2 = 0)
        {
            //Console.WriteLine($"Not implemented: ObjectInteracted - int[] arg1 = {string.Join(", ", arg1)}, byte arg2 = {arg2}");
            return false;
        }

        public bool PvpZoneEnded(byte arg1 = 0)
        {
            Console.WriteLine($"Not implemented: PvpZoneEnded");
            return false;
        }

        public bool QuestUserDetected(int[] arg1 = null, int[] arg2 = null, byte[] arg3 = null, byte arg4 = 0)
        {
            Console.WriteLine($"Not implemented: QuestUserDetected");
            return false;
        }

        public bool RandomCondition(float arg1 = 0, string desc = "")
        {
            switch (RandomConditionValue)
            {
                case > 100:
                {
                    Random gen = new();
                    float val = gen.Next(1, 100);
                    RandomConditionValue = val - arg1;
                    return false;
                }
                case <= 0:
                    RandomConditionValue = 101;
                    return true;
                default:
                    RandomConditionValue -= arg1;
                    return false;
            }
        }

        public bool TimeExpired(string id = "")
        {
            if (!Timers.TryGetValue(id, out TickTimer timer))
            {
                return true;
            }

            return timer.GetCurrentInterval() == Timeout.Infinite;
        }

        public bool UserDetected(int[] arg1 = null, byte arg2 = 0)
        {
            //Console.WriteLine($"Not implemented: UserDetected - int[] arg1 = {string.Join(", ", arg1)}, byte arg2 = {arg2}");
            return true;
        }

        public bool WaitAndResetTick(int waitTick = 0)
        {
            Thread.Sleep(waitTick);
            return true;
        }

        public bool WaitTick(int waitTick = 0)
        {
            Thread.Sleep(waitTick);
            return true;
        }

        public bool WeddingEntryInField(WeddingEntryType type = WeddingEntryType.Guest)
        {
            Console.WriteLine($"Not implemented: WeddingEntryInField");
            return false;
        }

        public bool WeddingHallState(string hallState = "")
        {
            Console.WriteLine($"Not implemented: WeddingHallState");
            return false;
        }

        public bool? WeddingMutualAgreeResult(WeddingAgreeType type = WeddingAgreeType.Unknown)
        {
            Console.WriteLine($"Not implemented: WeddingMutualAgreeResult");
            return false;
        }

        public bool WidgetCondition(WidgetType type = WidgetType.Unknown, string arg2 = "", string arg3 = "")
        {
            Console.WriteLine($"Not implemented: WidgetCondition");
            return false;
        }

        public int GetDungeonFirstUserMissionScore()
        {
            Console.WriteLine($"Not implemented: GetDungeonFirstUserMissionScore");
            return 0;
        }

        public int GetDungeonId()
        {
            Console.WriteLine($"Not implemented: GetDungeonId");
            return 0;
        }

        public int GetDungeonLevel()
        {
            Console.WriteLine($"Not implemented: GetDungeonLevel");
            return 0;
        }

        public int GetDungeonMaxUserCount()
        {
            Console.WriteLine($"Not implemented: GetDungeonMaxUserCount");
            return 0;
        }

        public int GetDungeonPlayTime()
        {
            Console.WriteLine($"Not implemented: GetDungeonPlayTime");
            return 0;
        }

        public int GetDungeonRoundsRequired()
        {
            Console.WriteLine($"Not implemented: GetDungeonRoundsRequired");
            return 0;
        }

        public string GetDungeonState()
        {
            Console.WriteLine($"Not implemented: GetDungeonState");
            return "";
        }

        public bool GetDungeonVariable(int id)
        {
            Console.WriteLine($"Not implemented: GetDungeonVariable");
            return false;
        }

        public float GetNpcDamageRate(int spawnPointId)
        {
            Console.WriteLine($"Not implemented: GetNpcDamageRate");
            return 0f;
        }

        public int GetNpcExtraData(int spawnPointId, string extraDataKey)
        {
            Console.WriteLine($"Not implemented: GetNpcExtraData");
            return 0;
        }

        public float GetNpcHpRate(int spawnPointId)
        {
            Console.WriteLine($"Not implemented: GetNpcHpRate");
            return 0f;
        }

        public int GetScoreBoardScore()
        {
            Console.WriteLine($"Not implemented: GetScoreBoardScore");
            return 0;
        }

        public int GetShadowExpeditionPoints()
        {
            Console.WriteLine($"Not implemented: GetShadowExpeditionPoints");
            return 0;
        }

        public int GetUserCount(int boxId = 0, int userTagId = 0)
        {
            //return 1;
            return 20;
        }

        public int GetUserValue(string key)
        {
            if (!UserValues.TryGetValue(key, out int value))
            {
                return default;
            }
            return value;
        }
        
        private class TickTimer
        {
            private readonly string Id;
            private readonly Timer Timer;
            private readonly int StartInterval;
            private int CurrentInterval;

            public TickTimer(string id, Timer timer, int startInterval)
            {
                Id = id;
                Timer = timer;
                StartInterval = startInterval;
                CurrentInterval = startInterval;
            }

            public Timer GetTimer()
            {
                return Timer;
            }

            public int GetStartInterval()
            {
                return StartInterval;
            }
        
            public int GetCurrentInterval()
            {
                return CurrentInterval;
            }

            public void SetCurrentInterval(int interval)
            {
                CurrentInterval = interval;
            }
        }
    }
}
