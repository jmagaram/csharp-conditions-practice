using System;

class Program
{
    // ===================================================================
    //   CONDITIONS PRACTICE  -  24 problems
    //
    //   Each problem is a method that gets a number x (or two numbers,
    //   x and y, in Level 5) and must answer
    //   true or false.  Replace the word TODO with your condition.
    //
    //   Example:   return TODO;     becomes     return x > 5;
    //
    //   Press Run and scroll down to see which tests passed.
    //   You don't have to do them all at once - unfinished problems
    //   just show "not done yet".
    // ===================================================================

    // -------------------------------------------------------------------
    //   LEVEL 1: Comparisons   <   >   <=   >=   ==   !=
    // -------------------------------------------------------------------

    // 1. Is x less than 10?
    static bool P01(int x)
    {
        return x < 10;
    }

    // 2. Is x greater than 100?
    static bool P02(int x)
    {
        return x > 100;
    }

    // 3. Is x at least 18? (old enough to vote)
    static bool P03(int x)
    {
        return x >= 18;
    }

    // 4. Is x zero or negative?
    static bool P04(int x)
    {
        return x <= 0;
    }

    // 5. Is x exactly 7?
    static bool P05(int x)
    {
        return x == 7;
    }

    // 6. Is x NOT zero?
    static bool P06(int x)
    {
        return x != 0;
    }

    // -------------------------------------------------------------------
    //   LEVEL 2: Modulo  %  (the remainder after dividing)
    //   10 % 3 == 1     because 10 = 3*3 + 1
    //   12 % 4 == 0     because 4 divides 12 exactly
    // -------------------------------------------------------------------

    // 7. Is x even?
    static bool P07(int x)
    {
        return x % 2 == 0;
    }

    // 8. Is x odd?  (careful: try negative numbers!)
    static bool P08(int x)
    {
        return x % 2 != 0;
    }

    // 9. Is x divisible by 5?
    static bool P09(int x)
    {
        return x % 5 == 0;
    }

    // -------------------------------------------------------------------
    //   LEVEL 3: AND  &&   and   OR  ||
    //   a && b  is true only when BOTH are true
    //   a || b  is true when AT LEAST ONE is true
    // -------------------------------------------------------------------

    // 10. Is x between 10 and 20? (10 and 20 count)
    static bool P10(int x)
    {
        return x >= 10 && x <= 20;
    }

    // 11. Is x OUTSIDE the range 1 to 100?
    static bool P11(int x)
    {
        return x < 1 || x > 100;
    }

    // 12. Is x even AND positive?
    static bool P12(int x)
    {
        return x % 2 == 0 && x > 0;
    }

    // 13. Is x divisible by 3 OR by 5?
    static bool P13(int x)
    {
        return x % 3 == 0 || x % 5 == 0;
    }

    // 14. Is x divisible by BOTH 3 and 5?
    static bool P14(int x)
    {
        return x % 3 == 0 && x % 5 == 0;
    }

    // 15. Is x a positive two-digit number? (10 to 99)
    static bool P15(int x)
    {
        return x >= 10 && x <= 99;
    }

    // -------------------------------------------------------------------
    //   LEVEL 4: Digits  (all numbers here are positive)
    //   x % 10        gives the LAST digit       (347 % 10 == 7)
    //   x / 10        removes the last digit     (347 / 10 == 34)
    //   x / 10 % 10   gives the TENS digit       (347 / 10 % 10 == 4)
    //   x / 100       gives the HUNDREDS digit   (347 / 100 == 3, for x < 1000)
    // -------------------------------------------------------------------

    // 16. Does x end with the digit 7?
    static bool P16(int x)
    {
        return x % 10 == 7;
    }

    // 17. Is x a two-digit number in the 70s? (70 to 79)
    static bool P17(int x)
    {
        return x / 10 == 7;
    }

    // 18. Is x a two-digit number with both digits the same? (11, 22, ...)
    static bool P18(int x)
    {
        return x / 10 == x % 10;
    }

    // 19. 7 BOOM! (x from 1 to 99) Is x divisible by 7, OR ends with 7, OR in the 70s?
    static bool P19(int x)
    {
        return x % 7 == 0 || x % 10 == 7 || x / 10 == 7;
    }

    // 20. Does x contain the digit 3 anywhere? (x from 0 to 999)
    static bool P20(int x)
    {
        return x % 10 == 3 || x / 10 % 10 == 3 || x / 100 == 3;
    }

    // -------------------------------------------------------------------
    //   LEVEL 5: Two numbers  x  and  y
    //   Now the method gets TWO numbers. Use both of them in your condition.
    // -------------------------------------------------------------------

    // 21. Is x greater than y?
    static bool P21(int x, int y)
    {
        return x > y;
    }

    // 22. Are x and y BOTH even?
    static bool P22(int x, int y)
    {
        return x % 2 == 0 && y % 2 == 0;
    }

    // 23. Are x and y BOTH odd?  (careful: try negative numbers!)
    static bool P23(int x, int y)
    {
        return x % 2 != 0 && y % 2 != 0;
    }

    // 24. Are x and y both odd OR both even?
    static bool P24(int x, int y)
    {
        return (x % 2 == 0 && y % 2 == 0) || (x % 2 != 0 && y % 2 != 0);
    }

    // ===================================================================
    //   DO NOT CHANGE ANYTHING BELOW THIS LINE
    // ===================================================================

    static bool TODO { get { throw new NotImplementedException(); } }

    static int solved = 0;
    static string notDone = "";
    static string needWork = "";

    static void Check(int number, string question, Func<int, bool> method,
                      int[] inputs, bool[] expected)
    {
        RunTests(number, question, inputs.Length,
                 i => method(inputs[i]),
                 i => "x = " + inputs[i].ToString().PadRight(6),
                 expected);
    }

    static void Check(int number, string question, Func<int, int, bool> method,
                      int[] xs, int[] ys, bool[] expected)
    {
        RunTests(number, question, xs.Length,
                 i => method(xs[i], ys[i]),
                 i => "x = " + xs[i].ToString().PadRight(5) + " y = " + ys[i].ToString().PadRight(5),
                 expected);
    }

    static void RunTests(int number, string question, int count,
                         Func<int, bool> runTest, Func<int, string> describe,
                         bool[] expected)
    {
        Console.WriteLine("Problem " + number + ": " + question);
        int correct = 0;
        for (int i = 0; i < count; i++)
        {
            bool got;
            try
            {
                got = runTest(i);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("   not done yet");
                Console.WriteLine();
                notDone += " " + number;
                return;
            }
            string line = "   " + describe(i)
                        + " expected: " + expected[i].ToString().PadRight(6)
                        + " your code: " + got.ToString().PadRight(6);
            if (got == expected[i])
            {
                correct++;
                Console.WriteLine(line + " OK");
            }
            else
            {
                Console.WriteLine(line + " <-- WRONG");
            }
        }
        if (correct == count)
        {
            solved++;
            Console.WriteLine("   ALL " + correct + " CORRECT!");
        }
        else
        {
            needWork += " " + number;
            Console.WriteLine("   " + correct + " of " + count + " correct - keep trying");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Check(1, "Is x less than 10?", P01,
            new int[]  { 3, 9, 10, 11, -5, 0, 100 },
            new bool[] { true, true, false, false, true, true, false });
        Check(2, "Is x greater than 100?", P02,
            new int[]  { 50, 99, 100, 101, 500, -200 },
            new bool[] { false, false, false, true, true, false });
        Check(3, "Is x at least 18? (old enough to vote)", P03,
            new int[]  { 12, 17, 18, 19, 40, 0 },
            new bool[] { false, false, true, true, true, false });
        Check(4, "Is x zero or negative?", P04,
            new int[]  { 5, 1, 0, -1, -100 },
            new bool[] { false, false, true, true, true });
        Check(5, "Is x exactly 7?", P05,
            new int[]  { 7, 6, 8, 70, 17, -7 },
            new bool[] { true, false, false, false, false, false });
        Check(6, "Is x NOT zero?", P06,
            new int[]  { 0, 1, -1, 99, 10 },
            new bool[] { false, true, true, true, true });
        Check(7, "Is x even?", P07,
            new int[]  { 4, 7, 0, 100, 13, -6 },
            new bool[] { true, false, true, true, false, true });
        Check(8, "Is x odd?  (careful: try negative numbers!)", P08,
            new int[]  { 3, 8, 0, 99, -3, -4, -11 },
            new bool[] { true, false, false, true, true, false, true });
        Check(9, "Is x divisible by 5?", P09,
            new int[]  { 10, 12, 0, 35, 51, 5, 4 },
            new bool[] { true, false, true, true, false, true, false });
        Check(10, "Is x between 10 and 20? (10 and 20 count)", P10,
            new int[]  { 9, 10, 15, 20, 21, 0, 100 },
            new bool[] { false, true, true, true, false, false, false });
        Check(11, "Is x OUTSIDE the range 1 to 100?", P11,
            new int[]  { 0, 1, 50, 100, 101, -5, 500 },
            new bool[] { true, false, false, false, true, true, true });
        Check(12, "Is x even AND positive?", P12,
            new int[]  { 4, 3, 0, -4, 10, 7, -3 },
            new bool[] { true, false, false, false, true, false, false });
        Check(13, "Is x divisible by 3 OR by 5?", P13,
            new int[]  { 9, 10, 15, 7, 22, 25, 1 },
            new bool[] { true, true, true, false, false, true, false });
        Check(14, "Is x divisible by BOTH 3 and 5?", P14,
            new int[]  { 15, 9, 10, 30, 7, 45, 50 },
            new bool[] { true, false, false, true, false, true, false });
        Check(15, "Is x a positive two-digit number? (10 to 99)", P15,
            new int[]  { 9, 10, 55, 99, 100, -50, 5 },
            new bool[] { false, true, true, true, false, false, false });
        Check(16, "Does x end with the digit 7?", P16,
            new int[]  { 7, 17, 70, 127, 71, 1007, 8 },
            new bool[] { true, true, false, true, false, true, false });
        Check(17, "Is x a two-digit number in the 70s? (70 to 79)", P17,
            new int[]  { 69, 70, 75, 79, 80, 7, 77 },
            new bool[] { false, true, true, true, false, false, true });
        Check(18, "Is x a two-digit number with both digits the same? (11, 22, ...)", P18,
            new int[]  { 33, 34, 99, 10, 77, 11, 12, 90 },
            new bool[] { true, false, true, false, true, true, false, false });
        Check(19, "7 BOOM! (x from 1 to 99) Is x divisible by 7, OR ends with 7, OR in the 70s?", P19,
            new int[]  { 1, 7, 14, 17, 22, 49, 50, 70, 71, 77, 80, 91, 97 },
            new bool[] { false, true, true, true, false, true, false, true, true, true, false, true, true });
        Check(20, "Does x contain the digit 3 anywhere? (x from 0 to 999)", P20,
            new int[]  { 3, 13, 31, 130, 305, 300, 333, 123, 444, 100, 0, 999, 38 },
            new bool[] { true, true, true, true, true, true, true, true, false, false, false, false, true });
        Check(21, "Is x greater than y?", P21,
            new int[]  { 5, 3, 4, -1, 0, 100, -8 },
            new int[]  { 3, 5, 4, -2, 10, 99, -3 },
            new bool[] { true, false, false, true, false, true, false });
        Check(22, "Are x and y BOTH even?", P22,
            new int[]  { 2, 2, 3, 3, 0, 10, -4 },
            new int[]  { 4, 3, 2, 5, -6, 7, 8 },
            new bool[] { true, false, false, false, true, false, true });
        Check(23, "Are x and y BOTH odd?  (careful: try negative numbers!)", P23,
            new int[]  { 3, 3, 4, 2, -3, -1, 0 },
            new int[]  { 5, 4, 3, 6, 7, -1, 1 },
            new bool[] { true, false, false, false, true, true, false });
        Check(24, "Are x and y both odd OR both even?", P24,
            new int[]  { 2, 3, 2, 3, 0, -3, -4, 10, 7 },
            new int[]  { 4, 5, 3, 2, 0, 5, 7, -1, -9 },
            new bool[] { true, true, false, false, true, true, false, false, true });

        Console.WriteLine("===================================");
        Console.WriteLine("  SCORE: " + solved + " of 24 problems solved");
        if (needWork != "") Console.WriteLine("  Needs work:  " + needWork);
        if (notDone != "")  Console.WriteLine("  Not done yet:" + notDone);
        if (solved == 24)   Console.WriteLine("  PERFECT! Every problem is correct!");
        Console.WriteLine("===================================");
    }
}
