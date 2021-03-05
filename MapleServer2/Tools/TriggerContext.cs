using System;
using System.Numerics;
using Maple2.Trigger;
using Maple2.Trigger.Enum;

namespace MapleServer2.Tools
{
    public class TriggerContext : ITriggerContext
    {
        public int TickDelay = 0;
        public int NextTick;

        public void AddBalloonTalk(int spawnPointId = 0, string msg = "", int duration = 0, int delayTick = 0, bool npcId = false)
        {
            throw new NotImplementedException();
        }

        public void AddBuff(int[] arg1 = null, int arg2 = 0, byte arg3 = 0, bool arg4 = false, bool arg5 = false, string feature = "")
        {
            throw new NotImplementedException();
        }

        public void AddCinematicTalk(int npcId = 0, string illustId = "", string script = "", int duration = 0, Align align = Align.Top,
            int delayTick = 0)
        {
            throw new NotImplementedException();
        }

        public void AddEffectNif(int spawnPointId = 0, string nifPath = "", bool isOutline = false, float scale = 0, int rotateZ = 0)
        {
            throw new NotImplementedException();
        }

        public void AddUserValue(string key = "", int value = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeBoomBoomOceanSetSkillScore(int id = 0, int score = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeBoomBoomOceanStartGame(byte lifeCount = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeBoomBoomOceanEndGame()
        {
            throw new NotImplementedException();
        }

        public void ArcadeBoomBoomOceanStartRound(byte round = 0, int roundDuration = 0, int timeScoreRate = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeBoomBoomOceanClearRound(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeSpringFarmSetInteractScore(int id = 0, int score = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeSpringFarmSpawnMonster(int[] spawnId = null, int score = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeSpringFarmStartGame(byte lifeCount = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeSpringFarmEndGame()
        {
            throw new NotImplementedException();
        }

        public void ArcadeSpringFarmStartRound(byte round = 0, int uiDuration = 0, string timeScoreType = "", int timeScoreRate = 0,
            int roundDuration = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeSpringFarmClearRound(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeThreeTwoOneStartGame(byte lifeCount = 0, int initScore = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeThreeTwoOneEndGame()
        {
            throw new NotImplementedException();
        }

        public void ArcadeThreeTwoOneStartRound(byte round = 0, int uiDuration = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeThreeTwoOneResultRound(byte resultDirection = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeThreeTwoOneResultRound2(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void ArcadeThreeTwoOneClearRound(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void ChangeBackground(string dds = "")
        {
            throw new NotImplementedException();
        }

        public void ChangeMonster(int arg1 = 0, int arg2 = 0)
        {
            throw new NotImplementedException();
        }

        public void CameraReset(float interpolationTime = 0)
        {
            throw new NotImplementedException();
        }

        public void CameraSelect(int arg1 = 0, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void CameraSelectPath(int[] pathIds = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void CloseCinematic()
        {
            throw new NotImplementedException();
        }

        public void CreateFieldGame(FieldGame type = FieldGame.Unknown, bool reset = false)
        {
            throw new NotImplementedException();
        }

        public void CreateItem(int[] arg1 = null, int arg2 = 0, int arg3 = 0, int arg5 = 0)
        {
            throw new NotImplementedException();
        }

        public void CreateMonster(int[] arg1 = null, bool arg2 = false, int arg3 = 0)
        {
            throw new NotImplementedException();
        }

        public void CreateWidget(WidgetType type = WidgetType.Unknown)
        {
            throw new NotImplementedException();
        }

        public void DarkStreamSpawnMonster(int[] spawnId = null, int score = 0)
        {
            throw new NotImplementedException();
        }

        public void DarkStreamStartGame(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void DarkStreamStartRound(byte round = 0, int uiDuration = 0, int damagePenalty = 0)
        {
            throw new NotImplementedException();
        }

        public void DarkStreamClearRound(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void DebugString(string message = "", string feature = "")
        {
            throw new NotImplementedException();
        }

        public void DestroyMonster(int[] arg1 = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void DungeonClear(string uiType = "None")
        {
            throw new NotImplementedException();
        }

        public void DungeonClearRound(byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void DungeonCloseTimer()
        {
            throw new NotImplementedException();
        }

        public void DungeonDisableRanking()
        {
            throw new NotImplementedException();
        }

        public void DungeonEnableGiveUp(bool isEnable = false)
        {
            throw new NotImplementedException();
        }

        public void DungeonFail()
        {
            throw new NotImplementedException();
        }

        public void DungeonMissionComplete(int missionId = 0, string feature = "")
        {
            throw new NotImplementedException();
        }

        public void DungeonMoveLapTimeToNow(bool id = false)
        {
            throw new NotImplementedException();
        }

        public void DungeonResetTime(int seconds = 0)
        {
            throw new NotImplementedException();
        }

        public void DungeonSetEndTime()
        {
            throw new NotImplementedException();
        }

        public void DungeonSetLapTime(byte id = 0, int lapTime = 0)
        {
            throw new NotImplementedException();
        }

        public void DungeonStopTimer()
        {
            throw new NotImplementedException();
        }

        public void SetDungeonVariable(int varId = 0, bool value = false)
        {
            throw new NotImplementedException();
        }

        public void EnableLocalCamera(bool isEnable = false)
        {
            throw new NotImplementedException();
        }

        public void EnableSpawnPointPc(int spawnPointId = 0, bool isEnable = false)
        {
            throw new NotImplementedException();
        }

        public void EndMiniGame(int winnerBoxId = 0, MiniGame type = MiniGame.Unknown, bool isOnlyWinner = false)
        {
            throw new NotImplementedException();
        }

        public void EndMiniGameRound(int winnerBoxId = 0, float expRate = 0, bool isOnlyWinner = false, bool isGainLoserBonus = false,
            bool meso = false, MiniGame type = MiniGame.Unknown)
        {
            throw new NotImplementedException();
        }

        public void FaceEmotion(int spawnPointId = 0, string emotionName = "")
        {
            throw new NotImplementedException();
        }

        public void FieldGameConstant(string key = "", string value = "", string feature = "", Locale locale = Locale.ALL)
        {
            throw new NotImplementedException();
        }

        public void FieldGameMessage(byte custom = 0, string type = "", byte arg1 = 0, string arg2 = "", int arg3 = 0)
        {
            throw new NotImplementedException();
        }

        public void FieldWarEnd(bool isClear = false)
        {
            throw new NotImplementedException();
        }

        public void GiveExp(byte arg1 = 0, byte arg2 = 0)
        {
            throw new NotImplementedException();
        }

        public void GiveGuildExp(bool boxId = false, byte type = 0)
        {
            throw new NotImplementedException();
        }

        public void GiveRewardContent(int rewardId = 0)
        {
            throw new NotImplementedException();
        }

        public void GuideEvent(int eventId = 0)
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameEndGame()
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameGiveContribution(int teamId = 0, bool isWin = false, string desc = "")
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameGiveReward(GuildReward type = GuildReward.None, int teamId = 0, bool isWin = false, string desc = "")
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameLogResult(string desc = "")
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameLogWonByDefault(int teamId = 0, string desc = "")
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameResult(string desc = "")
        {
            throw new NotImplementedException();
        }

        public void GuildVsGameScoreByUser(int triggerBoxId = 0, bool score = false, string desc = "")
        {
            throw new NotImplementedException();
        }

        public void HideGuideSummary(int entityId = 0, int textId = 0)
        {
            throw new NotImplementedException();
        }

        public void InitNpcRotation(int[] arg1 = null)
        {
            throw new NotImplementedException();
        }

        public void KickMusicAudience(int targetBoxId = 0, int targetPortalId = 0)
        {
            throw new NotImplementedException();
        }

        public void LimitSpawnNpcCount(byte limitCount = 0)
        {
            throw new NotImplementedException();
        }

        public void LockMyPc(bool isLock = false)
        {
            throw new NotImplementedException();
        }

        public void MiniGameCameraDirection(int boxId = 0, int cameraId = 0)
        {
            throw new NotImplementedException();
        }

        public void MiniGameGiveExp(int boxId = 0, float expRate = 0, bool isOutSide = true)
        {
            throw new NotImplementedException();
        }

        public void MiniGameGiveReward(int winnerBoxId = 0, string contentType = "", MiniGame type = MiniGame.Unknown)
        {
            throw new NotImplementedException();
        }

        public void MoveNpc(int arg1 = 0, string arg2 = "")
        {
            throw new NotImplementedException();
        }

        public void MoveNpcToPos(int spawnPointId = 0, Vector3 pos = new Vector3(), Vector3 rot = new Vector3())
        {
            throw new NotImplementedException();
        }

        public void MoveRandomUser(int arg1 = 0, byte arg2 = 0, int arg3 = 0, byte arg4 = 0)
        {
            throw new NotImplementedException();
        }

        public void MoveToPortal(int userTagId = 0, int portalId = 0, int boxId = 0)
        {
            throw new NotImplementedException();
        }

        public void MoveUser(int arg1 = 0, int arg2 = 0, int arg3 = 0)
        {
            throw new NotImplementedException();
        }

        public void MoveUserPath(string arg1 = "")
        {
            throw new NotImplementedException();
        }

        public void MoveUserToBox(int boxId = 0, bool portalId = false)
        {
            throw new NotImplementedException();
        }

        public void MoveUserToPos(Vector3 pos = new Vector3(), Vector3 rot = new Vector3())
        {
            throw new NotImplementedException();
        }

        public void Notice(bool arg1 = false, string arg2 = "", bool arg3 = false)
        {
            throw new NotImplementedException();
        }

        public void NpcRemoveAdditionalEffect(int spawnPointId = 0, int additionalEffectId = 0)
        {
            throw new NotImplementedException();
        }

        public void NpcToPatrolInBox(int boxId = 0, int npcId = 0, string spawnId = "", string patrolName = "")
        {
            throw new NotImplementedException();
        }

        public void PatrolConditionUser(string patrolName = "", byte patrolIndex = 0, int additionalEffectId = 0)
        {
            throw new NotImplementedException();
        }

        public void PlaySceneMovie(string fileName = "", int movieId = 0, string skipType = "")
        {
            throw new NotImplementedException();
        }

        public void PlaySystemSoundByUserTag(int userTagId = 0, string soundKey = "")
        {
            throw new NotImplementedException();
        }

        public void PlaySystemSoundInBox(int[] arg1 = null, string arg2 = "")
        {
            throw new NotImplementedException();
        }

        public void RandomAdditionalEffect(string target = "", int triggerBoxId = 0, int spawnPointId = 0, byte targetCount = 0,
            int tick = 0, int waitTick = 0, string targetEffect = "", int additionalEffectId = 0)
        {
            throw new NotImplementedException();
        }

        public void RemoveBalloonTalk(int spawnPointId = 0)
        {
            throw new NotImplementedException();
        }

        public void RemoveBuff(int arg1 = 0, int arg2 = 0, bool arg3 = false)
        {
            throw new NotImplementedException();
        }

        public void RemoveCinematicTalk()
        {
            throw new NotImplementedException();
        }

        public void RemoveEffectNif(int spawnPointId = 0)
        {
            throw new NotImplementedException();
        }

        public void ResetTimer(string id = "")
        {
            throw new NotImplementedException();
        }

        public void RoomExpire()
        {
            throw new NotImplementedException();
        }

        public void ScoreBoardCreate(string type = "", int maxScore = 0)
        {
            throw new NotImplementedException();
        }

        public void ScoreBoardRemove()
        {
            throw new NotImplementedException();
        }

        public void ScoreBoardSetScore(bool score = false)
        {
            throw new NotImplementedException();
        }

        public void SetAchievement(int arg1 = 0, string arg2 = "", string arg3 = "")
        {
            throw new NotImplementedException();
        }

        public void SetActor(int arg1 = 0, bool arg2 = false, string arg3 = "", bool arg4 = false, bool arg5 = false)
        {
            throw new NotImplementedException();
        }

        public void SetAgent(int[] arg1 = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void SetAiExtraData(string key = "", int value = 0, bool isModify = false, int boxId = 0)
        {
            throw new NotImplementedException();
        }

        public void SetAmbientLight(Vector3 arg1 = new Vector3(), Vector3 arg2 = new Vector3(), Vector3 arg3 = new Vector3())
        {
            throw new NotImplementedException();
        }

        public void SetCinematicIntro(string text = "")
        {
            throw new NotImplementedException();
        }

        public void SetConversation(byte arg1 = 0, int arg2 = 0, string script = "", int arg4 = 0, byte arg5 = 0, Align align = Align.Top)
        {
            throw new NotImplementedException();
        }

        public void SetCube(int[] ids = null, bool isVisible = false, byte randomCount = 0)
        {
            throw new NotImplementedException();
        }

        public void SetDirectionalLight(Vector3 arg1 = new Vector3(), Vector3 arg2 = new Vector3())
        {
            throw new NotImplementedException();
        }

        public void SetEffect(int[] arg1 = null, bool arg2 = false, int arg3 = 0, byte arg4 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetEventUI(byte arg1 = 0, string script = "", int arg3 = 0, string arg4 = "")
        {
            throw new NotImplementedException();
        }

        public void SetGravity(float gravity = 0)
        {
            throw new NotImplementedException();
        }

        public void SetInteractObject(int[] arg1 = null, byte arg2 = 0, bool arg4 = false, bool arg3 = false)
        {
            throw new NotImplementedException();
        }

        public void SetLadder(int arg1 = 0, bool arg2 = false, bool arg3 = false, byte arg4 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetLocalCamera(int cameraId = 0, bool enable = false)
        {
            throw new NotImplementedException();
        }

        public void SetMesh(int[] arg1 = null, bool arg2 = false, int arg3 = 0, int arg4 = 0, float arg5 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetMeshAnimation(int[] arg1 = null, bool arg2 = false, byte arg3 = 0, byte arg4 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetMiniGameAreaForHack(int boxId = 0)
        {
            throw new NotImplementedException();
        }

        public void SetBreakable(int[] arg1 = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void SetNpcDuelHpBar(bool isOpen = false, int spawnPointId = 0, int durationTick = 0, byte npcHpStep = 0)
        {
            throw new NotImplementedException();
        }

        public void SetNpcEmotionLoop(int arg1 = 0, string arg2 = "", float arg3 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetNpcEmotionSequence(int arg1 = 0, string arg2 = "", int arg3 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetNpcRotation(int arg1 = 0, int arg2 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetOnetimeEffect(int id = 0, bool enable = false, string path = "")
        {
            throw new NotImplementedException();
        }

        public void SetPcEmotionLoop(string arg1 = "", float arg2 = 0, bool arg3 = false)
        {
            throw new NotImplementedException();
        }

        public void SetPcEmotionSequence(string arg1 = "")
        {
            throw new NotImplementedException();
        }

        public void SetPcRotation(Vector3 rotation = new Vector3())
        {
            throw new NotImplementedException();
        }

        public void SetPhotoStudio(bool isEnable = false)
        {
            throw new NotImplementedException();
        }

        public void SetPortal(int portalId = 0, bool visible = false, bool enabled = false, bool minimapVisible = false,
            bool arg5 = false)
        {
            throw new NotImplementedException();
        }

        public void SetCinematicUI(byte type = 0, string script = "", bool arg3 = false)
        {
            throw new NotImplementedException();
        }

        public void SetPvpZone(byte arg1 = 0, byte arg2 = 0, int arg3 = 0, int arg4 = 0, byte arg5 = 0, byte[] arg6 = null)
        {
            throw new NotImplementedException();
        }

        public void SetQuestAccept(int questId = 0, int arg1 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetQuestComplete(int questId = 0)
        {
            throw new NotImplementedException();
        }

        public void SetRandomMesh(int[] arg1 = null, bool arg2 = false, byte arg3 = 0, int arg4 = 0, int arg5 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetRope(int arg1 = 0, bool arg2 = false, bool arg3 = false, byte arg4 = 0)
        {
            throw new NotImplementedException();
        }

        public void SetSceneSkip(TriggerState state = null, string arg2 = "")
        {
            throw new NotImplementedException();
        }

        public void SetSkill(int[] arg1 = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void SetSkip(TriggerState state = null)
        {
            throw new NotImplementedException();
        }

        public void SetSound(int arg1 = 0, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void SetState(byte arg1 = 0, string arg2 = "", bool arg3 = false)
        {
            throw new NotImplementedException();
        }

        public void SetTimer(string id = "", int arg2 = 0, bool arg3 = false, bool arg4 = false, int arg5 = 0, string arg6 = "")
        {
            throw new NotImplementedException();
        }

        public void SetTimeScale(bool enable = false, float startScale = 0, float endScale = 0, float duration = 0,
            byte interpolator = 0)
        {
            throw new NotImplementedException();
        }

        public void SetUserValue(int triggerId = 0, string key = "", int value = 0)
        {
            throw new NotImplementedException();
        }

        public void SetUserValueFromDungeonRewardCount(string key = "", int dungeonRewardId = 0)
        {
            throw new NotImplementedException();
        }

        public void SetUserValueFromGuildVsGameScore(int teamId = 0, string key = "")
        {
            throw new NotImplementedException();
        }

        public void SetUserValueFromUserCount(int triggerBoxId = 0, string key = "", int userTagId = 0)
        {
            throw new NotImplementedException();
        }

        public void SetVisibleBreakableObject(int[] arg1 = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void SetVisibleUI(string uiName = "", bool visible = false)
        {
            throw new NotImplementedException();
        }

        public void ShadowExpeditionOpenBossGauge(int maxGaugePoint = 0, string title = "")
        {
            throw new NotImplementedException();
        }

        public void ShadowExpeditionCloseBossGauge()
        {
            throw new NotImplementedException();
        }

        public void ShowCaption(CaptionType type = CaptionType.Horizontal, string title = "", string script = "", Align align = Align.Top,
            float offsetRateX = 0, float offsetRateY = 0, int duration = 0, float scale = 0)
        {
            throw new NotImplementedException();
        }

        public void ShowCountUI(string text = "", byte stage = 0, byte count = 0, byte soundType = 1)
        {
            throw new NotImplementedException();
        }

        public void ShowEventResult(EventResultType type = EventResultType.Unknown, string text = "", int duration = 0, int userTagId = 0,
            int triggerBoxId = 0, bool isOutSide = false)
        {
            throw new NotImplementedException();
        }

        public void ShowGuideSummary(int entityId = 0, int textId = 0, int duration = 0)
        {
            throw new NotImplementedException();
        }

        public void ShowRoundUI(byte round = 0, int duration = 0)
        {
            throw new NotImplementedException();
        }

        public void SideNpcTalk(int npcId = 0, string illust = "", int duration = 0, string script = "", string voice = "",
            SideNpcTalkType type = SideNpcTalkType.Default, string usm = "")
        {
            throw new NotImplementedException();
        }

        public void SightRange(bool enable = false, byte range = 0, int rangeZ = 0, byte border = 0)
        {
            throw new NotImplementedException();
        }

        public void SpawnItemRange(int[] rangeId = null, byte randomPickCount = 0)
        {
            throw new NotImplementedException();
        }

        public void SpawnNpcRange(int[] rangeId = null, bool isAutoTargeting = false, byte randomPickCount = 0, int score = 0)
        {
            throw new NotImplementedException();
        }

        public void StartCombineSpawn(int[] groupId = null, bool isStart = false)
        {
            throw new NotImplementedException();
        }

        public void StartMiniGame(int boxId = 0, byte round = 0, MiniGame type = MiniGame.Unknown, bool isShowResultUI = true)
        {
            throw new NotImplementedException();
        }

        public void StartMiniGameRound(int boxId = 0, byte round = 0)
        {
            throw new NotImplementedException();
        }

        public void StartTutorial()
        {
            throw new NotImplementedException();
        }

        public void TalkNpc(int spawnPointId = 0)
        {
            throw new NotImplementedException();
        }

        public void UnSetMiniGameAreaForHack()
        {
            throw new NotImplementedException();
        }

        public void UserTagSymbol(string symbol1 = "", string symbol2 = "")
        {
            throw new NotImplementedException();
        }

        public void UserValueToNumberMesh(string key = "", int startMeshId = 0, byte digitCount = 0)
        {
            throw new NotImplementedException();
        }

        public void UseState(byte arg1 = 0, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public void VisibleMyPc(bool isVisible = false)
        {
            throw new NotImplementedException();
        }

        public void Weather(WeatherType type = WeatherType.None)
        {
            throw new NotImplementedException();
        }

        public void WeddingBroken()
        {
            throw new NotImplementedException();
        }

        public void WeddingMoveUser(WeddingEntryType type = WeddingEntryType.Guest, int arg1 = 0, byte[] arg2 = null, int arg3 = 0)
        {
            throw new NotImplementedException();
        }

        public void WeddingMutualAgree(WeddingAgreeType type = WeddingAgreeType.Unknown)
        {
            throw new NotImplementedException();
        }

        public void WeddingMutualCancel(WeddingAgreeType type = WeddingAgreeType.Unknown)
        {
            throw new NotImplementedException();
        }

        public void WeddingSetUserEmotion(WeddingEntryType type = WeddingEntryType.Guest, byte id = 0)
        {
            throw new NotImplementedException();
        }

        public void WeddingSetUserLookAt(WeddingEntryType type = WeddingEntryType.Guest, WeddingEntryType lookAtType = WeddingEntryType.Guest, bool immediate = false)
        {
            throw new NotImplementedException();
        }

        public void WeddingSetUserRotation(WeddingEntryType type = WeddingEntryType.Guest, Vector3 rotation = new Vector3(), bool immediate = false)
        {
            throw new NotImplementedException();
        }

        public void WeddingUserToPatrol(string patrolName = "", WeddingEntryType type = WeddingEntryType.Guest, byte patrolIndex = 0)
        {
            throw new NotImplementedException();
        }

        public void WeddingVowComplete()
        {
            throw new NotImplementedException();
        }

        public void WidgetAction(WidgetType type = WidgetType.Unknown, string name = "", string args = "", int widgetArgNum = 1)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string arg1 = "", int arg2 = 0, string arg3 = "", byte arg4 = 0, string arg5 = "")
        {
            throw new NotImplementedException();
        }

        public bool BonusGameRewardDetected(byte arg1 = 0)
        {
            throw new NotImplementedException();
        }

        public bool CheckAnyUserAdditionalEffect(int triggerBoxId = 0, int additionalEffectId = 0, byte level = 0)
        {
            throw new NotImplementedException();
        }

        public bool CheckDungeonLobbyUserCount()
        {
            throw new NotImplementedException();
        }

        public bool CheckNpcAdditionalEffect(int spawnPointId = 0, int additionalEffectId = 0, byte level = 0)
        {
            throw new NotImplementedException();
        }

        public bool CheckSameUserTag(int triggerBoxId = 0)
        {
            throw new NotImplementedException();
        }

        public bool DayOfWeek(byte[] dayOfWeeks = null, string desc = "")
        {
            throw new NotImplementedException();
        }

        public bool DetectLiftableObject(int[] triggerBoxIds = null, int itemId = 0)
        {
            throw new NotImplementedException();
        }

        public bool DungeonTimeOut()
        {
            throw new NotImplementedException();
        }

        public bool GuildVsGameScoredTeam(int teamId = 0)
        {
            throw new NotImplementedException();
        }

        public bool GuildVsGameWinnerTeam(int teamId = 0)
        {
            throw new NotImplementedException();
        }

        public bool IsDungeonRoom()
        {
            throw new NotImplementedException();
        }

        public bool IsPlayingMapleSurvival()
        {
            throw new NotImplementedException();
        }

        public bool MonsterDead(int[] arg1 = null, bool arg2 = false)
        {
            throw new NotImplementedException();
        }

        public bool MonsterInCombat(int[] arg1 = null)
        {
            throw new NotImplementedException();
        }

        public bool NpcDetected(int arg1 = 0, int[] arg2 = null)
        {
            throw new NotImplementedException();
        }

        public bool NpcIsDeadByStringId(string stringId = "")
        {
            throw new NotImplementedException();
        }

        public bool ObjectInteracted(int[] arg1 = null, byte arg2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool PvpZoneEnded(byte arg1 = 0)
        {
            throw new NotImplementedException();
        }

        public bool QuestUserDetected(int[] arg1 = null, int[] arg2 = null, byte[] arg3 = null, byte arg4 = 0)
        {
            throw new NotImplementedException();
        }

        public bool RandomCondition(float arg1 = 0, string desc = "")
        {
            throw new NotImplementedException();
        }

        public bool TimeExpired(string arg1 = "")
        {
            throw new NotImplementedException();
        }

        public bool UserDetected(int[] arg1 = null, byte arg2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool WaitAndResetTick(int waitTick = 0)
        {
            throw new NotImplementedException();
        }

        public bool WaitTick(int waitTick = 0)
        {
            throw new NotImplementedException();
        }

        public bool WeddingEntryInField(WeddingEntryType type = WeddingEntryType.Guest)
        {
            throw new NotImplementedException();
        }

        public bool WeddingHallState(string hallState = "")
        {
            throw new NotImplementedException();
        }

        public bool? WeddingMutualAgreeResult(WeddingAgreeType type = WeddingAgreeType.Unknown)
        {
            throw new NotImplementedException();
        }

        public bool WidgetCondition(WidgetType type = WidgetType.Unknown, string arg2 = "", string arg3 = "")
        {
            throw new NotImplementedException();
        }

        public int GetDungeonFirstUserMissionScore()
        {
            throw new NotImplementedException();
        }

        public int GetDungeonId()
        {
            throw new NotImplementedException();
        }

        public int GetDungeonLevel()
        {
            throw new NotImplementedException();
        }

        public int GetDungeonMaxUserCount()
        {
            throw new NotImplementedException();
        }

        public int GetDungeonPlayTime()
        {
            throw new NotImplementedException();
        }

        public int GetDungeonRoundsRequired()
        {
            throw new NotImplementedException();
        }

        public string GetDungeonState()
        {
            throw new NotImplementedException();
        }

        public bool GetDungeonVariable(int id)
        {
            throw new NotImplementedException();
        }

        public float GetNpcDamageRate(int spawnPointId)
        {
            throw new NotImplementedException();
        }

        public int GetNpcExtraData(int spawnPointId, string extraDataKey)
        {
            throw new NotImplementedException();
        }

        public float GetNpcHpRate(int spawnPointId)
        {
            throw new NotImplementedException();
        }

        public int GetScoreBoardScore()
        {
            throw new NotImplementedException();
        }

        public int GetShadowExpeditionPoints()
        {
            throw new NotImplementedException();
        }

        public int GetUserCount(int boxId = 0, int userTagId = 0)
        {
            throw new NotImplementedException();
        }

        public int GetUserValue(string key)
        {
            throw new NotImplementedException();
        }
    }
}
