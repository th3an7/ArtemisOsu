using Newtonsoft.Json;
using System.Collections.Generic;

namespace ArtemisOsu
{
    public class Folders
    {
        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("skin")]
        public string Skin { get; set; }

        [JsonProperty("songs")]
        public string Songs { get; set; }
    }

    public class Settings
    {
        [JsonProperty("showInterface")]
        public bool ShowInterface { get; set; }

        [JsonProperty("folders")]
        public Folders Folders { get; set; }
    }

    public class MainMenu
    {
        [JsonProperty("bassDensity")]
        public double BassDensity { get; set; }
    }

    public class Time
    {
        [JsonProperty("firstObj")]
        public int FirstObj { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("full")]
        public int Full { get; set; }

        [JsonProperty("mp3")]
        public int Mp3 { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("mapper")]
        public string Mapper { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
    }

    public class BPM
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class Stats
    {
        [JsonProperty("AR")]
        public int AR { get; set; }

        [JsonProperty("CS")]
        public int CS { get; set; }

        [JsonProperty("OD")]
        public int OD { get; set; }

        [JsonProperty("HP")]
        public int HP { get; set; }

        [JsonProperty("SR")]
        public double SR { get; set; }

        [JsonProperty("BPM")]
        public BPM BPM { get; set; }

        [JsonProperty("maxCombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("fullSR")]
        public double FullSR { get; set; }

        [JsonProperty("memoryAR")]
        public int MemoryAR { get; set; }

        [JsonProperty("memoryCS")]
        public int MemoryCS { get; set; }

        [JsonProperty("memoryOD")]
        public int MemoryOD { get; set; }

        [JsonProperty("memoryHP")]
        public double MemoryHP { get; set; }
    }

    public class Path
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("bg")]
        public string Bg { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }
    }

    public class Bm
    {
        [JsonProperty("time")]
        public Time Time { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("set")]
        public int Set { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("rankedStatus")]
        public int RankedStatus { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("path")]
        public Path Path { get; set; }
    }

    public class Mods
    {
        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("str")]
        public string Str { get; set; }
    }

    public class Pp
    {
        [JsonProperty("100")]
        public int _100 { get; set; }

        [JsonProperty("99")]
        public int _99 { get; set; }

        [JsonProperty("98")]
        public int _98 { get; set; }

        [JsonProperty("97")]
        public int _97 { get; set; }

        [JsonProperty("96")]
        public int _96 { get; set; }

        [JsonProperty("95")]
        public int _95 { get; set; }

        [JsonProperty("strains")]
        public List<int> Strains { get; } = new List<int>();

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("fc")]
        public int Fc { get; set; }

        [JsonProperty("maxThisPlay")]
        public int MaxThisPlay { get; set; }
    }

    public class Menu
    {
        [JsonProperty("mainMenu")]
        public MainMenu MainMenu { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("gameMode")]
        public int GameMode { get; set; }

        [JsonProperty("isChatEnabled")]
        public int IsChatEnabled { get; set; }

        [JsonProperty("bm")]
        public Bm Bm { get; set; }

        [JsonProperty("mods")]
        public Mods Mods { get; set; }

        [JsonProperty("pp")]
        public Pp Pp { get; set; }
    }

    public class Combo
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class Hp
    {
        [JsonProperty("normal")]
        public int Normal { get; set; }

        [JsonProperty("smooth")]
        public double Smooth { get; set; }
    }

    public class Grade
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("maxThisPlay")]
        public string MaxThisPlay { get; set; }
    }

    public class Hits
    {
        [JsonProperty("300")]
        public int _300 { get; set; }

        [JsonProperty("geki")]
        public int Geki { get; set; }

        [JsonProperty("100")]
        public int _100 { get; set; }

        [JsonProperty("katu")]
        public int Katu { get; set; }

        [JsonProperty("50")]
        public int _50 { get; set; }

        [JsonProperty("0")]
        public int _0 { get; set; }

        [JsonProperty("sliderBreaks")]
        public int SliderBreaks { get; set; }

        [JsonProperty("grade")]
        public Grade Grade { get; set; }

        [JsonProperty("unstableRate")]
        public double UnstableRate { get; set; }

        [JsonProperty("hitErrorArray")]
        public List<int> HitErrorArray { get; } = new List<int>();
    }

    public class K1
    {
        [JsonProperty("isPressed")]
        public bool IsPressed { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class K2
    {
        [JsonProperty("isPressed")]
        public bool IsPressed { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class M1
    {
        [JsonProperty("isPressed")]
        public bool IsPressed { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class M2
    {
        [JsonProperty("isPressed")]
        public bool IsPressed { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class KeyOverlay
    {
        [JsonProperty("k1")]
        public K1 K1 { get; set; }

        [JsonProperty("k2")]
        public K2 K2 { get; set; }

        [JsonProperty("m1")]
        public M1 M1 { get; set; }

        [JsonProperty("m2")]
        public M2 M2 { get; set; }
    }

    public class Ourplayer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("combo")]
        public int Combo { get; set; }

        [JsonProperty("maxCombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("mods")]
        public string Mods { get; set; }

        [JsonProperty("h300")]
        public int H300 { get; set; }

        [JsonProperty("h100")]
        public int H100 { get; set; }

        [JsonProperty("h50")]
        public int H50 { get; set; }

        [JsonProperty("h0")]
        public int H0 { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("isPassing")]
        public int IsPassing { get; set; }
    }

    public class Slot
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("combo")]
        public int Combo { get; set; }

        [JsonProperty("maxCombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("mods")]
        public string Mods { get; set; }

        [JsonProperty("h300")]
        public int H300 { get; set; }

        [JsonProperty("h100")]
        public int H100 { get; set; }

        [JsonProperty("h50")]
        public int H50 { get; set; }

        [JsonProperty("h0")]
        public int H0 { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("isPassing")]
        public int IsPassing { get; set; }
    }

    public class Leaderboard
    {
        [JsonProperty("hasLeaderboard")]
        public bool HasLeaderboard { get; set; }

        [JsonProperty("isVisible")]
        public bool IsVisible { get; set; }

        [JsonProperty("ourplayer")]
        public Ourplayer Ourplayer { get; set; }

        [JsonProperty("slots")]
        public List<Slot> Slots { get; } = new List<Slot>();
    }

    public class Gameplay
    {
        [JsonProperty("gameMode")]
        public int GameMode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("combo")]
        public Combo Combo { get; set; }

        [JsonProperty("hp")]
        public Hp Hp { get; set; }

        [JsonProperty("hits")]
        public Hits Hits { get; set; }

        [JsonProperty("pp")]
        public Pp Pp { get; set; }

        [JsonProperty("keyOverlay")]
        public KeyOverlay KeyOverlay { get; set; }

        [JsonProperty("leaderboard")]
        public Leaderboard Leaderboard { get; set; }
    }

    public class ResultsScreen
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("maxCombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("mods")]
        public Mods Mods { get; set; }

        [JsonProperty("300")]
        public int _300 { get; set; }

        [JsonProperty("geki")]
        public int Geki { get; set; }

        [JsonProperty("100")]
        public int _100 { get; set; }

        [JsonProperty("katu")]
        public int Katu { get; set; }

        [JsonProperty("50")]
        public int _50 { get; set; }

        [JsonProperty("0")]
        public int _0 { get; set; }
    }

    public class TeamName
    {
        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("right")]
        public string Right { get; set; }
    }

    public class Stars
    {
        [JsonProperty("left")]
        public int Left { get; set; }

        [JsonProperty("right")]
        public int Right { get; set; }
    }

    public class Bools
    {
        [JsonProperty("scoreVisible")]
        public bool ScoreVisible { get; set; }

        [JsonProperty("starsVisible")]
        public bool StarsVisible { get; set; }
    }

    public class Score
    {
        [JsonProperty("left")]
        public int Left { get; set; }

        [JsonProperty("right")]
        public int Right { get; set; }
    }

    public class Manager
    {
        [JsonProperty("ipcState")]
        public int IpcState { get; set; }

        [JsonProperty("bestOF")]
        public int BestOF { get; set; }

        [JsonProperty("teamName")]
        public TeamName TeamName { get; set; }

        [JsonProperty("stars")]
        public Stars Stars { get; set; }

        [JsonProperty("bools")]
        public Bools Bools { get; set; }

        [JsonProperty("chat")]
        public object Chat { get; set; }

        [JsonProperty("gameplay")]
        public Gameplay Gameplay { get; set; }
    }

    public class Tourney
    {
        [JsonProperty("manager")]
        public Manager Manager { get; set; }

        [JsonProperty("ipcClients")]
        public object IpcClients { get; set; }
    }

    public class GosuMemoryRoot
    {
        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("menu")]
        public Menu Menu { get; set; }

        [JsonProperty("gameplay")]
        public Gameplay Gameplay { get; set; }

        [JsonProperty("resultsScreen")]
        public ResultsScreen ResultsScreen { get; set; }

        [JsonProperty("tourney")]
        public Tourney Tourney { get; set; }
    }
}
