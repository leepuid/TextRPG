using Aspose.Cells.Drawing;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace TextRPG
{

    internal class Program
    {
        private static Character player;
        private static Inventory[] item = new Inventory[10];
        private static Shop[] shop = new Shop[10];
        static int item_count = 0;
        static int shop_count = 0;
        static bool[] equip_check = new bool[10];
        static string[] display_eq = new string[10];


        static void Main(string[] args)
        {
            GameDataSetting();
            DisplayGameIntro();
        }

        static void GameDataSetting()
        {
            // 캐릭터 정보 세팅
            player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

            // 아이템 정보 세팅
            item[0] = new Inventory("무쇠갑옷", "방어력", 5, "무쇠로 만들어져 튼튼한 갑옷입니다.");
            item_count++;
            item[1] = new Inventory("낡은 검", "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.");
            item_count++;

            // 상점 아이템 정보 세팅
            shop[0] = new Shop("수련자의 갑옷", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000);
            shop_count++;
            shop[1] = new Shop("무쇠 갑옷", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1800);
            shop_count++;
            shop[2] = new Shop("스파르타 갑옷", "방어력", 15, "스파르타 전사들이 사용했다는 전설의 갑옷입니다.", 3500);
            shop_count++;
            shop[3] = new Shop("낡은 검", "공격력", 2, "쉽게 볼 수 있는 낡은 검입니다.", 600);
            shop_count++;
            shop[4] = new Shop("청동 도끼", "공격력", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500);
            shop_count++;
            shop[5] = new Shop("스파르타 창", "공격력", 7, "스파르타 전사들이 사용했다는 전설의 창입니다..", 3000);
            shop_count++;
        }
        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1, 3);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();    
                    break;
                case 2:
                    // 작업해보기
                    DisplayInventory();
                    break;
                case 3:
                    DisplayShop();
                    break;
            }
        }

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보르 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");

            int Atk_sum = 0;
            int Def_sum = 0;

            for (int i = 0; i < item_count; i++)
            {
                if (equip_check[i] == true && item[i].Stat == "공격력")
                    Atk_sum += item[i].Add_stat;
                else if (equip_check[i] == true && item[i].Stat == "방어력")
                    Def_sum += item[i].Add_stat;
            }
            Console.WriteLine($"공격력 :{player.Atk}   (+{Atk_sum})");
            Console.WriteLine($"방어력 : {player.Def}  (+{Def_sum})");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for(int i = 0; i < item_count; i++)
            {
                Console.WriteLine($"- {item[i].Name}, {item[i].Stat} +{item[i].Add_stat}, {item[i].Ex}");
            }
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");


            int input = CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    // 장착 관리 만들기
                    DisplayEquipManager();
                    break;
            }
        }

        static void DisplayEquipManager()
        {
            Console.Clear();

            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < item_count; i++)
            {
                Console.WriteLine($"- {i+1} {display_eq[i]} {item[i].Name}, {item[i].Stat} +{item[i].Add_stat}, {item[i].Ex}");
            }
            Console.WriteLine();
            Console.WriteLine("번호 입력 - 장비 장착/해제");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(0, item_count);
            switch (input)
            {
                case 0:
                    DisplayInventory();
                    break;
                default:
                    if (equip_check[input - 1] == false)
                    {
                        display_eq[input - 1] = "[E]";
                        equip_check[input - 1] = true;
                        DisplayEquipManager();
                    }
                    else if (equip_check[input - 1] == true)
                    {
                        display_eq[input - 1] = null;
                        equip_check[input - 1] = false;
                        DisplayEquipManager();
                    }
                    break;
            }
        }

        static void DisplayShop()
        {
            Console.Clear();

            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine();
            for (int i = 0; i < shop_count; i++)
            {
                Console.WriteLine($"- {i+1}  {shop[i].Name}    {shop[i].Stat} +{shop[i].Add_stat}    {shop[i].Ex}    {shop[i].Price}");
            }
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    Console.Write("구매할 아이템 번호를 입력해주세요(1 ~ {0}) : ", shop_count);
                    int shop_select = int.Parse(Console.ReadLine());
                    if (player.Gold < shop[shop_select+1].Price)
                    {
                        int buy = player.Gold - shop[shop_select].Price;
                        Console.WriteLine("{0}을 구매하셨습니다. 현재 소지금 : {1}", shop[shop_select].Name, buy);
                        player.Gold = buy;
                    }
                    else if (player.Gold > shop[shop_select].Price)
                    {
                        Console.WriteLine("소지금이 부족합니다.");
                        DisplayShop();
                    }
                    break;
            }
        }


        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }



    //public class Item
    //{
    //    public string Name { get; }
    //    public string Effect { get; }
    //    public string Ex { get; }

    //    public Item(string name, string effect, int add_stat, string ex)
    //    {
    //        Name = name;    // 아이템 이름
    //        Effect = effect;    // 아이템 효과
    //        Ex = ex;    // 아이템 효과 설명
    //    }
    //}
}