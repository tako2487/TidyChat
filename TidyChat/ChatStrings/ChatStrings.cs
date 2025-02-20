﻿namespace TidyChat
{
    public static class ChatStrings
    {
        // You are now in the instanced area <zone> <instance>. Current instance can be confirmed at any time using the /instance text command.
        public static string[] InstancedArea { get; } = { "you", "are", "now", "in", "the", "instanced", "area" };

        // You received a player commendation!
        public static string[] PlayerCommendation { get; } = { "you", "received", "a", "player", "commendation" };

        // <duty> has ended
        public static string[] DutyEnded { get; } = { "has", "ended" };

        // The guildhest will end soon
        public static string[] GuildhestEnded { get; } = { "the", "guildhest", "will", "end", "soon" };
        // With the chat mode in Say, enter a phrase containing "Some Words"
        public static string[] SayQuestReminder { get; } = { "with", "the", "chat", "mode", "in" };

        // You sense the presence of a powerful mark...
        public static string[] PowerfulMark { get; } = { "you", "sense", "the", "presence", "of", "a", "powerful", "mark" };

        // The minions of an extraordinarily powerful mark...
        public static string[] ExtraordinarilyPowerfulMark { get; } = { "minions", "extraordinarily", "powerful", "mark" };

        // Retainer completed a venture.
        public static LocalizedStrings CompletedVenture { get; } = new()
        {
            Eng = new string[] { "completed", "a", "venture" },
            Jpn = new string[] { "冒険を終えました！" }
        };

        //You gain \d <class> experience points
        public static LocalizedStrings GainExperiencePoints { get; } = new()
        {
            Eng = new string[] { "you", "experience", "points" },
            Jpn = new string[] { "you", "ポイントの経験値" }
        };

        // A bonus of 1,200,000 experience points and 12,000 gil has been awards for using the duty roulette.
        public static LocalizedStrings RouletteBonus { get; } = new()
        {
            Eng = new string[] { "a", "bonus", "has", "been", "awarded", "for", "using", "the", "duty", "roulette" },
            Jpn = new string[] { "コンテンツルーレットのボーナスとして" }
        };
        // A bonus of 12,000 gil has been awared for being an adventurer in need.
        public static LocalizedStrings AdventurerInNeedBonus { get; } = new()
        {
            Eng = new string[] { "a", "bonus", "for", "being", "an", "adventurer", "in", "need" },
            Jpn = new string[] { "不足ロールボーナスとして" }
        };

        //You acquire \d Pvp EXP.
        public static string[] GainPvpExp { get; } = { "you", "acquire", "pvp", "exp" };
        // You cannot receive any more Wolf Marks. (Error Message)
        public static string[] ObtainWolfMarks { get; } = { "you", "obtain", "wolf", "marks" };
        // You cannot receive any more Wolf Marks. (Error Message)
        public static string[] CappedWolfMarks { get; } = { "you", "cannot", "receive", "any", "more", "wolf", "marks" };

        //You earn the achievement <achievement>
        public static string[] EarnAchievement { get; } = { "you", "the", "achievement" };

        // You synthesize a/an <item>
        public static LocalizedStrings YouSynthesize { get; } = new()
        {
            Eng = new string[] { "you", "synthesize" },
            Jpn = new string[] { "you", "を完成させた！" }
        };

        // <Player> has logged out.
        public static string[] HasLoggedOut { get; } = { "has", "logged", "out" };

        // You obtain Allagan Tomestones of <type>
        public static LocalizedStrings ObtainedTomestones { get; } = new()
        {
            Eng = new string[] { "You", "obtain", "Allagan", "tomestones", "of" },
            Jpn = new string[] { "アラガントームストーン", "手", "入", "た。"} // (?:手に入れ|入手し)た
        };

        // Ready Check
        public static string[] ReadyCheckComplete { get; } = { "ready", "check", "complete" };

        // You attain level <level>.
        public static LocalizedStrings YouAttainLevel { get; } = new()
        {
            Eng = new string[] { "you", "level" },
            Jpn = new string[] { "レベルアップ！", "you", "になった。" }
        };
        // <Player> attains level 33!
        public static LocalizedStrings OtherAttainsLevel { get; } = new()
        {
            Eng = new string[] { "attains", "level" },
            // BUG: this won't match abbreviated player names; need to be able to mix string and regexp
            Jpn = new string[] { "レベルアップ！", " ", "になった。" }
        };

        // You learn <ability>.
        public static string[] YouLearnAbility { get; } = { "you", "learn" };

        // Battle commencing in <time> seconds.
        public static LocalizedStrings CountdownTime { get; } = new()
        {
            Eng = new string[] { "battle", "commencing", "in", "seconds" },
            Jpn = new string[] { "戦闘開始まで", "秒" }
        };

        // Teleporting to <Location>...
        public static string[] DebugTeleport { get; } = { "teleporting", "to" };

        // You sense something...
        public static string[] SpideySenses { get; } = { "you", "sense", "something" };

        // The compass detects a current approximately <##> yalms to the <direction>...
        public static string[] AetherCompass { get; } = { "the", "compass", "detects", "a", "current", "approximately" };

        // Glamours projected from plate <##>
        public static LocalizedStrings GlamoursProjected { get; } = new()
        {
            Eng = new string[] { "glamours", "projected", "from", "plate" },
            Jpn = new string[] { "ミラージュプレート", "により武具投影が行われました。" }
        };
        // Overmelding fail
        // You are unable to attach the materia to the <item>. The <materia> was lost.
        public static string[] OvermeldFailure { get; } = { "you", "unable", "to", "attach", "the", "materia", "to" };
        // You succesfully extra a <materia> from the <item>
        public static string[] MateriaExtract { get; } = { "you", "successfully", "a", "from", "the" };
        // The location affects your...
        public static string[] LocationAffects { get; } = { "the", "location", "affects", "your" };
        // ...gathering yield.
        public static string[] GatheringYield { get; } = { "gathering", "yield" };
        // ...chance of receiving the Gatherer's boon.
        public static string[] GatherersBoon { get; } = { "chance", "of", "receiving", "the", "gatherer's", "boon" };
        public static string[] GatheringAttempts { get; } = { "increased", "integrity", "number", "of", "gathering", "attempts" };
        // Trade complete.
        public static string[] TradeComplete { get; } = { "trade", "complete" };
        // Trade canceled.
        public static string[] TradeCanceled { get; } = { "trade", "canceled" };
        // Trade request sent to <player>
        public static string[] TradeSent { get; } = { "trade", "request", "sent", "to" };
        public static string[] AwaitingTradeConfirmation { get; } = { "awaiting", "trade", "confirmation", "from" };
        // You invite <player> to a party.
        public static string[] InviteSent { get; } = { "you", "invite", "to", "a", "party" };
        // <Player> joins the party.
        public static string[] InviteeJoins { get; } = { "joins", "the", "party" };
        // The party has been disbanded.
        public static string[] PartyDisband { get; } = { "the", "party", "has", "been", "disbanded" };
        // You dissolve the party.
        public static string[] PartyDissolved { get; } = { "dissolve", "party"  };
        // <Player> invites you to a party.
        public static string[] InvitedBy { get; } = { "invites", "you", "to", "a", "party" };
        // You join <Player>'s party.
        public static string[] JoinParty { get; } = { "you", "join", "party" };
        // You leave <Player>'s party.
        public static string[] YouLeaveParty { get; } = { "you", "leave", "party" };
        // Cross-world party joined
        public static string[] JoinCrossParty { get; } = { "cross-world", "party", "joined" };
        // <Player> has left the party.
        public static string[] LeftParty { get; } = { "has", "left", "the", "party" };
        // You have been offered a teleport to <Aetheryte> from <Player>.
        public static string[] OfferedTeleport { get; } = { "you", "have", "been", "offered", "a", "teleport", "to", "from" };
        // Record of <boss> kill (n/m) added for <Relic Weapon> - <Stats>.1
        public static string[] RelicBookStep { get; } = { "record", "of", "added", "for" };
        // All objectives under the category <Category> - <buff> complete!
        public static string[] RelicBookComplete { get; } = { "all", "objectives", "under", "the", "category", "complete" };
        // Palace of the Dead Floors (x-y) has begun
        public static string[] PalaceOfTheDead { get; } = { "Palace", "Dead", "begun" };
        // Heaven-on-High Floors (x-y) has begun
        public static string[] HeavenOnHigh { get; } = { "Heaven-on-High", "begun" };
        // Total Play time: 249 days, 12 hours, 30 minutes
        public static string[] Playtime { get; } = { "total", "play", "time" };
    }
}
