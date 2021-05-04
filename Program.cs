﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseAsString = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");

            Console.WriteLine(responseAsString);
        }
    }
}
