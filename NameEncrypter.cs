using System;
using System.Collections.Generic;

public class Test
{
    class NameEncrypter
    {
        string name;
        
        public NameEncrypter(string name)
        {
            this.name = name;
        }
        
        public string encrypt()
        {
            List<char> result = new List<char>();
            
            foreach(byte b in System.Text.Encoding.UTF8.GetBytes(this.name.ToCharArray()))
            {
                int i = int.Parse(b.ToString());
                char c = (char)(i+1);
                result.Add(c);
            }
            
            return new string(result.ToArray());
        }

        public static string decrypt(string value)
        {
            List<char> result = new List<char>();
            
            foreach(byte b in System.Text.Encoding.UTF8.GetBytes(value.ToCharArray()))
            {
                int i = int.Parse(b.ToString());
                char c = (char)(i-1);
                result.Add(c);
            }
            
            return new string(result.ToArray());
        }
    }
    
    public static void Main()
    {
        NameEncrypter ne = new NameEncrypter("Rob");
        string encrypted = ne.encrypt();
        string decrypted = NameEncrypter.decrypt(encrypted);
        Console.WriteLine(encrypted);
        Console.WriteLine(decrypted);
    }
}