using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample01
{
    internal class Player
    {
        public string PlayerName;
        public string PlayerClass;
        public int PlayerHp;
        public int PlayerMp;
        public List<String> PlayerItem = new List<string>();

        public Player(string name = "名無し")
        {
            PlayerName = name;
            PlayerClass = "すっぴん";
        }

        public void SelectClass()
        {
            Console.WriteLine("こんにちは、" + PlayerName + "さん。" + "あなたの職業はすっぴんです。");
            Console.WriteLine("あなたの職業を選んでください。");
            Console.WriteLine("1.剣士");
            Console.WriteLine("2.魔法使い");
            string num = Console.ReadLine();

            if (num == "1")
            {
                PlayerClass = "剣士";
                PlayerHp = 50;
                PlayerMp = 10;
                Console.WriteLine("剣士ですね！　HPや攻撃力の高い前衛向きの職業です。頑張ってくださいね！");
            }
            else
            {
                PlayerHp = 20;
                PlayerMp = 40;
                PlayerClass = "魔法使い";
                Console.WriteLine("魔法使いですね！　MPや魔力の高い後衛向きの職業です。頑張ってくださいね！");
            }
        }
        public string GetPlayerStatus()
        {
            return
$@"=== プレイヤーステータス ===
名前：{PlayerName}
職業：{PlayerClass}
HP ：{PlayerHp}
MP ：{PlayerMp}
==========================";

        }

        public void AddItem(string Item)
        {
            PlayerItem.Add(Item);
            Console.WriteLine($"{PlayerName}は{Item}を手に入れた！");
        }

        public void GetPlayerItem()
        {
            Console.WriteLine("======= 持ち物一覧 =======");

            if(PlayerItem.Count == 0)
            {
                Console.WriteLine("なし");
            }
            {
                for (int i = 0; i < PlayerItem.Count; i++)
                {
                    Console.WriteLine(PlayerItem[i]);
                }
            }

            Console.WriteLine("==========================");

        }

    }
}
