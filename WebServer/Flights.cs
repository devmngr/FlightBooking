using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer
{

    public class Flights
    {

        string[][] flights = new string[5580][];
        int index = 0;


        public void generate(DateTime departure, DateTime arrival)
        {

            string current = departure.ToShortDateString();
            string next = arrival.ToShortDateString();


            string[] str1 = { "Billund", "Hamburg", "one-way", current, next };
            flights[index] = str1;
            index++;

            string[] str2 = { "Copenhagen", "Aalborg", "one-way", current, next };
            flights[index] = str2;
            index++;
            string[] str3 = { "Aalborg", "Munchen", "one-way", current, next };
            flights[index] = str3;
            index++;
            string[] str4 = { "Paris", "Amsterdam", "one-way", current, next };
            flights[index] = str4;
            index++;
            string[] str5 = { "London", "Prag", "one-way", current, next };
            flights[index] = str5;
            index++;
            string[] str6 = { "Berlin", "Aalborg", "one-way", current, next };
            flights[index] = str6;
            index++;
            string[] str7 = { "Billund", "Hamburg", "round-trip", current, next };
            flights[index] = str7;
            index++;
            string[] str8 = { "Copenhagen", "Aalborg", "round-trip", current, next };
            flights[index] = str8;
            index++;
            string[] str9 = { "Aalborg", "Munchen", "round-trip", current, next };
            flights[index] = str9;
            index++;
            string[] str10 = { "Paris", "Amsterdam", "round-trip", current, next };
            flights[index] = str10;
            index++;
            string[] str11 = { "London", "Prag", "round-trip", current, next };
            flights[index] = str11;
            index++;
            string[] str12 = { "Berlin", "Aalborg", "round-trip", current, next };
            flights[index] = str12;
            index++;

        }

        public void generateAll()
        {
            DateTime current = DateTime.Now;

            for (int i = 0; i < 30; i++)
                for (int j = i + 1; j <= 30; j++)
                {
                    generate(current.AddDays(i), current.AddDays(j));
                }
        }

        public string[][] getAllFlights()
        {
            generateAll();

            return flights;
        }


        public string[] getFlights()
        {
            generateAll();
            int idx = 0;

            string[] arr = new string[(flights.Length * flights[0].Length)];
            for (int i = 0; i < flights.Length; i++)
                for (int j = 0; j < flights[0].Length; j++)
                {
                    arr[idx] = flights[i][j];
                    idx++;
                }
            return arr;
        }









    }
}