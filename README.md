# C# Conditions Practice

24 small exercises for practicing C# conditions: `<`, `>`, `<=`, `>=`, `==`, `!=`, `%`, `&&` and `||`. The file has a built-in test runner that checks each answer against sample data.

## Three ways to practice

- **In the browser, JavaScript (fastest):** open [`ConditionsPractice.html`](ConditionsPractice.html). Type each condition in its box and press **Run** (or Enter), or press **Run all**. Results show up instantly, and answers are saved in that browser. The page checks the answers itself in JavaScript. It understands only the parts of C# these problems use: `x`, `y`, whole numbers, `true`/`false`, `+ - * / %`, comparisons, `&& || !` and parentheses. It gives beginner-friendly messages for mistakes such as `=` instead of `==` or `10 <= x <= 20`.
- **In the browser, real C# (WebAssembly):** the app in [`wasm/`](wasm) runs the real C# compiler (Roslyn) inside the browser. Students write the whole method body, so `if`/`else`, local variables, `Math.Abs` and string methods all work. Compiler errors are the real C# messages, with a plain-language tip for common ones. See [Real C# in the browser](#real-c-in-the-browser) below.
- **Real C# file (slowest):** use `ConditionsPractice.cs` in an online C# runner, as described below.

All three have the same 24 problems and test values.

## How to use the C# file

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
| 5 | Two numbers `x` and `y` | 21–24: x greater than y, both even, both odd, both odd or both even |

## For teachers

[`ConditionsPractice_AnswerKey.cs`](ConditionsPractice_AnswerKey.cs) has a sample solution for every problem. It scores 24/24 when run.

## Real C# in the browser

The [`wasm/`](wasm) folder is a Blazor WebAssembly app. It needs the [.NET 8 SDK](https://dotnet.microsoft.com/download) to build, but students only need a browser.

To try it on your own computer:

```bash
cd wasm
dotnet run
```

Then open http://localhost:5236.

What to expect:

- **First load:** the first visit downloads about 5.5 MB (compressed) and takes a few seconds. After that the browser loads it from its cache.
- **Speed:** once it's loaded, compiling and running one problem takes a few hundredths of a second, and **Run all** takes well under a second.
- **Privacy:** nothing is sent to a server. Code is compiled and run in the student's browser, and saved there.
- **Endless loops:** a `while (true)` loop will freeze the page, and reloading fixes it.
- **Available .NET types:** students can use `Math`, `Console`, `string`, `char`, `int` and the other number types. Collections and LINQ aren't available.

To host it for a class, publish it and put the `wwwroot` folder on any static web host, such as GitHub Pages:

```bash
cd wasm
dotnet publish -c Release -o publish
```

If the site lives in a subfolder (for example `https://<user>.github.io/csharp-conditions-practice/`), change `<base href="/" />` in `wasm/wwwroot/index.html` to match that folder.

Publishing removes unused .NET code to make the download smaller. [`wasm/StudentApi.xml`](wasm/StudentApi.xml) lists the .NET types to keep for student code, so add a type there if students need one that's missing.

