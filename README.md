# C# Conditions Practice

20 small exercises for practicing C# conditions: `<`, `>`, `<=`, `>=`, `==`, `!=`, `%`, `&&` and `||`. The file has a built-in test runner that checks each answer against sample data.

## How to use

1. Open [`ConditionsPractice.cs`](ConditionsPractice.cs) and copy all of it.
2. Paste it into an online C# runner such as [.NET Fiddle](https://dotnetfiddle.net) or [OnlineGDB](https://www.onlinegdb.com/online_csharp_compiler).
3. In each problem, replace the word `TODO` with your condition:

   ```csharp
   static bool P01(int x)
   {
       return x < 10;
   }
   ```

4. Press **Run**. For every test value you'll see the expected answer, what your code returned, and `OK` or `<-- WRONG`. A score is printed at the end.

You don't have to finish all the problems at once. Problems you haven't started yet show "not done yet."

## The problems

| Level | Topic | Problems |
|---|---|---|
| 1 | Comparisons | 1–6: less than 10, greater than 100, at least 18, zero or negative, exactly 7, not zero |
| 2 | Modulo `%` | 7–9: even, odd (watch out for negative numbers!), divisible by 5 |
| 3 | `&&` and `\|\|` | 10–15: ranges, outside a range, even and positive, divisible by 3 or 5, divisible by both, two-digit numbers |
| 4 | Digits | 16–20: ends in 7, in the 70s, both digits the same, 7 Boom!, contains the digit 3 |

## For teachers

[`ConditionsPractice_AnswerKey.cs`](ConditionsPractice_AnswerKey.cs) has a sample solution for every problem. It scores 20/20 when run.
