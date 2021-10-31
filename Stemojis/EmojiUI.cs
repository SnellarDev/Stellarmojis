using RubyButtonAPI;
using UnityEngine;
using MelonLoader;

namespace Stemojis
{
    internal class EmojiUI
    {
        public static void EmojiGUI()
        {
            MainNest = new QMNestedButton("ShortcutMenu", 5, 2, "Emoji\nSpam", "Select which emojis you want to spam", Color.cyan, Color.cyan, null, null);
            Hearts = new QMToggleButton(MainNest, 1, 0, "Hearts", delegate
            {
                EmojiSpam.parsenum = "hearts";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            thumbsup = new QMToggleButton(MainNest, 2, 0, "Thumbs Up", delegate
            {
                EmojiSpam.parsenum = "thumbsup";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            thumbsdown = new QMToggleButton(MainNest, 3, 0, "Thumbs Down", delegate
            {
                EmojiSpam.parsenum = "thumbsdown";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            laugh = new QMToggleButton(MainNest, 4, 0, "Laugh", delegate
            {
                EmojiSpam.parsenum = "laugh";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            kiss = new QMToggleButton(MainNest, 1, 1, "Kiss", delegate
            {
                EmojiSpam.parsenum = "kiss";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            flame = new QMToggleButton(MainNest, 2, 1, "Flame", delegate
            {
                EmojiSpam.parsenum = "flame";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            moneys = new QMToggleButton(MainNest, 3, 1, "Money", delegate
            {
                EmojiSpam.parsenum = "moneys";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            tomato = new QMToggleButton(MainNest, 4, 1, "Tomatos", delegate
            {
                EmojiSpam.parsenum = "tomato";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            ZZZ = new QMToggleButton(MainNest, 1, 2, "Zzz", delegate
            {
                EmojiSpam.parsenum = "zzz";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            Snow = new QMToggleButton(MainNest, 2, 2, "Snowfall", delegate
            {
                EmojiSpam.parsenum = "snowfall";
            }, "OFF", delegate
            {
                EmojiSpam.parsenum = string.Empty;
            }, "Spams the specified emoji", Color.cyan, Color.cyan, false, false);
            increment = new QMSingleButton(MainNest, 3, 2, "Delay +1", delegate
            {
                EmojiSpam.offset++;
            }, "Sets the delay of spamming the emojis to go up by 1 second on each press", Color.cyan, Color.cyan);
            decrement = new QMSingleButton(MainNest, 4, 2, "Delay -1", delegate
            {
                if(EmojiSpam.offset < 3)
                {
                    MelonLogger.Msg("The current delay is 2, you cannot go lower than this delay.");
                }
                else
                {
                    EmojiSpam.offset--;
                }
            }, "Sets the delay of spamming the emojis to go down by 1 second on each press", Color.cyan, Color.cyan);
        }

        internal static QMNestedButton MainNest;
        internal static QMToggleButton Hearts;
        internal static QMToggleButton Snow;
        internal static QMToggleButton ZZZ;
        internal static QMToggleButton laugh;
        internal static QMToggleButton flame;
        internal static QMToggleButton kiss;
        internal static QMToggleButton moneys;
        internal static QMToggleButton tomato;
        internal static QMToggleButton thumbsup;
        internal static QMToggleButton thumbsdown;
        internal static QMSingleButton increment;
        internal static QMSingleButton decrement;
    }
}