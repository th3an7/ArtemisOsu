using Artemis.Core;
using Artemis.Core.Modules;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArtemisOsu.DataModels
{
    public class PluginDataModel : DataModel
    {
        /*public Menu menu { get; set; } = new Menu();
        public Gameplay gameplay { get; set; } = new Gameplay();
        public Time time { get; set; } = new Time();
        public Metadata metadata { get; set; } = new Metadata();
        public BPM bpm { get; set; } = new BPM();
        public Stats stats { get; set; } = new Stats();
        public Path path { get; set; } = new Path();
        public Bm bm { get; set; } = new Bm();
        public Mods mods { get; set; } = new Mods();
        public Pp pp { get; set; } = new Pp();
        public Combo combo { get; set; } = new Combo();
        public Hp hp { get; set; } = new Hp();
        public Grade grade { get; set; } = new Grade();
        public Hits hits { get; set; } = new Hits();
        public Ourplayer ourplayer { get; set; } = new Ourplayer();
        public Slot slot { get; set; } = new Slot();
        public Leaderboard leaderboard { get; set; } = new Leaderboard();*/
        public Root root { get; set; }
        public Gameplay gameplay { get; set; }
        public Menu menu { get; set; }
        public Time time { get; set; }

    }

    /*public class Menu
    {
        public enum MenuState
        {
            NotRunning = -1,
            MainMenu = 0,
            EditingMap = 1,
            Playing = 2,
            GameShutdownAnimation = 3,
            SongSelectEdit = 4,
            SongSelect = 5,
            WIP_NoIdeaWhatThisIs = 6,
            ResultsScreen = 7,
            GameStartupAnimation = 10,
            MultiplayerRooms = 11,
            MultiplayerRoom = 12,
            MultiplayerSongSelect = 13,
            MultiplayerResultsscreen = 14,
            OsuDirect = 15,
            RankingTagCoop = 17,
            RankingTeam = 18,
            ProcessingBeatmaps = 19,
            Tourney = 22,
        }

        public enum GameMode
        {
            Standard = 0,
            Taiko = 1,
            CTB = 2,
            Mania = 3,
            Unknown,
        }

        [DataModelProperty(Name = "Menu state")]
        public MenuState menuState { get; set; } 
        [DataModelProperty(Name = "Game mode")]
        public GameMode gameMode { get; set; }
        [DataModelProperty(Name = "Chatting")]
        public int isChatEnabled { get; set; }
        [DataModelProperty(Name = "Beatmap artist")]
        public string artist { get; set; }
        [DataModelProperty(Name = "Beatmap title")]
        public string title { get; set; }
        [DataModelProperty(Name = "Beatmap mapper")]
        public string mapper { get; set; }
        [DataModelProperty(Name = "Beatmap difficulty")]
        public string difficulty { get; set; }
        [DataModelProperty(Name = "Beatmap AR")]
        public float AR { get; set; }
        [DataModelProperty(Name = "Beatmap CS")]
        public float CS { get; set; }
        [DataModelProperty(Name = "Beatmap OD")]
        public float OD { get; set; }
        [DataModelProperty(Name = "Beatmap SR")]
        public float SR { get; set; }
        [DataModelProperty(Name = "Beatmap minimum BPM")]
        public float BPMmin { get; set; }
        [DataModelProperty(Name = "Beatmap maximum BPM")]
        public float BPMmax { get; set; }
        [DataModelProperty(Name = "Enabled mods")]
        public string mods { get; set; }
    }*/

    /*public class Gameplay
    {
        public enum GameMode
        {
            Standard = 0,
            Taiko = 1,
            CTB = 2,
            Mania = 3,
            Unknown,
        }

        [DataModelProperty(Name = "Game mode")]
        public GameMode gameMode { get; set; }
        [DataModelProperty(Name = "Score")]
        public int score { get; set; }
        [DataModelProperty(Name = "Accuracy")]
        public float accuracy { get; set; }
        [DataModelProperty(Name = "Maximum combo")]
        public int maxCombo { get; set; }
        [DataModelProperty(Name = "Current combo")]
        public int currCombo { get; set; }
        [DataModelProperty(Name = "HP")]
        public float hp { get; set; }
        [DataModelProperty(Name = "300 hits")]
        public int hits300 { get; set; }
        [DataModelProperty(Name = "200 hits")]
        public int hits200 { get; set; }
        [DataModelProperty(Name = "Geki hits")]
        public int hitsGeki { get; set; }
        [DataModelProperty(Name = "100 hits")]
        public int hits100 { get; set; }
        [DataModelProperty(Name = "Katu hits")]
        public int hitsKatu { get; set; }
        [DataModelProperty(Name = "50 hits")]
        public int hits50 { get; set; }
        [DataModelProperty(Name = "0 hits")]
        public int hits0 { get; set; }
        [DataModelProperty(Name = "Slider breaks")]
        public int sliderBreaks { get; set; }
        [DataModelProperty(Name = "Grade")]
        public string grade { get; set; }
        [DataModelProperty(Name = "Current PP")]
        public int ppCurrent { get; set; }
        [DataModelProperty(Name = "Maximum possible PP")]
        public int ppThisPlay { get; set; }
    }*/

    public class Time
    {
        [JsonProperty("firstObj")]
        public int firstObj { get; set; }
        [JsonProperty("current")]
        public int current { get; set; }
        [JsonProperty("full")]
        public int full { get; set; }
        [JsonProperty("mp3")]
        public int mp3 { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("artist")]
        public string artist { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("mapper")]
        public string mapper { get; set; }
        [JsonProperty("difficulty")]
        public string difficulty { get; set; }
    }

    public class BPM
    {
        [JsonProperty("min")]
        public int min { get; set; }
        [JsonProperty("max")]
        public int max { get; set; }
    }

    public class Stats
    {
        [JsonProperty("AR")]
        public double AR { get; set; }
        [JsonProperty("CS")]
        public double CS { get; set; }
        [JsonProperty("OD")]
        public double OD { get; set; }
        [JsonProperty("HP")]
        public double HP { get; set; }
        [JsonProperty("SR")]
        public double SR { get; set; }
        [JsonProperty("BPM")]
        public BPM BPM { get; set; }
        [JsonProperty("fullSR")]
        public double fullSR { get; set; }
        [JsonProperty("memoryAR")]
        public double memoryAR { get; set; }
        [JsonProperty("memoryCS")]
        public double memoryCS { get; set; }
        [JsonProperty("memoryOD")]
        public double memoryOD { get; set; }
        [JsonProperty("memoryHP")]
        public double memoryHP { get; set; }
    }

    public class Path
    {
        [JsonProperty("full")]
        public string full { get; set; }
        [JsonProperty("folder")]
        public string folder { get; set; }
        [JsonProperty("file")]
        public string file { get; set; }
        [JsonProperty("bg")]
        public string bg { get; set; }
        [JsonProperty("audio")]
        public string audio { get; set; }
    }

    public class Bm
    {
        [JsonProperty("time")]
        public Time time { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("set")]
        public int set { get; set; }
        [JsonProperty("md5")]
        public string md5 { get; set; }
        [JsonProperty("rankedStatus")]
        public int rankedStatus { get; set; }
        [JsonProperty("metadata")]
        public Metadata metadata { get; set; }
        [JsonProperty("stats")]
        public Stats stats { get; set; }
        [JsonProperty("path")]
        public Path path { get; set; }
    }

    public class Mods
    {
        [JsonProperty("num")]
        public int num { get; set; }
        [JsonProperty("str")]
        public string str { get; set; }
    }

    public class Pp
    {
        [JsonProperty("current")]
        public double current { get; set; }
        [JsonProperty("fc")]
        public double fc { get; set; }
        [JsonProperty("maxThisPlay")]
        public double maxThisPlay { get; set; }
    }

    public class Menu
    {
        [JsonProperty("state")]
        public int state { get; set; }
        [JsonProperty("skinFolder")]
        public string skinFolder { get; set; }
        [JsonProperty("gameMode")]
        public int gameMode { get; set; }
        [JsonProperty("isChatEnabled")]
        public int isChatEnabled { get; set; }
        [JsonProperty("bm")]
        public Bm bm { get; set; }
        [JsonProperty("mods")]
        public Mods mods { get; set; }
        [JsonProperty("pp")]
        public Pp pp { get; set; }
    }

    public class Combo
    {
        [JsonProperty("current")]
        public int current { get; set; }
        [JsonProperty("max")]
        public int max { get; set; }
    }

    public class Hp
    {
        [JsonProperty("normal")]
        public double normal { get; set; }
        [JsonProperty("smooth")]
        public double smooth { get; set; }
    }

    public class Grade
    {
        [JsonProperty("current")]
        public string current { get; set; }
        [JsonProperty("maxThisPlay")]
        public string maxThisPlay { get; set; }
    }

    public class Hits
    {
        [JsonProperty("300")]
        public int _300 { get; set; }
        [JsonProperty("200")]
        public int _200 { get; set; }
        [JsonProperty("geki")]
        public int geki { get; set; }
        [JsonProperty("100")]
        public int _100 { get; set; }
        [JsonProperty("katu")]
        public int katu { get; set; }
        [JsonProperty("50")]
        public int _50 { get; set; }
        [JsonProperty("0")]
        public int _0 { get; set; }
        [JsonProperty("sliderBreaks")]
        public int sliderBreaks { get; set; }
        [JsonProperty("grade")]
        public Grade grade { get; set; }
        [JsonProperty("unstableRate")]
        public double unstableRate { get; set; }
    }

    public class Ourplayer
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("score")]
        public int score { get; set; }
        [JsonProperty("combo")]
        public int combo { get; set; }
        [JsonProperty("maxCombo")]
        public int maxCombo { get; set; }
        [JsonProperty("mods")]
        public string mods { get; set; }
        [JsonProperty("h300")]
        public int h300 { get; set; }
        [JsonProperty("h100")]
        public int h100 { get; set; }
        [JsonProperty("h50")]
        public int h50 { get; set; }
        [JsonProperty("h0")]
        public int h0 { get; set; }
        [JsonProperty("team")]
        public int team { get; set; }
        [JsonProperty("position")]
        public int position { get; set; }
        [JsonProperty("isPassing")]
        public int isPassing { get; set; }
    }

    public class Slot
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("score")]
        public int score { get; set; }
        [JsonProperty("combo")]
        public int combo { get; set; }
        [JsonProperty("maxCombo")]
        public int maxCombo { get; set; }
        [JsonProperty("mods")]
        public string mods { get; set; }
        [JsonProperty("h300")]
        public int h300 { get; set; }
        [JsonProperty("h100")]
        public int h100 { get; set; }
        [JsonProperty("h50")]
        public int h50 { get; set; }
        [JsonProperty("h0")]
        public int h0 { get; set; }
        [JsonProperty("team")]
        public int team { get; set; }
        [JsonProperty("position")]
        public int position { get; set; }
        [JsonProperty("isPassing")]
        public int isPassing { get; set; }
    }

    public class Leaderboard
    {
        [JsonProperty("hasLeaderboard")]
        public bool hasLeaderboard { get; set; }
        [JsonProperty("ourplayer")]
        public Ourplayer ourplayer { get; set; }
        [JsonProperty("slots")]
        public List<Slot> slots { get; set; }
    }

    public class Gameplay
    {
        [JsonProperty("gameMode")]
        public int gameMode { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("score")]
        public int score { get; set; }
        [JsonProperty("accuracy")]
        public double accuracy { get; set; }
        [JsonProperty("combo")]
        public Combo combo { get; set; }
        [JsonProperty("hp")]
        public Hp hp { get; set; }
        [JsonProperty("hits")]
        public Hits hits { get; set; }
        [JsonProperty("pp")]
        public Pp pp { get; set; }
        [JsonProperty("leaderboard")]
        public Leaderboard leaderboard { get; set; }
    }

    public class Root
    {
        [JsonProperty("menu")]
        public Menu menu { get; set; }
        [JsonProperty("gameplay")]
        public Gameplay gameplay { get; set; }
    }
}