using System.Collections;
using Session4Demo.Fifa;
using Session4Demo.Youtube;

namespace Session4Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Event-Driven

            //Event-Driven Overview

            #region Ex01
            //Ball ball = new Ball() { Id = 1 };

            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            //Player P01 = new Player() { Name = "Messi", TeamName = "Miami" };
            //Player P02 = new Player() { Name = "Alba", TeamName = "Miami" };

            //Player P03 = new Player() { Name = "Pedri", TeamName = "Barcelona" };
            //Player P04 = new Player() { Name = "Gavi", TeamName = "Barcelona" };
            //Player P05 = new Player() { Name = "Mohamed Salah", TeamName = "Barcelona" };

            //Refree refree = new Refree() { Name = "Ebrahim Nour Eldeen" };
            //Coach coach = new Coach() { Name = "Flek" , TeamName = "Barcelona" };

            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            ////ball.players.Add(P01);
            ////ball.players.Add(P02);
            ////ball.players.Add(P03);
            ////ball.players.Add(P04);
            ////ball.Refree.Add(refree);


            //ball.BallLocationChange = P01.Run;
            //ball.BallLocationChange += P02.Run;
            //ball.BallLocationChange += P03.Run;
            //ball.BallLocationChange += P04.Run;
            //ball.BallLocationChange += refree.Look;
            //ball.BallLocationChange += coach.Order;


            //ball.Location = new Location() { X = 2, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            //Console.WriteLine();
            //Console.WriteLine("After change pedri with salah");
            //Console.WriteLine();

            //ball.BallLocationChange -= P03.Run;
            //ball.BallLocationChange += P05.Run;

            //ball.Location = new Location() { X = 3, Y = 1, Z = 1 };
            //Console.WriteLine(ball);
            #endregion

            #region EX02
            //Channel channel = new Channel() { Title = "ABC" };

            //channel.AddVideo(new Video() { Title = "Title01", Description = "Desc01" });

            //Subscriber S01 = new Subscriber() { Name = "Ahmed"}; 
            //Subscriber S02 = new Subscriber() { Name = "Ali"}; 
            //Subscriber S03 = new Subscriber() { Name = "Noura"}; 
            //Subscriber S04 = new Subscriber() { Name = "Dina"}; 
            //Subscriber S05 = new Subscriber() { Name = "Rana"};

            //channel.AddVideo(new Video() { Title = "Title02", Description = "Desc02" });

            //channel.Uploaded += S01.notify;
            //channel.Uploaded += S02.notify;
            //channel.Uploaded += S03.notify;
            //channel.Uploaded += S04.notify;

            //channel.AddVideo(new Video() { Title = "Title02", Description = "Desc02" });

            //Console.WriteLine();
            //Console.WriteLine("After Ahmed Unsubscribe");
            //Console.WriteLine();

            //channel.Uploaded -= S01.notify;
            //channel.Uploaded += S05.notify;

            //channel.AddVideo(new Video() { Title = "Title03", Description = "Desc03" }); 
            #endregion


            //Collection : Built-in DS in c#

            //Hashtables:
            //Key,Value
            //Non-Generic Hadhtables
            //Generic Hadhtables


            #region Non-Generic Hadhtables : Hashtable 
            //Non-Generic Hadhtables : Hashtable 
            //Hashtable hashtable = new Hashtable();

            //hashtable.Add("Noura" , 010344483);
            //hashtable.Add("Ahmed" , 0292922);
            //hashtable.Add("Ali" , 282282);
            //hashtable.Add("Dina" , 1818181);//valid
            //hashtable.Add("Ali" , 1818181); //Eexception

            ////foreach (var item in hashtable.Values)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////foreach (var item in hashtable.Keys)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////Console.WriteLine(hashtable["Ahmed"]);


            ////hashtable.Clear();

            ////Console.WriteLine(hashtable.Count);


            ////bool flag =hashtable.Contains("Ahmed");
            ////bool flag =hashtable.ContainsKey("Ahmed");
            ////Console.WriteLine(flag);

            ////hashtable.Remove("Ahemd");

            ////foreach (DictionaryEntry item in hashtable)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            #endregion

            #region Generic hashtable
            //Generic hashtable

            //Dictionary<string,long> pairs = new Dictionary<string,long>();
            //pairs.Add("Ahmed",00292282);
            //pairs.Add("Ali",00292282);
            //pairs.Add("Omar",00292282);

            ////pairs["Ahmed"] = 123333;

            ////var flag= pairs.TryAdd("dash", 11111);
            ////Console.WriteLine(flag);

            //var flag = pairs.TryGetValue("Ahmed", out long result);
            //Console.WriteLine(flag);
            //Console.WriteLine(result);


            //foreach (KeyValuePair<string,long> item in pairs)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region HashSet
            ////HashSet

            ////Hahtables

            //HashSet<string> set = new HashSet<string>();

            //set.Add("Ahmed");
            //set.Add("Ahmed");
            //set.Add("Ahmed");



            //foreach (var item in set)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedDictionary
            //SortedDictionary<int,string> pairs = new SortedDictionary<int,string>();

            //pairs.Add(12, "Ahmed");
            //pairs.Add(10, "Ali");
            //pairs.Add(11, "Omar");
            //pairs.Add(-1, "Mohamed");


            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedList
            //SortedList<int, string> pairs = new SortedList<int, string>();
            ////pairs.SetValueAtIndex(1);

            //pairs.Add(1, "Ahmed");
            //pairs.Add(2, "Ali");
            //pairs.Add(3, "Noura");
            #endregion

            #region SortedSet
            //SortedSet<string> pairs = new SortedSet<string>();
            //pairs. 
            #endregion
        }
    }
}
