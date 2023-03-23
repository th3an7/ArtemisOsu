using Artemis.Core.Modules;
using Artemis.Core.Properties;

namespace ArtemisOsu.DataModels
{
    public class OsuDataModel : DataModel
    {
        public OsuPlayerDataModel Player { get; set; } = new OsuPlayerDataModel();
        public OsuBeatmapDataModel Beatmap { get; set; } = new OsuBeatmapDataModel();
        public OsuGameDataModel Game { get; set; } = new OsuGameDataModel();
    }

    public class OsuPlayerDataModel : DataModel
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Combo { get; set; }
        public int MaxCombo { get; set; }
        public double HP { get; set; }
        public int H300 { get; set; }
        public int H100 { get; set; }
        public int H50 { get; set; }
        public int Katu { get; set; }
        public int Geki { get; set; }
        public int Miss { get; set; }


    }

    public class OsuBeatmapDataModel : DataModel
    {
        public string Name { get; set; }
        public float AR { get; set; }
        public float CS { get; set; }
        public float HP { get; set; }
        public float OD { get; set; }
        public int Id { get; set; }
        public int SetId { get; set; }
        public short Status { get; set; }
    }

    public class OsuGameDataModel : DataModel
    {
        public int Gamemode { get; set; }
        public int Mods { get; set; }
        public string Status { get; set; }
        public int RawStatus { get; set; }
        public bool IsChatExpanded { get; set; }
    }
}