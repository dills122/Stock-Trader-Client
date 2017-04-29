using NewStockClient.Global_Functions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NewStockClient
{
    class Network
    {

        public static TcpClient ConnectTCP()
        {
            try
            {
                TcpClient connection = new TcpClient(GetLocalIPAddress(), 8080);
                Debug.Write("Connected to Server");
                return connection;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }


        private static string CreateTraderJSONObj(int Amount, double Price, string Method)
        {
            dynamic trading = new JObject();
            trading.Price = Price;
            trading.Amt = Amount;
            trading.Method = Method;
            string JsonStr = trading.ToString();
            return JsonStr;
        }

        private void SendObject(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            BinaryWriter writer = new BinaryWriter(ns);

            writer.Write(Encryption.Encrypt(CreateTraderJSONObj(500, 5.5, "T"), "pinapple"));
            writer.Close();
        }
    }
}
