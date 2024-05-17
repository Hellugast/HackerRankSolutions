using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class HackerRankLegacy
    {
        //// See https://aka.ms/new-console-template for more information

        //Console.WriteLine("Hello, World!");

        //List<List<int>> list = new List<List<int>>() { new() { 3 }, new() { 11, 2, 4 }, new() { 4, 5, 6 }, new() { 10, 8, -12 } };

        //int determinantbul(List<List<int>> list)
        //{

        //    int leftDiagonal = 0;
        //    int rightDiagonal = 0;

        //    var size = list.ElementAt(0).ElementAt(0);

        //    int j = size - 1;

        //    for (int i = 0; i < size; i++)
        //    {
        //        leftDiagonal += list.ElementAt(i + 1).ElementAt(i);
        //        rightDiagonal += list.ElementAt(i + 1).ElementAt(j);
        //        j--;
        //    }
        //    Console.WriteLine(Math.Abs(leftDiagonal - rightDiagonal));
        //    return 0;
        //}

        //determinantbul(list);


        //void denemeFonk()
        //{

        //    Dictionary<string, string> usersList = new Dictionary<string, string>();

        //    usersList.Add("batu", "asddsa");
        //    usersList.Add("uur", "");

        //    Console.WriteLine("Kullanıcı adı ve şifre gir");
        //    var userName = Console.ReadLine();
        //    var password = Console.ReadLine();

        //    usersList[userName] = "dsaasd";
        //    Console.WriteLine(usersList["batu"]);

        //}

        //denemeFonk();


        // ---------------------------------------------------------------------
        //void plusMinus(List<int> arr)
        //{
        //    double plusCount = 0, minusCount = 0, zeroCount = 0;


        //    foreach (int i in arr)
        //    {
        //        if (i > 0)
        //            plusCount++;
        //        else if (i < 0)
        //            minusCount++;
        //        else zeroCount++;
        //    }
        //    Console.WriteLine(plusCount / arr.Count);
        //    Console.WriteLine(minusCount / arr.Count);
        //    Console.WriteLine(zeroCount / arr.Count);
        //}

        //plusMinus(new() { -4, 3, -9, 0, 4, 1 });

        // ---------------------------------------------------------------------
        //void staircase(int n)
        //{

        //    for (int j = 0; j < n + j; j++)
        //    {
        //        for (int i = 0; i < n + j; i++)
        //        {
        //            if (i < n - 1)
        //            {
        //                Console.Write(" ");
        //            }
        //            else if (i == (n + j))
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                Console.Write("#");
        //            }
        //        }
        //        n--;
        //        Console.WriteLine("");
        //    }

        //}

        //staircase(6);

        // ---------------------------------------------------------------------
        //void miniMaxSum(List<int> arr)
        //{

        //    List<int> withoutMax = new List<int>(arr);
        //    List<int> withoutMin = new List<int>(arr);
        //    int max = 0, min = 0;
        //    long sumWithoutMin = 0, sumWithoutMax = 0;

        //    max = arr.Max();
        //    min = arr.Min();
        //    withoutMax.Remove(max);
        //    withoutMin.Remove(min);

        //    foreach (int i in withoutMax)
        //        sumWithoutMax += i;
        //    foreach (int i in withoutMin)
        //        sumWithoutMin += i;

        //    Console.WriteLine(sumWithoutMin);
        //    Console.WriteLine(sumWithoutMax);

        //}

        //miniMaxSum(new() { 1, 2, 3, 4, 5 });

        // ---------------------------------------------------------------------
        //int birthdayCakeCandles(List<int> candles)
        //{

        //    int tallestCandleCount = 1;
        //    int tallestCandle = 0;

        //    foreach (var candle in candles)
        //    {
        //        if (candle > tallestCandle)
        //            tallestCandle = candle;
        //        else if (candle == tallestCandle)
        //            tallestCandleCount++;
        //    }

        //    Console.WriteLine(tallestCandleCount);
        //    return tallestCandleCount;
        //}

        //birthdayCakeCandles(new() { 1, 2, 3, 4, 5, 5, 5, 5, 3, 1, 2, 3, 1 });


        // ---------------------------------------------------------------------
        //string timeConversion(string s)
        //{
        //    string result = "";

        //    if (s.Contains("P"))
        //    {
        //        string hourPart = s.Substring(0, 2);
        //        int updatedHourPart = int.Parse(hourPart) + 12;
        //        if (updatedHourPart == 24)
        //            result = "12" + s.Substring(2, 6);
        //        else
        //            result = updatedHourPart.ToString() + s.Substring(2, 6);
        //    }
        //    else
        //    {
        //        if (int.Parse(s.Substring(0, 2)) == 12)
        //            result = "00" + s.Substring(2, 6);
        //        else
        //            result = s.Substring(0, 8);
        //    }
        //    Console.WriteLine(result);
        //    return result;
        //}

        //timeConversion("07:05:45PM");


        // ---------------------------------------------------------------------
        //List<int> gradingStudents(List<int> grades)
        //{
        //    List<int> result = new List<int>();

        //    foreach (var grade in grades)
        //    {
        //        if (grade > 37)
        //        {
        //            if (grade % 10 == 8 || grade % 10 == 3) { result.Add(grade + 2); Console.WriteLine(grade); }
        //            else if (grade % 10 == 9 || grade % 10 == 4) { result.Add(grade + 1); }
        //            else result.Add(grade);
        //        }
        //        else
        //            result.Add(grade);
        //    }


        //    return result;
        //}

        //gradingStudents(new() { 48 });


        // ---------------------------------------------------------------------
        //void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        //{

        //    int applesLandedOnHouse = 0;
        //    int orangesLandedOnHouse = 0;

        //    foreach (int apple in apples)
        //    {
        //        if (a + apple >= s && a + apple <= t)
        //            applesLandedOnHouse++;
        //    }

        //    foreach (int orange in oranges)
        //    {
        //        if (b + orange >= s && b + orange <= t)
        //        {
        //            orangesLandedOnHouse++;
        //        }
        //    }
        //    Console.WriteLine(applesLandedOnHouse);
        //    Console.WriteLine(orangesLandedOnHouse);

        //}


        //countApplesAndOranges(s: 7, t: 11, a: 5, b: 15, apples: new() { -2, 2, 1 }, oranges: new() { 5, -6 });


        // ---------------------------------------------------------------------
        //string kangaroo(int x1, int v1, int x2, int v2)
        //{
        //    int loopCount = 10000;
        //    int firstKangaroo = x1;
        //    int secondKangaroo = x2;

        //    while (loopCount > 0)
        //    {
        //        if (firstKangaroo == secondKangaroo)
        //        {
        //            return "YES";
        //        }
        //        firstKangaroo += v1;
        //        secondKangaroo += v2;

        //        loopCount--;
        //    }
        //    return "NO";
        //}

        //kangaroo(0, 3, 4, 2);


        // ---------------------------------------------------------------------
        //int getTotalX(List<int> a, List<int> b)
        //{

        //    for (int i = 1; i < a.Count; i++)
        //    {
        //        if (a[i] % a[0] == 0)
        //        {

        //        }
        //    }

        //    return 0;
        //}

        //getTotalX(new() { 2, 4 }, new() { 16, 32, 96 });


        // ---------------------------------------------------------------------
        //List<int> breakingRecords(List<int> scores)
        //{
        //    int recordBestBeatenCount = 0;
        //    int recordWorstBeatenCount = 0;
        //    int recordMax = scores[0];
        //    int recordWorst = scores[0];

        //    foreach (var item in scores)
        //    {
        //        if (item > recordMax)
        //        {
        //            recordBestBeatenCount++;
        //            recordMax = item;
        //        }
        //        else if (item < recordWorst)
        //        {
        //            recordWorstBeatenCount++;
        //            recordWorst = item;
        //        }
        //    }
        //    return new() { recordBestBeatenCount, recordWorstBeatenCount };
        //}

        //breakingRecords(new() { 10, 5, 20, 20, 4, 5, 2, 25, 1 });



        // ---------------------------------------------------------------------
        //int birthday(List<int> s, int d, int m)
        //{
        //    int result = 0;
        //    int canDivided = 0;

        //    for (int j = 0; j < s.Count - (m - 1); j++)
        //    {
        //        for (int i = 0; i < m; i++)
        //        {
        //            canDivided += s[i+j];
        //        }
        //        if (canDivided == d)
        //            result++;
        //        canDivided = 0;
        //    }
        //    return result;
        //}

        //birthday(new() { 1, 1, 1, 1, 1, 1 }, 3, 3);
        //birthday(new() { 1, 2, 1, 3, 2 }, 3, 2);




        // ---------------------------------------------------------------------
        //int divisibleSumPairs(int n, int k, List<int> ar)
        //{
        //    int result = 0;
        //    for (int i = 0; i < ar.Count - 1; i++)
        //    {
        //        int currentNumber = ar[i];

        //        for (int j = i + 1; j < ar.Count; j++)
        //        {
        //            if ((ar[i] + ar[j]) % k == 0)
        //            {
        //                result++;
        //            }
        //        }

        //    }
        //    return result;
        //}

        //divisibleSumPairs(6, 3, new() { 1, 3, 2, 6, 1, 2 });



        // ---------------------------------------------------------------------
        //int migratoryBirds(List<int> arr)
        //{
        //    arr.Sort();
        //    int mostSightedCount = 1;
        //    int mostSightedId = 0;
        //    int currentSightedId = 0;
        //    int currentSightedCount = 1;

        //    foreach (int i in arr)
        //    {
        //        if (currentSightedId != i)
        //        {
        //            currentSightedCount = 0;
        //            currentSightedId = i;
        //        }
        //        else if (currentSightedId == i)
        //            currentSightedCount++;
        //        if (mostSightedCount < currentSightedCount)
        //        {
        //            if (currentSightedId == mostSightedId)
        //                mostSightedCount = currentSightedCount;
        //            else
        //            {
        //                mostSightedCount = currentSightedCount;
        //                mostSightedId = i;
        //            }
        //        }
        //    }
        //    Console.WriteLine(mostSightedId);
        //    return mostSightedId;
        //}

        //migratoryBirds(new() { 1, 4, 4, 4, 5, 3, 3, 3 });



        // ---------------------------------------------------------------------
        //string dayOfProgrammer(int year)
        //{

        //    if ((1700 < year && year <= 1917) && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
        //    {
        //        return $"12.09.{year}";
        //    }

        //    else if (year == 1918)
        //    {
        //        return $"30.08.{year}";
        //    }

        //    else if (year % 4 == 0)
        //    {
        //        return $"12.09.{year}";
        //    }

        //    return $"13.09.{year}";
        //}
        // ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        //string dayOfProgrammer(int year)
        //{

        //    if ((1700 <= year && year <= 1917) && year % 4 == 0)
        //        return $"12.09.{year}";
        //    else if (year == 1918)
        //        return $"26.09.{year}";
        //    else if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        //        return $"12.09.{year}";
        //    else
        //        return $"13.09.{year}";

        //}

        //dayOfProgrammer(1234);



        // ---------------------------------------------------------------------
        //void bonAppetit(List<int> bill, int k, int b)
        //{
        //    int billTotal = 0;
        //    int annaDeclined = bill[k];

        //    foreach (int i in bill)
        //    {
        //        billTotal += i;
        //    }

        //    if((billTotal-annaDeclined)/2 == b)
        //        Console.WriteLine("Bon Appetit");
        //    else
        //        Console.WriteLine(b-(billTotal - annaDeclined) / 2);

        //}

        //bonAppetit(new() { 3, 10, 2, 9 }, 1, 12);


        // ---------------------------------------------------------------------
        //int sockMerchant(int n, List<int> ar)
        //{
        //    ar.Sort();
        //    int currentNumber = 0;
        //    int pairCount = 0;

        //    foreach (int i in ar)
        //    {
        //        if (currentNumber != i)
        //        {
        //            currentNumber = i;
        //        }
        //        else if (currentNumber == i)
        //        {
        //            pairCount++;
        //            currentNumber = 0;
        //        }
        //    }
        //    return pairCount;
        //}

        //sockMerchant(9, new() { 10, 20, 20, 10, 10, 20, 30, 50, 10, 20 });


        // ---------------------------------------------------------------------
        //void factorial()
        //{

        //    var inputNumber = 0;
        //    int total = 1;
        //    int curretNumber = 1;

        //    for (int i = 0; i < inputNumber; i++)
        //    {
        //        total = curretNumber;
        //        curretNumber++;
        //    }
        //    Console.WriteLine(total);

        ////for (int i = 2; i <= n; i++)
        ////{
        ////    result *= i;
        ////}

        //}

        //factorial();


        // ---------------------------------------------------------------------
        //bool BunnyGame(int leap, int[] game)
        //{
        //    bool tryLeap = false;

        //    for (int i = 0; i < game.Length; i++)
        //    {
        //        if (i + leap > game.Length)
        //        {
        //            break;
        //        }
        //        if (tryLeap)
        //        {
        //            if (game[i + leap] == 0)
        //            {
        //                i = i + leap - 1;
        //                tryLeap = false;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Kaybettin");
        //                return false;
        //            }
        //        }

        //        else if (game[i] == 1)
        //        {
        //            i -= 2;
        //            tryLeap = true;
        //        }
        //    }
        //    Console.WriteLine("Kazandın");
        //    return true;
        //}

        //BunnyGame(2, new int[] { 0, 1, 0, 1, 0, 1, 0, 0, 1 });


        // ---------------------------------------------------------------------
        //int pageCount(int n, int p)
        //{
        //    int leftToRight = leftToRight = p / 2;
        //    int rightToLeft = (n - p) / 2;
        //    if (n % 2 == 0 && n != p && p % 2 == 1) rightToLeft++;
        //    Console.WriteLine(leftToRight + " " + rightToLeft);
        //    if (leftToRight < 0 || rightToLeft < 0) return 0;
        //    if (leftToRight < rightToLeft) return leftToRight;
        //    else return rightToLeft;
        //}

        //pageCount(6, 3);


        // ---------------------------------------------------------------------
        //int countingValleys(int steps, string path)
        //{

        //    int seaLevel = 0;
        //    int valleyCount = 0;

        //    foreach (var step in path)
        //    {
        //        if (step == 'U')
        //        {
        //            seaLevel++;
        //            if (seaLevel == 0)
        //                valleyCount++;
        //        }
        //        else if (step == 'D')
        //            seaLevel--;
        //    }
        //    Console.WriteLine(valleyCount);
        //    return valleyCount;
        //}

        //countingValleys(8, "UDDDUDUUDDUUUUUUDDDDDDDDUUUU");


        // ---------------------------------------------------------------------
        //int getMoneySpent(int[] keyboards, int[] drives, int b)
        //{
        //    int maxPrice = 0;

        //    if (keyboards.Min() + drives.Min() > b) return -1;

        //    foreach (var keyboard in keyboards)
        //    {
        //        foreach (var drive in drives)
        //        {
        //            if (keyboard + drive <= b && keyboard + drive > maxPrice)
        //                maxPrice = keyboard + drive;
        //        }
        //    }
        //    Console.WriteLine(maxPrice);
        //    return maxPrice;
        //}

        //getMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10);
        #region
        ////getMoneySpent(new int[] { 183477 ,732159 ,779867 ,598794 ,596985 ,156054 ,445934 ,156030 ,99998 ,58097 ,459353 ,866372 ,333784 ,601251 ,142899 ,708233 ,651036 ,20590 ,56425 ,970129 ,722162 ,832631 ,938765 ,212387 ,779 ,181866 ,992436 ,183446 ,617621 ,304311 ,611791 ,524875 ,7068 ,432043 ,23068 ,291295 ,524893 ,611991 ,399952 ,139526 ,46677 ,292211 ,973975 ,366445 ,232824 ,456173 ,90627 ,785353 ,618526 ,199719 ,382549 ,514351 ,983453 ,592549 ,466869 ,46461 ,860135 ,607682 ,680461 ,170563 ,450601 ,65067 ,13268 ,949100 ,942415 ,965850 ,563416 ,808580 ,385504 ,304683 ,15970 ,97695 ,230946 ,684388 ,241080 ,440252 ,683418 ,122066 ,610135 ,495289 ,833383 ,34397 ,173404 ,909526 ,391149 ,258839 ,182278 ,662672 ,755532 ,311782 ,425252 ,520186 ,207989 ,546834 ,567829 ,184897 ,31321 ,969804 ,842475 ,775308 ,449856 ,939711 ,395240 ,895029 ,926868 ,598035 ,727436 ,922082 ,326615 ,88513 ,570573 ,196028 ,520952 ,45238 ,961389 ,325404 ,844725 ,388765 ,747489 ,271411 ,539814 ,828925 ,586884 ,356834 ,965473 ,280998 ,607171 ,542819 ,276062 ,140956 ,296341 ,802378 ,165305 ,74568 ,15640 ,987110 ,423497 ,772419 ,394971 ,198761 ,293555 ,5524 ,14083 ,815646 ,198888 ,707017 ,711503 ,729172 ,790354 ,771445 ,606097 ,74062 ,926510 ,358547 ,651224 ,115896 ,915166 ,863298 ,850231 ,623439 ,449552 ,330973 ,95432 ,63573 ,370902 ,311053 ,668992 ,325257 ,666073 ,729771 ,591431 ,637702 ,274784 ,887413 ,561370 ,472322 ,383014 ,119622 ,971931 ,713406 ,849106 ,760957 ,721893 ,561404 ,236039 ,771141 ,256127 ,493907 ,40443 ,522851 ,710823 ,427638 ,110916 ,25425 ,439436 ,107916 ,201765 ,31437 ,895966 ,636554 ,475478 ,314427 ,563403 ,508686 ,695673 ,907771 ,139363 ,249349 ,604554 ,410476 ,539963 ,755722 ,203107 ,228850 ,943066 ,76998 ,599001 ,289817 ,694942 ,161258 ,880667 ,929908 ,624495 ,808303 ,295701 ,633547 ,105519 ,871657 ,456638 ,803854 ,218490 ,186613 ,416604 ,892761 ,883480 ,539464 ,324419 ,807623 ,122116 ,896294 ,356379 ,318076 ,907033 ,110077 ,272194 ,227987 ,647837 ,427205 ,521 ,818200 ,352649 ,860925 ,304850 ,6954 ,164693 ,510863 ,534210 ,417506 ,484940 ,222158 ,692593 ,119893 ,269474 ,337692 ,244181 ,943123 ,168329 ,323276 ,218814 ,518908 ,558228 ,703178 ,403928 ,363712 ,64907 ,972001 ,253973 ,962665 ,246932 ,251840 ,696462 ,497361 ,712432 ,300947 ,148121 ,284905 ,997966 ,36896 ,266842 ,609702 ,976835 ,502793 ,411130 ,51491 ,33059 ,278710 ,345149 ,908471 ,634495 ,239616 ,680859 ,144928 ,531055 ,489564 ,447885 ,985873 ,553018 ,242110 ,592831 ,672287 ,80872 ,761792 ,369738 ,237692 ,242215 ,728381 ,803321 ,367866 ,470407 ,632449 ,983645 ,633673 ,398915 ,535896 ,816616 ,90311 ,798525 ,835491 ,150752 ,320853 ,508314 ,186561 ,695970 ,40785 ,858553 ,591027 ,326033 ,677717 ,220291 ,16592 ,711310 ,512209 ,809684 ,226547 ,348745 ,645319 ,96199 ,174406 ,940736 ,691094 ,397662 ,386823 ,517868 ,936942 ,837899 ,137552 ,675843 ,341144 ,735382 ,113500 ,209119 ,924902 ,541570 ,877537 ,695942 ,258000 ,228602 ,660133 ,174995 ,817407 ,982390 ,555326 ,516753 ,529770 ,260888 ,241907 ,996479 ,93124 ,965637 ,897418 ,558420 ,900621 ,882836 ,633245 ,188750 ,339107 ,278935 ,349289 ,700516 ,726120 ,846852 ,897313 ,856518 ,887287 ,404600 ,780052 ,887971 ,642177 ,851121 ,84159 ,935846 ,161666 ,785518 ,898757 ,669139 ,606566 ,580818 ,9200 ,372367 ,101495 ,940346 ,663652 ,973884 ,5063 ,283985 ,160845 ,305433 ,548858 ,485724 ,692052 ,448526 ,652109 ,994682 ,224320 ,175965 ,712340 ,18080 ,237303 ,494005 ,325474 ,178863 ,746660 ,366552 ,649780 ,744339 ,849415 ,721103 ,657762 ,308131 ,568437 ,542663 ,93696 ,508929 ,367799 ,636476 ,265263 ,250519 ,244045 ,590004 ,973230 ,979114 ,393187 ,486852 ,892248 ,906303 ,631281 ,434493 ,794991 ,350158 ,502751 ,645249 ,577034 ,669075 ,492629 ,864363 ,195287 ,230238 ,722615 ,499306 ,280836 ,572134 ,24322 ,768728 ,645618 ,43614 ,177151 ,994775 ,940671 ,470051 ,954144 ,279624 ,915071 ,883694 ,370243 ,747888 ,15461 ,953287 ,928528 ,330825 ,428281 ,552890 ,966873 ,572422 ,963838 ,980553 ,853202 ,75364 ,294516 ,305766 ,385185 ,190955 ,851329 ,268536 ,316994 ,485390 ,169531 ,372771 ,556927 ,394781 ,936366 ,844404 ,696187 ,930227 ,570190 ,70432 ,97199 ,208966 ,615146 ,671295 ,990277 ,358728 ,140116 ,254221 ,518447 ,295358 ,877571 ,322624 ,740936 ,848861 ,697173 ,136653 ,702643 ,709071 ,359573 ,552945 ,293658 ,296577 ,809544 ,419876 ,810296 ,256265 ,867268 ,611652 ,913447 ,81613 ,511458 ,5187 ,501630 ,628036 ,798476 ,194318 ,650111 ,70957 ,702126 ,396874 ,795972 ,50780 ,890206 ,886817 ,338072 ,27623 ,375668 ,578996 ,94004 ,438573 ,578411 ,672178 ,35951 ,328227 ,465703 ,155077 ,542767 ,982063 ,286606 ,839123 ,590967 ,860599 ,30508 ,250308 ,37357 ,38844 ,822786 ,303334 ,360272 ,537204 ,127090 ,326725 ,522361 ,828056 ,770168 ,271605 ,215870 ,965470 ,623031 ,457369 ,85367 ,842213 ,51694 ,194424 ,531475 ,411447 ,540757 ,699670 ,637574 ,138385 ,726255 ,132776 ,976072 ,969756 ,516417 ,714757 ,323030 ,41077 ,795366 ,398911 ,270894 ,433619 ,439071 ,744211 ,78475 ,250918 ,25357 ,184376 ,962866 ,80892 ,836169 ,428411 ,696131 ,688655 ,409046 ,58207 ,173334 ,915420 ,156473 ,442452 ,250300 ,239842 ,549351 ,93895 ,714757 ,182908 ,660347 ,934825 ,279997 ,638415 ,955081 ,516813 ,738064 ,657260 ,554479 ,435772 ,611859 ,730204 ,419695 ,47727 ,247787 ,566165 ,356053 ,158683 ,758017 ,120192 ,14397 ,341957 ,116099 ,91820 ,46014 ,94179 ,40738 ,311484 ,855654 ,979732 ,703817 ,175370 ,474281 ,17165 ,97857 ,763537 ,491727 ,807095 ,473579 ,346383 ,173241 ,464779 ,433950 ,649921 ,398595 ,48070 ,615989 ,949360 ,635237 ,886881 ,45315 ,260953 ,374698 ,15308 ,626001 ,933647 ,503250 ,501153 ,856683 ,539499 ,658843 ,684118 ,162972 ,615990 ,70585 ,944105 ,642564 ,944465 ,26518 ,867395 ,585908 ,636547 ,940443 ,801130 ,575604 ,677321 ,388258 ,573497 ,643434 ,128530 ,458357 ,811387 ,545740 ,820825 ,941677 ,626081 ,386190 ,820612 ,961408 ,651632 ,905555 ,206731 ,195836 ,274023 ,69377 ,214638 ,100801 ,377345 ,18226 ,38972 ,94465 ,618394 ,683161 ,336631 ,71205 ,655871 ,319048 ,385484 ,845066 ,681768 ,23278 ,340702 ,814652 ,260754 ,281919 ,496150 ,118192 ,693047 ,696895 ,348416 ,629085 ,936860 ,877670 ,39196 ,735237 ,418041 ,803662 ,967799 ,282099 ,548096 ,177480 ,423567 ,750784 ,568649 ,807017 ,576055 ,990729 ,731813 ,412711 ,127719 ,372102 ,250073 ,776588 ,580675 ,340881 ,867312 ,930967 ,561994 ,858607 ,238651 ,429091 ,679998 ,751041 ,740076 ,754713 ,238290 }, new int[] { 103148 ,377814 ,902757 ,534448 ,505367 ,496674 ,826644 ,389706 ,320122 ,297703 ,895725 ,100008 ,389290 ,53498 ,10841 ,958758 ,905586 ,847334 ,91308 ,354986 ,319386 ,957017 ,950276 ,676923 ,950822 ,482630 ,573568 ,493137 ,631980 ,83304 ,448547 ,91725 ,293277 ,602577 ,328739 ,553828 ,672670 ,212776 ,752545 ,946408 ,791758 ,781473 ,789797 ,113491 ,91227 ,931139 ,494532 ,974468 ,57572 ,996156 ,549653 ,55884 ,441630 ,737202 ,887905 ,546039 ,350995 ,705991 ,117094 ,968871 ,143024 ,688185 ,761683 ,837153 ,618358 ,867064 ,101146 ,838670 ,84126 ,426188 ,701128 ,222627 ,72780 ,396741 ,822046 ,892098 ,706402 ,146638 ,81368 ,513442 ,84857 ,233281 ,986862 ,581437 ,374356 ,863333 ,370726 ,880559 ,812983 ,236739 ,947462 ,907899 ,986224 ,592023 ,753548 ,350298 ,376345 ,708341 ,83520 ,481776 ,777322 ,378073 ,558531 ,705244 ,424318 ,248781 ,906559 ,330327 ,111223 ,434550 ,492737 ,253740 ,11357 ,405294 ,468767 ,571602 ,56316 ,741141 ,118845 ,767368 ,117553 ,822976 ,649357 ,744380 ,746213 ,681193 ,583501 ,237560 ,962390 ,400314 ,374956 ,477823 ,285777 ,82910 ,868795 ,528490 ,223647 ,436435 ,963440 ,802290 ,12158 ,978121 ,970098 ,556131 ,43170 ,322760 ,891344 ,43411 ,527820 ,924852 ,993189 ,919323 ,73814 ,253048 ,553980 ,695568 ,969521 ,75452 ,523216 ,166253 ,629541 ,216858 ,695906 ,294561 ,454644 ,996056 ,627700 ,697083 ,584446 ,384289 ,901362 ,737267 ,45457 ,915461 ,281027 ,958919 ,950626 ,57877 ,890465 ,394611 ,455760 ,106781 ,620273 ,335736 ,277444 ,169719 ,188164 ,646995 ,463803 ,388356 ,353432 ,229447 ,583788 ,265998 ,77753 ,360427 ,974615 ,260009 ,986433 ,453343 ,698319 ,32324 ,536218 ,279827 ,309598 ,411300 ,813979 ,602918 ,684886 ,271019 ,162654 ,133216 ,911133 ,76218 ,822723 ,940744 ,950014 ,416733 ,725883 ,581294 ,613554 ,919384 ,418338 ,82768 ,932939 ,876859 ,866259 ,551713 ,45229 ,164872 ,26373 ,411348 ,376549 ,777778 ,810736 ,480479 ,987499 ,985509 ,150451 ,376824 ,594265 ,749748 ,380977 ,393078 ,970133 ,829352 ,842309 ,569210 ,838518 ,63527 ,468799 ,36831 ,414913 ,133883 ,273469 ,13676 ,56389 ,75377 ,864918 ,691871 ,813085 ,534467 ,999943 ,750080 ,996862 ,913372 ,555557 ,585282 ,769161 ,726285 ,944979 ,757252 ,849839 ,377936 ,247404 ,241140 ,450646 ,205092 ,129189 ,251500 ,954266 ,274794 ,606312 ,207275 ,228695 ,878419 ,671852 ,757170 ,618268 ,46908 ,358244 ,268734 ,113584 ,22190 ,671725 ,498278 ,520425 ,476318 ,772493 ,831559 ,520281 ,307847 ,852374 ,816570 ,552032 ,968192 ,561065 ,88429 ,876852 ,791997 ,403574 ,590089 ,134046 ,480155 ,28790 ,420631 ,755308 ,784846 ,620450 ,639506 ,704239 ,805227 ,213013 ,903355 ,136403 ,617403 ,14548 ,980684 ,350667 ,608225 ,590051 ,636788 ,392333 ,554941 ,437574 ,91023 ,904363 ,726561 ,348334 ,547570 ,514106 ,451013 ,783830 ,910677 ,396633 ,298027 ,622227 ,523721 ,862558 ,697800 ,949735 ,796652 ,147107 ,459451 ,926797 ,842282 ,492228 ,769091 ,258303 ,66251 ,459240 ,45872 ,980254 ,620946 ,492730 ,347492 ,328826 ,209178 ,633544 ,579781 ,240200 ,341641 ,75881 ,537385 ,128909 ,460223 ,128075 ,584898 ,151937 ,400391 ,138859 ,697825 ,641020 ,180108 ,181922 ,696659 ,345746 ,411754 ,896991 ,874515 ,474069 ,515353 ,667709 ,973330 ,172359 ,602071 ,192333 ,223900 ,40878 ,821976 ,168974 ,345161 ,278654 ,347698 ,177051 ,31812 ,88723 ,548839 ,120664 ,534544 ,460883 ,356072 ,206381 ,894419 ,364352 ,128778 ,503531 ,330174 ,690551 ,321656 ,39321 ,92312 ,799591 ,481254 ,628042 ,687940 ,81778 ,511773 ,873776 ,157014 ,921080 ,377371 ,61092 ,2596 ,276941 ,868497 ,806383 ,84537 ,748429 ,597413 ,184563 ,986480 ,209397 ,536712 ,370556 ,924250 ,484633 ,236170 ,618395 ,760127 ,368997 ,531386 ,462639 ,720679 ,747640 ,62356 ,36692 ,147773 ,252494 ,133147 ,713511 ,687321 ,895409 ,844631 ,511793 ,749786 ,532234 ,30480 ,107197 ,867411 ,447514 ,354227 ,532738 ,397254 ,242526 ,104893 ,269304 ,737572 ,377370 ,182325 ,20076 ,564093 ,322152 ,840900 ,211496 ,89225 ,327572 ,535457 ,119790 ,233269 ,890728 ,343005 ,593727 ,474077 ,679256 ,355185 ,789350 ,648969 ,498555 ,479691 ,86940 ,584332 ,537228 ,736989 ,586974 ,557868 ,745608 ,586668 ,431757 ,564586 ,127610 ,378858 ,283840 ,337523 ,363165 ,899851 ,646063 ,607693 ,570907 ,244409 ,356177 ,498360 ,986738 ,330423 ,605912 ,933903 ,237281 ,7537 ,101806 ,225384 ,152894 ,365440 ,246014 ,487920 ,160718 ,851010 ,186610 ,87908 ,285160 ,806047 ,173413 ,55667 ,896968 ,842504 ,80252 ,51648 ,524630 ,18247 ,410490 ,697119 ,982600 ,997481 ,112065 ,896813 ,397946 ,576129 ,969689 ,917603 ,865703 ,5302 ,817257 ,975287 ,257961 ,490860 ,170927 ,723059 ,668794 ,821047 ,929586 ,718620 ,556889 ,535158 ,571742 ,476727 ,280043 ,838772 ,769667 ,205124 ,187086 ,968213 ,323753 ,711113 ,425533 ,199552 ,507725 ,736414 ,242465 ,529960 ,114863 ,707390 ,610758 ,767953 ,288696 ,87310 ,581370 ,506218 ,154398 ,932225 ,481249 ,320715 ,532710 ,594017 ,51836 ,369314 ,336681 ,454371 ,134445 ,548727 ,63390 ,549046 ,990184 ,201776 ,322427 ,684726 ,810057 ,87888 ,254699 ,138857 ,681657 ,2712 ,760400 ,116723 ,595773 ,473273 ,471683 ,606239 ,411934 ,794469 ,348947 ,106724 ,929739 ,850920 ,830807 ,746143 ,965245 ,408611 ,124326 ,933149 ,731033 ,991153 ,938552 ,205048 ,181274 ,379315 ,66512 ,926659 ,741288 ,721760 ,574603 ,48106 ,842019 ,781691 ,139804 ,828128 ,795447 ,750671 ,201673 ,799718 ,163693 ,825319 ,164303 ,186447 ,814759 ,235745 ,665348 ,633902 ,523184 ,908071 ,358912 ,316268 ,877399 ,588440 ,392534 ,683136 ,816784 ,452051 ,439234 ,713944 ,377030 ,899871 ,462785 ,624243 ,301446 ,539903 ,747778 ,438844 ,502834 ,577617 ,232266 ,355443 ,899778 ,391571 ,383978 ,531978 ,543676 ,66635 ,906677 ,229077 ,624379 ,542972 ,116925 ,431626 ,940044 ,332891 ,627850 ,730714 ,334982 ,693874 ,139304 ,166769 ,794205 ,878828 ,620213 ,495536 ,533582 ,741628 ,894094 ,573280 ,788775 ,997918 ,151710 ,752573 ,311793 ,707140 ,248546 ,778748 ,744114 ,143161 ,33540 ,204591 ,570019 ,714225 ,762631 ,494093 ,876964 ,754806 ,342159 ,102940 ,821443 ,536603 ,110657 ,378907 ,846643 ,457104 ,127518 ,604094 ,397377 ,502402 ,797475 ,539983 ,149952 ,486468 ,229304 ,409048 ,722416 ,772056 ,720199 ,12206 ,641293 ,598578 ,694105 ,565636 ,542847 ,716341 ,251856 ,599165 ,345774 ,826986 ,181639 ,959291 ,908656 ,342602 ,583524 ,227403 ,400942 ,423693 ,462110 ,287995 ,947497 ,615089 ,153386 ,912058 ,586362 ,139148 ,506003 ,100818 ,611592 ,256074 ,18115 ,726260 ,872321 ,593097 ,932329 ,102236 ,565261 ,918958 ,696808 ,790263 ,922708 ,23028 ,707398 ,651514 ,152574 ,771421 ,576419 ,374520 ,606852 ,68938 ,424227 ,77339 ,736611 ,104271 ,934578 ,840629 ,925778 ,910892 ,450941 ,122839 ,113264 ,235960 ,985064 ,165558 ,839088 ,186363 ,124691 ,837680 ,921050 ,332222 ,870093 ,311515 ,518955 ,227447 ,591409 ,608032 ,399093 ,379392 ,54774 ,744418 ,335273 ,205627 ,803035 ,787968 ,4634 ,603858 ,333575 ,114294 ,398259 ,414598 ,537517 ,863713 ,920063 ,923169 ,346425 ,465806 ,347032 ,480946 ,737668 ,918662 ,452320 ,587201 ,224656 ,32855 ,452542 ,912956 ,140889 ,248283 ,176427 ,577763 ,498481 ,165551 ,419020 ,33887 ,915052 ,311544 ,362476 ,780672 ,580720 ,277650 ,632407 ,220147 ,13098 ,212729 ,663687 ,515290 ,178077 ,975762 ,961287 ,459093 ,148697 ,557431 ,414718 ,860826 ,85369 ,535191 ,997099 ,184505 ,502309 ,299664 ,595520 ,310007 ,67092 ,397408 ,750130 ,426886 ,209953 ,799963 ,898257 ,349466 ,205186 ,468338 ,190731 ,625117 ,36558 ,377812 ,472174 ,836754 ,564969 ,587586 ,65724 ,294111 ,775703 ,714221 ,453391 ,527767 ,524509 ,534577 ,440863 ,481197 ,400854 ,497124 ,559767 ,765529 ,155276 ,103005 ,181970 ,334439 ,861980 ,75521 ,946329 ,753416 ,373394 ,272364 ,270806 ,897633 ,644145 ,526698 ,408827 ,800931 ,25393 ,979152 ,156188 }, 374625);
        #endregion
        //uzun test senaryosu ^^^^^^


        // ---------------------------------------------------------------------
        //string catAndMouse(int x, int y, int z)
        //{
        //    if (Math.Abs(x - z) < Math.Abs(y - z))
        //        return "Cat A";
        //    else if (Math.Abs(x - z) > Math.Abs(y - z))
        //        return "Cat B";
        //    else
        //        return "Mouse C";
        //}


        // ---------------------------------------------------------------------

        //int pickingNumbers(List<int> a)
        //{

        //    a.Sort();

        //    int preNumber = 0;
        //    int currentNumber = a == null ? 0 : a[0];
        //    int maxCount = 0;
        //    int preNumberCount = 0;
        //    int selectedMaxCount = 0;

        //    foreach (int number in a)
        //    {
        //        if (number == currentNumber)
        //            maxCount++;

        //        else if (number == currentNumber + 1)
        //        {
        //            maxCount++;
        //            preNumberCount++;
        //        }

        //        else if (number > currentNumber + 1)
        //        {
        //            selectedMaxCount = maxCount;
        //            currentNumber = number - 1;
        //            maxCount = preNumberCount + 1;
        //        }
        //    }
        //    return maxCount;
        //}

        //pickingNumbers(new() { 1, 3, 3, 4, 5, 65, 6, 3, 3, 324 });

        // ---------------------------------------------------------------------
        // ---------------------------------------------------------------------
        // ---------------------------------------------------------------------
        // ---------------------------------------------------------------------

        //int hurdleRace(int k, List<int> height)
        //{
        //    int numberOfPotions = height.Max() - k;
        //    if (numberOfPotions > 0)
        //    {
        //        return numberOfPotions;
        //    }
        //    return 0;
        //}


        // ---------------------------------------------------------------------
        //int designerPdfViewer(List<int> h, string word)
        //{
        //    int maxCharHeight = 0;
        //    int currentCharHeight = 0;

        //    foreach (var ch in word)
        //    {
        //        switch (ch)
        //        {
        //            case 'a': currentCharHeight = h[0]; break;
        //            case 'b': currentCharHeight = h[1]; break;
        //            case 'c': currentCharHeight = h[2]; break;
        //            case 'd': currentCharHeight = h[3]; break;
        //            case 'e': currentCharHeight = h[4]; break;
        //            case 'f': currentCharHeight = h[5]; break;
        //            case 'g': currentCharHeight = h[6]; break;
        //            case 'h': currentCharHeight = h[7]; break;
        //            case 'i': currentCharHeight = h[8]; break;
        //            case 'j': currentCharHeight = h[9]; break;
        //            case 'k': currentCharHeight = h[10]; break;
        //            case 'l': currentCharHeight = h[11]; break;
        //            case 'm': currentCharHeight = h[12]; break;
        //            case 'n': currentCharHeight = h[13]; break;
        //            case 'o': currentCharHeight = h[14]; break;
        //            case 'p': currentCharHeight = h[15]; break;
        //            case 'q': currentCharHeight = h[16]; break;
        //            case 'r': currentCharHeight = h[17]; break;
        //            case 's': currentCharHeight = h[18]; break;
        //            case 't': currentCharHeight = h[19]; break;
        //            case 'u': currentCharHeight = h[20]; break;
        //            case 'v': currentCharHeight = h[21]; break;
        //            case 'w': currentCharHeight = h[22]; break;
        //            case 'x': currentCharHeight = h[23]; break;
        //            case 'y': currentCharHeight = h[24]; break;
        //            case 'z': currentCharHeight = h[25]; break;
        //            default:
        //                break;
        //        }
        //        if (currentCharHeight > maxCharHeight)
        //            maxCharHeight = currentCharHeight;
        //    }
        //    return word.Length * maxCharHeight;
        //}

        //designerPdfViewer(new List<int> { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba");


        // ---------------------------------------------------------------------
        //int utopianTree(int n)
        //{
        //    int result = 1;
        //    for (int i = 0; i <= n - 1; i++)
        //    {
        //        if (i % 2 != 0)
        //            result++;
        //        else
        //            result *= 2;
        //    }
        //    return result;
        //}

        // ---------------------------------------------------------------------
        //string angryProfessor(int k, List<int> a)
        //{
        //    int studentOnTime = 0;
        //    foreach (int i in a)
        //    {
        //        if (i <= 0)
        //            studentOnTime++;
        //    }
        //    if (studentOnTime >= k)
        //        return "NO";
        //    else
        //        return "YES";
        //}


        // ---------------------------------------------------------------------
        //int beautifulDays(int i, int j, int k)
        //{
        //    int result = 0;
        //    for (; i <= j; i++)
        //    {
        //        int reversed = 0;
        //        int tempNum = i;
        //        while (tempNum > 0)
        //        {
        //            reversed = reversed * 10 + tempNum % 10;
        //            tempNum = tempNum / 10;
        //        }

        //        Math.DivRem(Math.Abs(reversed - i), k, out int kalan);
        //        if (kalan == 0)
        //            result++;
        //    }
        //    return result;
        //}

        //beautifulDays(20, 23, 6);


        // ---------------------------------------------------------------------
        //int viralAdvertising(int n)
        //{
        //    int result = 0;
        //    int shared = 5;

        //    for (int i = 0; i < n; i++)
        //    {
        //        result += shared / 2;
        //        shared = (shared/2) * 3;
        //    }
        //    return result;
        //}
        //viralAdvertising(5);


        // ---------------------------------------------------------------------
        //int saveThePrisoner(int n, int m, int s)
        //{
        //    //int currentPrisonerNumber = s;
        //    //for (int i = 1; i < m; i++)
        //    //{
        //    //    if (currentPrisonerNumber == n)
        //    //        currentPrisonerNumber = 1;
        //    //    else
        //    //        currentPrisonerNumber++;
        //    //}
        //    //Console.WriteLine(currentPrisonerNumber);
        //    //return currentPrisonerNumber;

        //    var currentPrisonerNumber = (s + m - 1) % n;
        //    return currentPrisonerNumber == 0 ? n : currentPrisonerNumber;

        //}
        //saveThePrisoner(352926151, 380324688, 94730870);


        // ---------------------------------------------------------------------
        //List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        //{

        //    //List<int> result = new();

        //    //for (int i = 0; i < k; i++)
        //    //{
        //    //    int goingToMove = a.Last();
        //    //    a.Remove(goingToMove);
        //    //    a.Insert(0, goingToMove);
        //    //}

        //    //foreach (var item in queries)
        //    //{
        //    //    result.Insert(0, item);
        //    //}

        //    //return result;
        //    // BURANIN ÜSTÜ YETERLİ PERFORMANSA SAHİP OLMADIĞI İÇİN KABUL EDİLMİYOR

        //    List<int> temp = new();
        //    List<int> result = new();

        //    temp.AddRange(a.GetRange(a.Count - (k % a.Count), (k % a.Count)));
        //    a.RemoveRange(a.Count - (k % a.Count), (k % a.Count));
        //    temp.AddRange(a);
        //    foreach (var item in queries)
        //    {
        //        result.Add(temp[item]);
        //    }
        //    return result;
        //}
        //circularArrayRotation(new() { 1, 2, 3, 4, 5 }, 3, new() { 1, 2 });
        #region
        //circularArrayRotation(new() { 29261, 80254, 86934, 3704, 76338, 96698, 47885, 88475, 65211, 65976, 75238, 58566, 28684, 20348, 45383, 58620, 48360, 99801, 51885, 82661, 83066, 14311, 24803, 99267, 21541, 93195, 21194, 20775, 64817, 42323, 7640, 10429, 38928, 94573, 30484, 15265, 7622, 78368, 3739, 72833, 60696, 95328, 31398, 5731, 15676, 93132, 64351, 64035, 9284, 32587, 46695, 92349, 46897, 87850, 7968, 84789, 81044, 45513, 5563, 62212, 87836, 13202, 88993, 26763, 24127, 19476, 42028, 31748, 14196, 62118, 4580, 91243, 73798, 52329, 96973, 89473, 61812, 77675, 69859, 71095, 10261, 32905, 79796, 57157, 20754, 87763, 41945, 1798, 33275, 63859, 80361, 37462, 93413, 69353, 64225, 17539, 5181, 22604, 49286, 19376, 1073, 70218, 26970, 74870, 38898, 23942, 80694, 710, 1617, 50552, 88156, 11877, 83457, 67951, 85386, 4210, 55713, 43682, 22359, 5340, 23893, 2720, 59153, 17305, 88424, 23377, 51195, 93604, 62332, 480, 29331, 79757, 87049, 56300, 54626, 25947, 96594, 35320, 26656, 98210, 2223, 31163, 26438, 85679, 99114, 28175, 89889, 71178, 88209, 12247, 76517, 12101, 31318, 35670, 45757, 19742, 75398, 96951, 29697, 54082, 13782, 75380, 33838, 831, 31679, 4815, 26777, 28272, 56486, 69784, 42833, 58709, 946, 85623, 44387, 59, 13797, 50627, 87589, 2005, 62874, 80457, 14105, 94191, 32478, 59861, 30284, 7876, 73163, 59981, 78309, 86945, 35360, 28498, 87775, 83390, 49664, 30903, 28014, 6150, 686, 70846, 81210, 17983, 56468, 41948, 34394, 86617, 92575, 21982, 88621, 71800, 2438, 19078, 82342, 34916, 95290, 12626, 59143, 68453, 88958, 37451, 71749, 24317, 82300, 59523, 24058, 31963, 90425, 52071, 54464, 7462, 39269, 35673, 25444, 12088, 93973, 76189, 98704, 86547, 98170, 3677, 74698, 16960, 22754, 57039, 51875, 34395, 86016, 11017, 19199, 74973, 64819, 90947, 15641, 63470, 66821, 39699, 95432, 73597, 91769, 49896, 81058, 31037, 1920, 22854, 43125, 12244, 99042, 58180, 15142, 13564, 61856, 89839, 30523, 961, 63230, 98749, 51708, 49245, 26117, 70906, 24218, 90935, 78205, 39858, 54404, 45025, 95908, 66187, 34974, 87677, 32434, 32383, 35065, 50706, 55236, 78189, 62949, 70630, 36369, 78091, 545, 14576, 67929, 47419, 15537, 31158, 46167, 67244, 96755, 72283, 54501, 37324, 79569, 32705, 77181, 50324, 94082, 73089, 16510, 45407, 77117, 65296, 77789, 12181, 16001, 49377, 6722, 78949, 36358, 59442, 73391, 36902, 74017, 41320, 84320, 5905, 88829, 46838, 89500, 1935, 19120, 44001, 39258, 98688, 93057, 32791, 49011, 3490, 22231, 81872, 48896, 99347, 47167, 26685, 27879, 79519, 92413, 34600, 74820, 28770, 94041, 48210, 65671, 84410, 5881, 66342, 90314, 11062, 13179, 96166, 12996, 32298, 40166, 52254, 47337, 49574, 85044, 12699, 53064, 7274, 94570, 18311, 22972, 58089, 61347, 50850, 37607, 53759, 1802, 12426, 82528, 12194, 60636, 64550, 96603, 66516, 30891, 3269, 93929, 60421, 99434, 6925, 9070, 55951, 59178, 56406, 5524, 60573, 69104, 74939, 84198, 80026, 93250, 7169, 38114, 54596, 74370, 92072, 24707, 76171, 4498, 7234, 88365, 81485, 71784, 84967, 64352, 19026, 4587, 58281, 79447, 20372, 65205, 88516, 92674, 40734, 44922, 98198, 17658, 30377, 89488, 1855, 10402, 99089, 25375, 64867, 70037, 99744, 56939, 94743, 75915, 77788, 1976, 64279, 75624, 90111, 65597, 39975, 9137, 70184, 98255, 88583, 6907, 79811, 93450, 99581, 36896, 38371, 14130, 54553, 85100, 3617, 72759, 11853, 19058, 98133, 76720, 89094, 97877, 50010, 188, 73791, 44149, 18515, 54421, 19772, 8626, 20017, 59746, 17762, 6552, 74353, 22696, 13459, 70515, 16145, 29391, 7411, 70868, 43520, 78315, 55967, 63488, 51074, 84171, 82545, 49206, 60890, 87990, 63434, 27251, 4529, 53576 }, 100000, new() { 8
        //,323
        //,475
        //,409
        //,330
        //,282
        //,387
        //,133
        //,120
        //,424
        //,193
        //,425
        //,380
        //,99
        //,435
        //,107
        //,396
        //,506
        //,467
        //,64
        //,189
        //,242
        //,315
        //,110
        //,504
        //,396
        //,2
        //,143
        //,44
        //,425
        //,138
        //,52
        //,150
        //,16
        //,379
        //,480
        //,298
        //,251
        //,98
        //,335
        //,77
        //,208
        //,246
        //,457
        //,308
        //,83
        //,50
        //,106
        //,75
        //,434
        //,88
        //,264
        //,161
        //,320
        //,291
        //,150
        //,118
        //,293
        //,210
        //,162
        //,121
        //,266
        //,132
        //,271
        //,282
        //,511
        //,237
        //,497
        //,164
        //,252
        //,317
        //,241
        //,461
        //,480
        //,100
        //,254
        //,49
        //,67
        //,277
        //,124
        //,501
        //,365
        //,305
        //,147
        //,170
        //,81
        //,215
        //,206
        //,292
        //,425
        //,368
        //,413
        //,93
        //,417
        //,169
        //,375
        //,413
        //,323
        //,357
        //,494
        //,61
        //,160
        //,137
        //,7
        //,42
        //,155
        //,178
        //,91
        //,222
        //,455
        //,132
        //,209
        //,223
        //,437
        //,273
        //,310
        //,436
        //,405
        //,1
        //,130
        //,233
        //,287
        //,28
        //,326
        //,189
        //,114
        //,187
        //,5
        //,438
        //,29
        //,416
        //,416
        //,106
        //,39
        //,423
        //,149
        //,194
        //,3
        //,157
        //,416
        //,375
        //,290
        //,27
        //,83
        //,129
        //,218
        //,311
        //,482
        //,108
        //,229
        //,97
        //,341
        //,1
        //,125
        //,70
        //,108
        //,157
        //,257
        //,113
        //,80
        //,203
        //,14
        //,413
        //,310
        //,485
        //,238
        //,376
        //,164
        //,241
        //,18
        //,498
        //,101
        //,225
        //,442
        //,102
        //,355
        //,62
        //,330
        //,322
        //,171
        //,44
        //,337
        //,429
        //,46
        //,462
        //,499
        //,154
        //,21
        //,158
        //,184
        //,18
        //,362
        //,115
        //,431
        //,74
        //,86
        //,154
        //,450
        //,167
        //,312
        //,468
        //,67
        //,331
        //,96
        //,427
        //,433
        //,451
        //,489
        //,165
        //,175
        //,62
        //,209
        //,512
        //,492
        //,172
        //,377
        //,393
        //,243
        //,398
        //,37
        //,427
        //,417
        //,316
        //,460
        //,250
        //,390
        //,463
        //,405
        //,325
        //,115
        //,202
        //,195
        //,100
        //,18
        //,291
        //,12
        //,368
        //,144
        //,501
        //,450
        //,237
        //,481
        //,145
        //,234
        //,375
        //,317
        //,13
        //,253
        //,46
        //,329
        //,207
        //,390
        //,148
        //,8
        //,252
        //,398
        //,315
        //,200
        //,288
        //,125
        //,316
        //,408
        //,238
        //,333
        //,343
        //,446
        //,345
        //,114
        //,76
        //,248
        //,49
        //,230
        //,214
        //,194
        //,381
        //,74
        //,429
        //,395
        //,245
        //,392
        //,209
        //,369
        //,184
        //,357
        //,295
        //,437
        //,240
        //,95
        //,122
        //,446
        //,138
        //,355
        //,256
        //,293
        //,173
        //,84
        //,224
        //,435
        //,198
        //,217
        //,169
        //,165
        //,447
        //,300
        //,276
        //,314
        //,292
        //,190
        //,194
        //,22
        //,499
        //,320
        //,308
        //,169
        //,79
        //,88
        //,91
        //,236
        //,101
        //,130
        //,84
        //,239
        //,486
        //,340
        //,17
        //,144
        //,425
        //,158
        //,497
        //,25
        //,376
        //,151
        //,107
        //,308
        //,451
        //,384
        //,107
        //,228
        //,59
        //,218
        //,167
        //,476
        //,455
        //,476
        //,130
        //,19
        //,481
        //,221
        //,173
        //,67
        //,268
        //,257
        //,223
        //,239
        //,83
        //,157
        //,301
        //,508
        //,316
        //,283
        //,450
        //,177
        //,351
        //,43
        //,402
        //,287
        //,427
        //,427
        //,433
        //,403
        //,130
        //,2
        //,364
        //,71
        //,395
        //,411
        //,7
        //,362
        //,34
        //,180
        //,346
        //,303
        //,438
        //,55
        //,27
        //,6
        //,212
        //,245
        //,431
        //,445
        //,13
        //,283
        //,107
        //,281
        //,243
        //,427
        //,54
        //,155
        //,339
        //,404
        //,476
        //,469
        //,323
        //,242
        //,457
        //,204
        //,139
        //,465
        //,483
        //,90
        //,47
        //,314
        //,393
        //,402
        //,286
        //,338
        //,325
        //,416
        //,68
        //,241
        //,346
        //,514
        //,442
        //,371
        //,280
        //,170
        //,283
        //,251
        //,243
        //,107
        //,57
        //,121
        //,61
        //,381
        //,363
        //,436
        //,502
        //,419
        //,303
        //,387
        //,427
        //,350
        //,186
        //,305
        //,155
        //,390
        //,45
        //,480
        //,291
        //,114
        //,124
        //,122
        //,30
        //,51
        //,493
        //,310
        //,221
        //,261
        //,479
        //,381
        //,368
        //,21
        //,502
        //,347
        //,319
        //,268
        //,268
        //,223
        //,89
        //,56
        //,95
        //,1
        //,323
        //,199
        //,224
        //,478
        //,74
        //,269
        //,444
        //,365
        //,383
        //,53
        //,487
        //,330
        //,21
        //,383
        //,43
        //,242
        //,129
        //,7
        //,109
        //,415
        //,460
        //,13
        //,247
        //,182
        //,281
        //,0
        //,405
        //,371 });
        #endregion//uzun test case
        //ÇÖZÜM DOĞRU 1 TANE TEST CASE RUNTİME ERROR -- HACKOS İLE AÇTIM ÜŞENMİYORSAN KONTROL ET
        //GÜZEL SORUNMUŞ, k büyük bir sayı olduğunda argument out of range hatası veriyor => (k % a.Count)

        // ---------------------------------------------------------------------
        //List<int> permutationEquation(List<int> p)
        //{
        //    var result = new List<int>();

        //    for (int i = 1; i <= p.Count; i++)
        //    {
        //        var placeOfNumber = p.IndexOf(i) + 1;
        //        result.Add(p.IndexOf(placeOfNumber) + 1);
        //    }
        //    return result;
        //}
        //permutationEquation(new() { 4, 3, 5, 1, 2 });


        // ---------------------------------------------------------------------
        //int jumpingOnClouds(int[] c, int k)
        //{
        //    int result = 100;
        //    int position = 0;

        //    while (true)
        //    {
        //        if (position >= c.Length)
        //        {
        //            position = (position) % c.Length;
        //            if (position == 0)
        //                break;
        //        }
        //        if (c[position] == 0)
        //        {
        //            result -= 1;
        //        }
        //        else
        //        {
        //            result -= 3;
        //        }

        //        position += k;
        //    }
        //    return result;
        //}
        ////jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 1, 0 }, 2);
        //jumpingOnClouds(new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 }, 3);


        // ---------------------------------------------------------------------
        //int findDigits(int n)
        //{
        //    int result = 0;

        //    var asd = n.ToString();
        //    asd.
        //    Console.WriteLine(asd.Length);

        //    return 0;
        //}
        //findDigits(123123);

        #region
        //int mevlanaRandom(int[] arr)
        //{
        //    var sortedList = arr.ToList();
        //    sortedList.Sort();

        //    int currentNumberCount = 0;
        //    int currentNumber = sortedList.First();
        //    int mostRepeatedNumber = 0;
        //    int mostRepeatedCount = 0;

        //    foreach (var item in sortedList)
        //    {

        //        if (currentNumber == item)
        //        {
        //            currentNumberCount++;
        //        }

        //        else if (currentNumber != item)
        //        {
        //            currentNumber = item;
        //            currentNumberCount = 1;
        //        }
        //        if (currentNumberCount > mostRepeatedCount)
        //        {
        //            mostRepeatedCount = currentNumberCount;
        //            mostRepeatedNumber = currentNumber;
        //        }

        //    }

        //    if (mostRepeatedCount == 1)
        //    {
        //        return -1;
        //    }
        //    Console.WriteLine(mostRepeatedNumber);
        //    return mostRepeatedNumber;
        //}

        //mevlanaRandom(new int[] { 100, 200, 100, 45, 3 });


        //static void CleanJsonObject(JObject jsonObject){
        //  foreach(var property in jsonObject.Properties().ToList()){
        //if(property.Value.Type == JTokenType.Object){
        //CleanJsonObject((JObject)property.Value);
        //if(!((JObject)property.Value).Properties().Any()){
        //property.Remove();
        //}
        //}
        //else if(property.Value.Type == JTokenType.Array){
        //CleanJsonObject((JArray)property.Value);
        //if(!((Jarray)property.Value).Any()){
        //property.Remove();
        //}
        //}
        //else{
        //  if(property.Value.Type == JTokenType.String && (string)property.Value == "N/A" || (string)property.Value == "-" || string.IsNullOrEmpty((string)property.Value))
        //property.Remove();
        //}
        //  }
        //}

        //static void CleanJsonArray(JArray jsonArray){
        //for(int i = jsonArray.Count -1 ; i >= 0; i--;){
        //  if(jsonArray[i].Type == JTokenType.String && (string)jsonArray[i] == "N/A" || (string)jsonArray[i] == "-" || string.IsNullOrEmpty((string)jsonArray[i])){
        //jsonArray.RemoveAt(i);
        //  }
        //}
        //}
        #endregion

    }
}
