using System;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Threading;

namespace Magic8Ball
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string appversion = "v2.1.0";
            bool StringIsNotM8BQuestion = false;
            DateTime today = DateTime.Today;
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Program.Setup();
            Console.Clear();
            Program.Setup2();
            Console.ForegroundColor = foregroundColor;
            Random random = new Random();
            bool flag = false;
            while (true)
            {
                string NNDay = "12/14/2017";
                DateTime nnday = Convert.ToDateTime(NNDay);
                bool flag26 = !flag;
                if( flag26)
                {
                    bool flag27 = today == nnday;
                    if(flag27)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Today is the final fight for Net Neutrality in 2017");
                        Console.WriteLine("DO NOT LET ANYTHING STAND IN THE WAY OF YOUR FIGHT!");
                        Console.WriteLine();
                        flag = true;
                    }
                }

                string AprilFools = "4/01";
                DateTime d = Convert.ToDateTime(AprilFools);

                bool flag2 = !flag;
                if (flag2)
                {
                    bool flag3 = today == d;
                    if (flag3)
                    {
                        Program.rickroll();
                        flag = true;
                        Console.WriteLine("You got rickrolled (in the original YouTube sense). Happy April Fools!");
                    }
                }
                string text = Program.ua();
                Console.ForegroundColor = ConsoleColor.Red;
                int num = random.Next(5) + 1;
                ConsoleColor foregroundColor2 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (random.Next(4))
                {
                    case 0:
                        Console.WriteLine("Thinking...");
                        break;
                    case 1:
                        Console.WriteLine("Aligning stars...");
                        break;
                    case 2:
                        Console.WriteLine("Contacting mages...");
                        break;
                    case 3:
                        Console.WriteLine("Deciphering the universe...");
                        break;
                }
                Thread.Sleep(num * 1000);
                Console.ForegroundColor = foregroundColor2;

                // This is where the process of determining the proper response to user input begins.
                // It will first compare the user string to that of those with predefined separate actions.
                // If the uuser's input does not correlate with any of these, the response will be one of the
                // Magic 8 Ball's random answers.

                bool flag25 = text.ToLower() == "long live";
                if(flag25)
                {
                    Console.WriteLine("LONG LIVE SEAN PATRICK MALONEY!!");
                    StringIsNotM8BQuestion = true;
                }

                bool flag24 = text.ToLower() == "69";
                if( flag24)
                {
                    Console.WriteLine("Best number in the universe!");
                    speechSynthesizer.Speak("Best number in the universe!");
                    StringIsNotM8BQuestion = true;
                }

                bool flag23 = text.ToLower() == "version";
                if( flag23)
                {
                    Console.WriteLine(appversion);
                    speechSynthesizer.Speak("You are currently using version" + appversion + "of Levi's Magic 8 Ball");
                    StringIsNotM8BQuestion = true;
                }

                bool flag22 = text.ToLower() == "oh dear lord";
                if (flag22)
                {
                    // Jukebox: plays "XTC - Dear God"
                    Console.WriteLine("What lord?");
                    speechSynthesizer.Speak("What lord?");
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=IHmTqoLjlXo"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }

                bool flag21 = text.ToLower() == "animals wearing clothes";
                if (flag21)
                {
                    // Jukebox: Plays "The Deadly Syndrome - Animals Wearing Clothes"
                    Console.WriteLine("This was poorly planned, and executed twice as bad...");
                    speechSynthesizer.Speak("This was poorly planned, and executed twice as bad...");
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=u6ENZhap-PY"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }

                bool flag20 = text.ToLower() == "spin me round";
                if (flag20)
                {
                    // Jukebox: Plays "Dead or Alive - You Spin Me Round (Like a Record)"
                    Console.WriteLine("You spin me round round baby round round like a record baby right round round round.");
                    speechSynthesizer.Speak("You spin me round round baby round round like a record baby right round round round.");
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=PGNiXGX2nLU"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }

                bool flag19 = text.ToLower() == "enjoy yourself";
                if (flag19)
                {
                    // Jukebox: Plays "SAINT PEPSI - Enjoy Yourself"
                    Console.WriteLine("I've been doing that for a long time now, and I think it's time for you to get a chance at enjoying yourself!");
                    speechSynthesizer.Speak("I've been doing that for a long time now, and I think it's time for you to get a chance at enjoying yourself!");
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=_hI0qMtdfng"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }
                bool flag18 = text.ToLower() == "what's in the cut?";
                if (flag18)
                {
                    // Jukebox: Plays "K. Flay - Blood In The Cut (Official Video)"
                    Console.WriteLine("Blood is in the cut, of course. As is with all cuts, mental and physical.");
                    speechSynthesizer.Speak("Blood is in the cut, of course. As is with all cuts, mental and physical.");

                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=k2WcOdz96ko"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }
                bool flag17 = text.ToLower() == "give me something to believe in";
                if (flag17)
                {
                    // Jukebox: Plays "Young The Giant - Something To Believe In (Official Video)"
                    Console.WriteLine("Okay, I'll try. It's going to be difficult if you are an Atheist and against Trump, though.");
                    speechSynthesizer.Speak("Okay, I'll try. It's going to be difficult if you are an atheist and against Trump, though.");
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=m_ZRWZv14SA"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }
                bool flag16 = text.ToLower() == "make me a believer";
                if (flag16)
                {
                    // Jukebox: Plays "Imagine Dragons - Believer (Official Video)"
                    Console.WriteLine("I'll try to make you a believer... hopefully in science!");
                    speechSynthesizer.Speak("I'll try to make you a believer... hopefully in science!");
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = "https://www.youtube.com/watch?v=7wtfhZwyrcc"
                        }
                    }.Start();
                    StringIsNotM8BQuestion = true;
                }
                bool flag4 = text.ToLower() == "clear";
                if (flag4)
                {
                    Console.Clear();
                    Program.Setup2();
                    StringIsNotM8BQuestion = true;
                }
                bool flag5 = text.ToLower() == "rickroll";
                if (flag5)
                {
                    // Either for prank or listening purposes, plays "Rick Astley - Never Gonna Give You Up"
                    Console.WriteLine("Do you actually like this, or are you pranking somebody?");
                    speechSynthesizer.Speak("Do you actually like this, or are you pranking somebody?");
                    Program.rickroll();
                    StringIsNotM8BQuestion = true;
                }

                //This short section deals with humans and human relationships, should somebody use this M8B
                //to solve them for some reason. Humans are weird, and being one myself, I do have room to talk

                bool flag6 = text.ToLower() == "will levi go out with me?";
                if (flag6)
                {
                    // Explains Levi's Relationship Status, whatever it is at most recent update. This
                    // comment will always remain as is for simplicity.

                    Console.Clear();
                    ConsoleColor PreMsgFG = Console.ForegroundColor;
                    ConsoleColor PreMsgBG = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I don't know, as of about 1/20/17, he's attempting to impress a girl named Naomi Post. As of 8/04/2017, ");
                    Console.WriteLine("She's gone out with him one time, but she could be thinking of that on a friend-level.");
                    Console.WriteLine(" Social Things have always confused him, but he's trying to make this work. Levi is currently trying");
                    Console.WriteLine("to find a way to see what she considers the movie event to be without possibly misphrasing.");
                    Console.WriteLine("His explanations suuuck, which is why he hasn't asked about it yet. He did, however, ask the quality of the event.");
                    Console.WriteLine("This part seems to be satisfactory, but Levi also sucks at social situations in which a hidden message may exist.");
                    Console.WriteLine();
                    Console.WriteLine("Naomi, if you somehow found this on your own, I congratulate you decompiling/reverse engineering an application!");
                    Console.WriteLine("I hope that I have not misinterpreted anything, and if I have, please just say so.");
                    Console.WriteLine("Also, it would be awesome if you told me that you successfully decompiled an app. You're especially awesome if");
                    Console.WriteLine("you did, and I'd be stunned at this if you say so. It would also be rather inetersting if you legitimately asked");
                    Console.WriteLine("the magic 8 ball this to find it. What are the chances of that? Anyways, yeah I'd love to go out with you again sometime!");
                    Console.ForegroundColor = PreMsgFG;
                    Console.BackgroundColor = PreMsgBG;
                    StringIsNotM8BQuestion = true;
                }
                bool flag7 = text.ToLower() == "will he go out with me?";
                if (flag7)
                {
                    Console.Clear();
                    ConsoleColor foregroundColor3 = Console.ForegroundColor;
                    ConsoleColor backgroundColor = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("What do you think? Go ask him (unless it's Levi Collinsworth, he's taken!)");
                    Console.ForegroundColor = foregroundColor3;
                    Console.BackgroundColor = backgroundColor;
                    StringIsNotM8BQuestion = true;
                }

                bool flag8 = text.ToLower() == "will she go out with me?";
                if (flag8)
                {
                    Console.Clear();
                    ConsoleColor foregroundColor4 = Console.ForegroundColor;
                    ConsoleColor backgroundColor2 = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("There's no instant way to know.");
                    Console.WriteLine("A general rule of thumb is that you should ask her while she's alone,");
                    Console.WriteLine("because you want to hear what she's got to say, not her friends. Make");
                    Console.WriteLine("sure that you are well-groomed before asking, though. This includes  ");
                    Console.WriteLine("well-trimmed nails, a fresh haircut, shaved facial hair, etc. In the ");
                    Console.WriteLine("end, it takes confidence to ask, too, so get all the previous done as");
                    Console.WriteLine("much/early as possible. Last thing she wants to hear is \"I would've,");
                    Console.WriteLine("but I 'didn't get the chance'.\" Avoid that as much as possible. No, ");
                    Console.WriteLine("ALWAYS avoid that. But do those things and then ask while she's alone.");
                    Console.ForegroundColor = foregroundColor4;
                    Console.BackgroundColor = backgroundColor2;
                    StringIsNotM8BQuestion = true;
                }
                bool flag9 = text.ToLower() == "what did trump say to the obama supporters?";
                if (flag9)
                {
                    ConsoleColor foregroundColor5 = Console.ForegroundColor;
                    ConsoleColor backgroundColor3 = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Orange");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" is the new");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" Black");
                    Console.ForegroundColor = foregroundColor5;
                    Console.BackgroundColor = backgroundColor3;
                    StringIsNotM8BQuestion = true;
                }
                bool flag10 = text.ToLower() == "you suck!";
                if (flag10)
                {
                    break;
                    Console.WriteLine("Exit failed. Just know that you are disrespected.");
                    StringIsNotM8BQuestion = true;
                }
                bool flag11 = text == "...";
                if (flag11)
                {
                    speechSynthesizer.Speak("I'm tired of people who don't ask questions. Please do so or exit.");
                    Console.WriteLine("I'm tired of people who don't ask questions. Please do so or exit.");
                    StringIsNotM8BQuestion = true;
                }
                bool flag12 = text.Length == 0;
                if (flag12)
                {
                    speechSynthesizer.Speak("Ask a question, please.");
                    Console.WriteLine("Ask a question, please.");
                    StringIsNotM8BQuestion = true;
                }
                bool flag13 = text.ToLower() == "about";
                if (flag13)
                {
                    Program.About();
                    StringIsNotM8BQuestion = true;
                }
                bool flag14 = text.ToLower() == "quit";
                if (flag14)
                {
                    goto Block_13;
                }
                bool flag15 = text.ToLower() == "exit";
                if (flag15)
                {
                    goto Block_14;
                }
                if (StringIsNotM8BQuestion == false)
                {
                    switch (random.Next(4))
                    {
                        case 0:
                            Console.WriteLine("YES");
                            speechSynthesizer.Speak("Yes");
                            break;
                        case 1:
                            Console.WriteLine("NO");
                            speechSynthesizer.Speak("No");
                            break;
                        case 2:
                            Console.WriteLine("HELL NO");
                            speechSynthesizer.Speak("Hell no");
                            break;
                        case 3:
                            Console.WriteLine("HELL YES");
                            speechSynthesizer.Speak("Hell yes");
                            break;
                    }
                }
            }

            Console.WriteLine("According to the positions of the stars above, you are the human that sucks.");
            Console.ReadKey();
        Block_13:
        Block_14:
            Console.ForegroundColor = foregroundColor;
        }

        private static void About()
        {
            SpeechSynthesizer speechSynthesizer1 = new SpeechSynthesizer();
            Console.WriteLine("This application is based off of a tutorial provided by Barnacules Nerdgasm:\r\n https://www.youtube.com/channel/UC1MwJy1R0nGQkXxRD9p-zTQ");
            speechSynthesizer1.Speak("This application is based off of a tutorial provided by Barnak u leez Nerd gasm");
        }

        private static void Setup()
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            Console.Title = "Levi's Magic 8 Ball";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Levi's Magic 8 Ball");
            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            Console.Beep();
            Console.WriteLine("This application is not for people who get seizures from rapid color change, or bright colors.");
            Console.WriteLine();
            Console.WriteLine("By pressing any key, you agree that you do not experience these, or that if you do, you will  ");
            Console.WriteLine("not hold Levi's Software, co. accountable.");
            Console.WriteLine();
            Console.WriteLine("If you do not agree, please click the X at the top right of the window, or otherwise end the task process.");
            Console.ReadKey();
            Console.Beep();
        }

        private static void Setup2()
        {
            Console.Title = "Levi's Magic 8 Ball";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Levi's Magic 8 Ball");
            Console.WriteLine("-------------------");
        }

        private static string ua()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadLine();
        }

        private static void rickroll()
        {
            new Process
            {
                StartInfo =
                {
                    FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
                }
            }.Start();
        }

    }
}
