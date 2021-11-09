using KiraiMod.WingAPI;
using KiraiMod.WingAPI.RawUI;
using UnityEngine;
using MelonLoader;
using System;

namespace Stemojis
{
    internal class EmojiUI
    {
        public static void EmojiGUI()
        {
            try
            {
                WingAPI.OnWingInit += new System.Action<Wing.BaseWing>(wing =>
                {
                    WingPage page = wing.CreatePage("Emojis");
                    WingToggle toggle = page.CreateToggle("Hearts", 0, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "hearts"));
                    WingToggle toggle2 = page.CreateToggle("ThumbsUp", 1, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "thumbsup"));
                    WingToggle toggle3 = page.CreateToggle("ThumbsDown", 2, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "thumbsdown"));
                    WingToggle toggle4 = page.CreateToggle("Laugh", 3, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "laugh"));
                    WingToggle toggle5 = page.CreateToggle("Kiss", 4, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "kiss"));
                    WingToggle toggle6 = page.CreateToggle("Flame", 5, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "flame"));
                    WingPage nest = page.CreateNestedPage("Emoji Page 2", 6);
                    WingToggle toggle7 = nest.CreateToggle("Money", 0, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "moneys"));
                    WingToggle toggle8 = nest.CreateToggle("Tomato", 1, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "tomato"));
                    WingToggle toggle9 = nest.CreateToggle("Zzz", 2, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "zzz"));
                    WingToggle toggle10 = nest.CreateToggle("Snowfall", 3, UnityEngine.Color.green, UnityEngine.Color.red, false, new Action<bool>(state => EmojiSpam.parsenum = (state == false) ? null : "snowfall"));
                });
            }
            catch (Exception ex)
            {
                MelonLogger.Msg(ex);
            }
        }
    }
}