
using sample01;


Console.WriteLine("名前を入力してください。");
string name = Console.ReadLine();

Player player = new Player(name);

player.SelectClass();

Console.WriteLine(player.GetPlayerStatus());
player.GetPlayerItem();
