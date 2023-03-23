using Artemis.Core;
using Artemis.Core.Modules;
using ArtemisOsu.DataModels;
using System.Collections.Generic;
using Serilog;
using OsuMemoryDataProvider;
using OsuMemoryDataProvider.OsuMemoryModels;
using OsuMemoryDataProvider.OsuMemoryModels.Direct;

namespace ArtemisOsu
{
    [PluginFeature(Name = "ArtemisOsu")]
    public class OsuModule : Module<OsuDataModel>
    {
        private readonly ILogger _logger;
        private readonly OsuBaseAddresses _baseAddresses;
        private StructuredOsuMemoryReader? _osuMemoryReader;
        
        public OsuModule(ILogger logger)
        {
            _logger = logger;
            _baseAddresses = new();
        }

        public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new()
        {
            new ProcessActivationRequirement("osu!"),
        };
        
        public override void Enable()
        {
        }

        public override void Disable()
        {
        }

        public override void ModuleActivated(bool isOverride)
        {
            _osuMemoryReader = new StructuredOsuMemoryReader();
        }
        
        public override void ModuleDeactivated(bool isOverride)
        {
            _osuMemoryReader?.Dispose();
            _osuMemoryReader = null;
        }

        public override void Update(double deltaTime)
        {
            if (_osuMemoryReader is null)
                return;
            
            _osuMemoryReader.TryRead(_baseAddresses.Beatmap);
            _osuMemoryReader.TryRead(_baseAddresses.Skin);
            _osuMemoryReader.TryRead(_baseAddresses.GeneralData);
            
            if (_baseAddresses.GeneralData.OsuStatus == OsuMemoryStatus.SongSelect)
                _osuMemoryReader.TryRead(_baseAddresses.SongSelectionScores);
            else
                _baseAddresses.SongSelectionScores.Scores.Clear();

            if (_baseAddresses.GeneralData.OsuStatus == OsuMemoryStatus.ResultsScreen)
                _osuMemoryReader.TryRead(_baseAddresses.ResultsScreen);

            if (_baseAddresses.GeneralData.OsuStatus == OsuMemoryStatus.Playing)
            {
                _osuMemoryReader.TryRead(_baseAddresses.Player);
                //TODO: flag needed for single/multi player detection (should be read once per play in singleplayer)
                _osuMemoryReader.TryRead(_baseAddresses.LeaderBoard);
                _osuMemoryReader.TryRead(_baseAddresses.KeyOverlay);
            }
            else
            {
                _baseAddresses.LeaderBoard.Players.Clear();
            }

            DataModel.Beatmap.Name = _baseAddresses.Beatmap.MapString;
            DataModel.Beatmap.AR = _baseAddresses.Beatmap.Ar;
            DataModel.Beatmap.CS = _baseAddresses.Beatmap.Cs;
            DataModel.Beatmap.HP = _baseAddresses.Beatmap.Hp;
            DataModel.Beatmap.OD = _baseAddresses.Beatmap.Od;
            DataModel.Beatmap.Id = _baseAddresses.Beatmap.Id;
            DataModel.Beatmap.SetId = _baseAddresses.Beatmap.SetId;
            DataModel.Beatmap.Status = _baseAddresses.Beatmap.Status;

            DataModel.Player.Name = _baseAddresses.Player.Username;
            DataModel.Player.Score = _baseAddresses.Player.Score;
            DataModel.Player.Combo = _baseAddresses.Player.Combo;
            DataModel.Player.MaxCombo = _baseAddresses.Player.MaxCombo;
            DataModel.Player.HP = _baseAddresses.Player.HP;
            DataModel.Player.H300 = _baseAddresses.Player.Hit300;
            DataModel.Player.H100 = _baseAddresses.Player.Hit100;
            DataModel.Player.H50 = _baseAddresses.Player.Hit50;
            DataModel.Player.Katu = _baseAddresses.Player.HitKatu;
            DataModel.Player.Geki = _baseAddresses.Player.HitGeki;
            DataModel.Player.Miss = _baseAddresses.Player.HitMiss;

            DataModel.Game.Gamemode = _baseAddresses.GeneralData.GameMode;
            DataModel.Game.Mods = _baseAddresses.GeneralData.Mods;
            DataModel.Game.RawStatus = _baseAddresses.GeneralData.RawStatus;
            DataModel.Game.Status = _baseAddresses.GeneralData.OsuStatus.ToString();
            DataModel.Game.IsChatExpanded = _baseAddresses.GeneralData.ChatIsExpanded;
        }
    }
}