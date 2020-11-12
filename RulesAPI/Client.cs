﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RulesAPI
{
    public class Client
    {
        public HttpClient AccountClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://52.224.198.245");
            return client;
        }
        
        public HttpClient TransactionClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44347");
            return client;
        }
    }
}
