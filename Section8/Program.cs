using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace Dubugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Irgo", "Sarah", "Ramon", "Juris", "Teyvat", "Parte", "Rofriguin", "Rui", "Zuzu"};
            var partyFriends = GetPartyFriends(friends, 11);
            foreach(var i in partyFriends)
            {
                Console.WriteLine(i + "\n");
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if(list == null)
                throw new ArgumentNullException("list", "The list is empty, try checking your internet connection");
            
            if(count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater then the element in the list or lower 0.");

            var buffer = new List<string>(list); 
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriends(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;

        }

        public static string GetPartyFriends(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }

            }
            return shortestName;
        }
    }
}
    