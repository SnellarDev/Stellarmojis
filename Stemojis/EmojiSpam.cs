using KiraiMod.WingAPI;
using MelonLoader;
using System.Collections;
using UnityEngine;
using VRC.SDKBase;
using System;

namespace Stemojis
{
    public class EmojiSpam : MelonMod
    {
        public override void OnApplicationStart()
        {
            WhereDaUI().Start();
            WingAPI.Initialize();
        }

        public override void OnUpdate()
        {
            try
            {
                Delay += Time.deltaTime;
                if (Delay > offset)
                {
                    switch (parsenum)
                    {
                        case "hearts":
                            EmojiRPC(52);
                            break;

                        case "thumbsup":
                            EmojiRPC(17);
                            break;

                        case "thumbsdown":
                            EmojiRPC(16);
                            break;

                        case "laugh":
                            EmojiRPC(9);
                            break;

                        case "kiss":
                            EmojiRPC(8);
                            break;

                        case "flame":
                            EmojiRPC(22);
                            break;

                        case "moneys":
                            EmojiRPC(45);
                            break;

                        case "tomato":
                            EmojiRPC(37);
                            break;

                        case "zzz":
                            EmojiRPC(56);
                            break;

                        case "snowfall":
                            EmojiRPC(23);
                            break;
                    }
                    Delay = 0f;
                }
            }
            catch { }
        }

        public static void EmojiRPC(int i)
        {
            try
            {
                Il2CppSystem.Int32 @int = default(Il2CppSystem.Int32);
                @int.m_value = i;
                Il2CppSystem.Object @object = @int.BoxIl2CppObject();
                Networking.RPC(0, VRCPlayer.field_Internal_Static_VRCPlayer_0.gameObject, "SpawnEmojiRPC", new Il2CppSystem.Object[]
                {
                    @object
                });
            }
            catch
            {
            }
        }

        public static IEnumerator WhereDaUI()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) yield return null;
            EmojiUI.EmojiGUI();
            yield break;
        }
        public static float offset = 2f;
        public static string parsenum;
        public static float Delay;
    }
}