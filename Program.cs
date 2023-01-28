using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        public static List<DataRoom> GetBooks()
        {
            List<DataRoom> lstForValue = new List<DataRoom>()
            {
                 new DataRoom(){ DataRoomId = 1, Value="Mrs P Willaims"},
                 new DataRoom(){ DataRoomId = 1, Value="NULL"},
                 new DataRoom(){ DataRoomId = 1, Value="NULL"},
                 new DataRoom(){ DataRoomId = 1, Value="NULL"},
                 new DataRoom(){ DataRoomId = 2, Value="NULL"},
                 new DataRoom(){ DataRoomId = 2, Value="NULL"},
                 new DataRoom(){ DataRoomId = 2, Value="NULL"},
                 new DataRoom(){ DataRoomId = 2, Value="NULL"},
                 new DataRoom(){ DataRoomId = 3, Value="NULL"},
                 new DataRoom(){ DataRoomId = 3, Value="02/08/2022"},
                 new DataRoom(){ DataRoomId = 3, Value="TEST CLAIMANT"},
                 new DataRoom(){ DataRoomId = 3, Value="02/08/2022"},
                 new DataRoom(){ DataRoomId = 4, Value="NULL"},
                 new DataRoom(){ DataRoomId = 4, Value="NULL"},
                 new DataRoom(){ DataRoomId = 4, Value="TEST CLAIMANT 23"},
                 new DataRoom(){ DataRoomId = 4, Value="02/08/2022 00:000"},
                 new DataRoom(){ DataRoomId = 5, Value="Mrs P Willaims"},
                 new DataRoom(){ DataRoomId = 5, Value="NULL"},
                 new DataRoom(){ DataRoomId = 5, Value="NULL"},
                 new DataRoom(){ DataRoomId = 5, Value="NULL"},
                 new DataRoom(){ DataRoomId = 6, Value="NULL"},
                 new DataRoom(){ DataRoomId = 6, Value="NULL"},
                 new DataRoom(){ DataRoomId = 6, Value="NULL"},
                 new DataRoom(){ DataRoomId = 6, Value="NULL"},
                 new DataRoom(){ DataRoomId = 7, Value="NULL"},
                 new DataRoom(){ DataRoomId = 7, Value="02/08/2022"},
                 new DataRoom(){ DataRoomId = 7, Value="TEST CLAIMANT"},
                 new DataRoom(){ DataRoomId = 7, Value="02/08/2022"},
                 new DataRoom(){ DataRoomId = 8, Value="NULL"},
                 new DataRoom(){ DataRoomId = 8, Value="NULL"},
                 new DataRoom(){ DataRoomId = 8, Value="TEST CLAIMANT 23"},
                 new DataRoom(){ DataRoomId = 8, Value="02/08/2022 00:000"},
            };
            return lstForValue;

        }

        public static void Main(string[] args)
        {
            var nullValues = GetBooks().Where(r => r.Value == "NULL" && r.DataRoomId == 2 || r.DataRoomId == 6 ).GroupBy(r => r.DataRoomId).Select(t => t.First()).ToList();

            var distinct = GetBooks().Where(r => r.Value != "NULL").GroupBy(s => s.DataRoomId).Select(t => t.First()).ToList();

            distinct.AddRange(nullValues);
            
            foreach (var item in distinct)
            {
                Console.WriteLine(item.Value);         
            }
            Console.ReadKey();
        }

    }
}
