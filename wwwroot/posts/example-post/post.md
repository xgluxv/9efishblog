---
Title: example post
SubTitle: gogogo
Published: 2017-03-09
Tags: blog fun example
Image: pic0.png
---

This post contains source code:

```csharp
internal static void Error(string msg)
{
  var color = Console.ForegroundColor;
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("ERROR: ");
  Console.WriteLine(msg);
  Console.ForegroundColor = color;
}
```

