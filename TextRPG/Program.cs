using Aspose.Cells.Drawing;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace TextRPG
{

    internal class Program
    {
        private static Character player;
        private static Item[] item = new Item[10];
        private static Shop[] shop = new Shop[10];
        static int item_count = 0;
        static int shop_count = 0;


        static void Main(string[] args)
        {
            GameStart();
            GameDataSetting();
            DisplayGameIntro();
        }

        static void GameStart()
        {
            Console.WriteLine(" ________                      __            _______   _______    ______  ");
            Console.WriteLine("|        \\                    |  \\          |       \\ |       \\  /      \\ ");
            Console.WriteLine(" \\$$$$$$$$______   __    __  _| $$_         | $$$$$$$\\| $$$$$$$\\|  $$$$$$\\");
            Console.WriteLine("   | $$  /      \\ |  \\  /  \\|   $$ \\        | $$__| $$| $$__/ $$| $$ __\\$$");
            Console.WriteLine("   | $$ |  $$$$$$\\ \\$$\\/  $$ \\$$$$$$        | $$    $$| $$    $$| $$|    \\");
            Console.WriteLine("   | $$ | $$    $$  >$$  $$   | $$ __       | $$$$$$$\\| $$$$$$$ | $$ \\$$$$");
            Console.WriteLine("   | $$ | $$$$$$$$ /  $$$$\\   | $$|  \\      | $$  | $$| $$      | $$__| $$");
            Console.WriteLine("   | $$  \\$$     \\|  $$ \\$$\\   \\$$  $$      | $$  | $$| $$       \\$$    $$");
            Console.WriteLine("    \\$$   \\$$$$$$$ \\$$   \\$$    \\$$$$        \\$$   \\$$ \\$$        \\$$$$$$ ");
            Console.WriteLine();
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          아무키나 누르면 시작합니다.                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.ReadKey();
        }

        static void GameDataSetting()
        {
            // 캐릭터 정보 세팅
            player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

            // 아이템 정보 세팅
            item[0] = new Item("무쇠 갑옷","", "방어력", 5, "무쇠로 만들어져 튼튼한 갑옷입니다.", false, 1800);
            item_count++;
            item[1] = new Item("낡은 검", "" , "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", false, 600);
            item_count++;

            // 상점 아이템 정보 세팅
            shop[0] = new Shop("수련자의 갑옷", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000, false, "");
            shop_count++;
            shop[1] = new Shop("무쇠 갑옷", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1800, true, "");
            shop_count++;
            shop[2] = new Shop("스파르타 갑옷", "방어력", 15, "스파르타 전사들이 사용했다는 전설의 갑옷입니다.", 3500, false, "");
            shop_count++;
            shop[3] = new Shop("낡은 검", "공격력", 2, "쉽게 볼 수 있는 낡은 검입니다.", 600, true, "");
            shop_count++;
            shop[4] = new Shop("청동 도끼", "공격력", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500, false, "");
            shop_count++;
            shop[5] = new Shop("스파르타 창", "공격력", 7, "스파르타 전사들이 사용했다는 전설의 창입니다..", 3000, false, "");
            shop_count++;
            shop[6] = new Shop("나뭇가지(?)", "공격력", 1, "평범하게 보이는 나뭇가지(뭔가 비밀이 숨겨져 있을지도?)", 5000, false, "");
            shop_count++;
        }
        static void DisplayGameIntro()
        {
            Console.Clear();
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("|                                                                                 |");
            Console.WriteLine("|                  스파르타 마을에 오신 여러분 환영합니다.                        |");
            Console.WriteLine("|                                                                                 |");
            Console.WriteLine("|          이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.                   |");
            Console.WriteLine("|                                                                                 |");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");

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

            FontColorChange(" ■ 상태보기 ■ ");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            FontColorDetail("Lv. ", player.Level.ToString("00"));
            Console.WriteLine("{0} ( {1} )", player.Name, player.Job);
            Console.WriteLine();

            int Atk_sum = 0;
            int Def_sum = 0;

            for (int i = 0; i < item_count; i++)
            {
                if (item[i].Equips == true && item[i].Stat == "공격력")
                    Atk_sum += item[i].Add_stat;
                else if (item[i].Equips == true && item[i].Stat == "방어력")
                    Def_sum += item[i].Add_stat;
            }
            FontColorDetail("공격력 : ", (player.Atk + Atk_sum).ToString(), string.Format($" ( +{Atk_sum} )"));
            FontColorDetail("방어력 : ", (player.Def + Def_sum).ToString(), string.Format($" ( +{Def_sum} )"));
            FontColorDetail("체력 : ", player.Hp.ToString());
            FontColorDetail("Gold : ", player.Gold.ToString());
            Console.WriteLine("0. 나가기");
            Console.Write(">> ");

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
            FontColorChange(" ■ 인벤토리 ■ ");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            for (int i = 0; i < item_count; i++)
            {
                Console.WriteLine($"- {item[i].Name}, {item[i].Stat} +{item[i].Add_stat}, {item[i].Ex}");
                Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            }
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");


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

            FontColorChange(" ■ 인벤토리 - 장착관리 ■ ");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            for (int i = 0; i < item_count; i++)
            {
                Console.WriteLine($"- {i+1} {item[i].Display_Equips} {item[i].Name}, {item[i].Stat} +{item[i].Add_stat}, {item[i].Ex}");
                Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            }
            Console.WriteLine();
            Console.WriteLine("번호 입력 - 장비 장착/해제");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");

            int input = CheckValidInput(0, item_count);
            switch (input)
            {
                case 0:
                    DisplayInventory();
                    break;
                default:
                    if (item[input - 1].Equips == false)
                    {
                        item[input - 1].Display_Equips = "[E]";
                        item[input - 1].Equips = true;
                        DisplayEquipManager();
                    }
                    else if (item[input - 1].Equips == true)
                    {
                        item[input - 1].Display_Equips = null;
                        item[input - 1].Equips = false;
                        DisplayEquipManager();
                    }
                    break;
            }
        }

        static void DisplayShop()
        {
            Console.Clear();

            FontColorChange(" ■ 상점 ■ ");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[ 보유 골드 ]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            for (int i = 0; i < shop_count; i++)
            {
                Console.WriteLine($"- {shop[i].Name}    {shop[i].Stat} +{shop[i].Add_stat}    {shop[i].Ex}    {shop[i].Price}");
                Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            }
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");

            int input = CheckValidInput(0, 2);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    ShopBuyManager();
                    break;
                case 2:
                    ShopCellManager();
                    break;
            }
        }

        static void ShopBuyManager()
        {
            Console.Clear();
            for(int i = 0; i < shop_count; i++)
            {
                if (shop[i].Display_buy == true)
                {
                    shop[i].Buy_comple = "구매완료";
                }
            }
            FontColorChange(" ■ 상점 - 아이템 구매 ■ ");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[ 보유 골드 ]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            for (int i = 0; i < shop_count; i++)
            {
                Console.WriteLine($"- {i + 1}  {shop[i].Name}    {shop[i].Stat} +{shop[i].Add_stat}    {shop[i].Ex}    {shop[i].Price}      {shop[i].Buy_comple}");
                Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            }
            Console.WriteLine();
            Console.WriteLine("구매할 아이템 번호 입력,  나가기 : 0 ");
            Console.Write(">> ");
            int input = CheckValidInput(0, shop_count);
            switch (input)
            {
                case 0:
                    DisplayShop();
                    break;
                default:
                    int shop_select = input-1;
                    if (shop[shop_select].Display_buy == true)
                    {
                        Console.WriteLine("이미 구매를 완료한 아이템입니다.");
                    }
                    else if (player.Gold >= shop[shop_select].Price)
                    {
                        player.Gold -= shop[shop_select].Price;
                        Console.WriteLine("{0}을 구매하셨습니다. 현재 소지금 : {1}", shop[shop_select].Name, player.Gold);
                        shop[shop_select].Display_buy = true;
                        item[item_count] = new Item(shop[shop_select].Name, "", shop[shop_select].Stat, shop[shop_select].Add_stat, shop[shop_select].Ex, false, shop[shop_select].Price);
                        item_count++;
                    }
                    else if (player.Gold < shop[shop_select].Price)
                    {
                        Console.WriteLine("소지금이 부족합니다.");
                    }
                    else
                        Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadKey();
                    ShopBuyManager();
                    break;
            }
        }

        static void ShopCellManager()
        {
            Console.Clear();

            FontColorChange(" ■ 상점 - 아이템 판매 ■ ");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine("판매 가격은 원가에 85%입니다.");
            Console.WriteLine();
            Console.WriteLine("[ 보유 골드 ]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            for (int i = 0; i < item_count; i++)
            {
                Console.WriteLine($"- {i+1} {item[i].Name}, {item[i].Stat} +{item[i].Add_stat}, {item[i].Price}G");
                Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            }
            Console.WriteLine();
            Console.WriteLine("판매할 아이템 번호 입력, 나가기 : 0 ");
            Console.Write(">> ");
            int input = CheckValidInput(0, item_count);
            switch (input)
            {
                case 0:
                    DisplayShop();
                    break;
                default:
                    int itemCell = input - 1;

                    for (int i = 0; i < shop_count; i++)
                    {
                        if (shop[i].Name == item[itemCell].Name)
                        {
                            shop[i].Display_buy = false;
                            shop[i].Buy_comple = "";
                            player.Gold = player.Gold + item[itemCell].Price * 85 / 100;
                            item_count--;
                        }
                    }
                    Console.WriteLine("{0}을 판매했습니다. 판매 가격은 : {1} 현재 소지금 {2}", item[itemCell].Name, item[itemCell].Price * 85 / 100 ,player.Gold);
                    Console.ReadKey();
                    ShopCellManager();
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

        private static void FontColorChange(string grn)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(grn);
            Console.ResetColor();
        }

        private static void FontColorDetail(string s1, string s2, string s3 = "")
        {
            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(s2);
            Console.ResetColor();
            Console.WriteLine(s3);
        }
    }
}