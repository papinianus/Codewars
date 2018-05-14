using System;
using System.Linq;
using System.Collections.Generic;

public class KanaKonverter
{
  public static string vowels (string input, string output) => output == "hiragana" ? string.Concat(input.Select(x=>ToHiragana[x])): output == "katakana" ? string.Concat(input.Select(x=>ToKatakana[x])) : string.Concat(input.Select(x=>ToRomaji[x])) ;
  {
    string romajiDictLow = "aeiou";
    string romajiDictUp  = "AEIOU";
    string hiraDict      = "あえいおう";
    string kataDict      = "アエイオウ";

    //todo
    
    return "";
  }
  private static Dictionary<char, char> ToRomaji = new Dictionary<char, char> {{'a','a'},{'e','e'},{'i','i'},{'o','o'},{'u','u'},{'A','A'},{'E','E'},{'I','I'},{'O','O'},{'U','U'},{'あ','a'},{'え','e'},{'い','i'},{'お','o'},{'う','u'},{'ア','a'},{'エ','e'},{'イ','i'},{'オ','o'},{'ウ','u'},};
  private static Dictionary<char, char> ToHiragana = new Dictionary<char, char> {{'a','あ'},{'e','え'},{'i','い'},{'o','お'},{'u','う'},{'A','あ'},{'E','え'},{'I','い'},{'O','お'},{'U','う'},{'あ','あ'},{'え','え'},{'い','い'},{'お','お'},{'う','う'},{'ア','あ'},{'エ','え'},{'イ','い'},{'オ','お'},{'ウ','う'},};
  private static Dictionary<char, char> ToKatakana = new Dictionary<char, char> {{'a','ア'},{'e','エ'},{'i','イ'},{'o','オ'},{'u','ウ'},{'A','ア'},{'E','エ'},{'I','イ'},{'O','オ'},{'U','ウ'},{'あ','ア'},{'え','エ'},{'い','イ'},{'お','オ'},{'う','ウ'},{'ア','ア'},{'エ','エ'},{'イ','イ'},{'オ','オ'},{'ウ','ウ'},};
}

namespace Solution
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class KataTest
    {
    
    [Test] public void romajiToHira() 
        {Assert.AreEqual("あえいおう", KanaKonverter.vowels("aeiou", "hiragana"));}
    [Test] public void romajiToKata() 
        {Assert.AreEqual("アエイオウ", KanaKonverter.vowels("aeiou", "katakana"));}
    [Test] public void romajiToRomaji() 
        {Assert.AreEqual("aeiou", KanaKonverter.vowels("aeiou", "romaji"));}
        
    [Test] public void hiraToHira() 
        {Assert.AreEqual("あえいおう", KanaKonverter.vowels("あえいおう", "hiragana"));}
    [Test] public void hiraToKata() 
        {Assert.AreEqual("アエイオウ", KanaKonverter.vowels("あえいおう", "katakana"));}
    [Test] public void hiraToRomaji() 
        {Assert.AreEqual("aeiou", KanaKonverter.vowels("あえいおう", "romaji"));}
        
    [Test] public void kataToHira() 
        {Assert.AreEqual("あえいおう", KanaKonverter.vowels("アエイオウ", "hiragana"));}
    [Test] public void kataToKata() 
        {Assert.AreEqual("アエイオウ", KanaKonverter.vowels("アエイオウ", "katakana"));}
    [Test] public void kataToRomaji() 
        {Assert.AreEqual("aeiou", KanaKonverter.vowels("アエイオウ", "romaji"));} 
    
    [Test] public void noInput() 
        {Assert.AreEqual("", KanaKonverter.vowels("", "romaji"));}  
    [Test] public void emptyParameters() 
        {Assert.AreEqual("", KanaKonverter.vowels("", ""));}  
        
    [Test] public void Uppercase() 
        {Assert.AreEqual("aAeEoOUu", KanaKonverter.vowels("aAeEoOUu", "romaji"));}  
    
    }
}