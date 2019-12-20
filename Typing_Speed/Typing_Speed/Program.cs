using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Typing_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup for the game

            var wordList = GetWordList();

            var stopwatch = new Stopwatch();
            var correctWordsCount = 0;
            var totalWords = 0.0;
            var random = new Random();

            // Get player ready

            Console.WriteLine("Press enter when ready!!!");
            Console.ReadKey();
            Console.WriteLine("Stopwatch started! You have 30 seconds! \n");

            // Game start

            stopwatch.Start();
            while (stopwatch.Elapsed < TimeSpan.FromSeconds(30))
            {
                var index = random.Next(0, wordList.Count);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{wordList[index]}:");
                Console.ForegroundColor = ConsoleColor.White;

                var word = Console.ReadLine();

                if (wordList[index] == word)
                {
                    correctWordsCount++;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tocno! \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Krivo! Napisao si '{word}' umjesto '{wordList[index]}' \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                totalWords++;
            }

            stopwatch.Stop();

            // Game finish

            // Display end results

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vrijeme ti je isteklo!!!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Tocnih rijeci: {correctWordsCount}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Prosjek: {(correctWordsCount / totalWords * 100).ToString("#.##")}%");
            Console.ForegroundColor = ConsoleColor.White;

            // Set a short delay so player doesn't exit the game by accident
            Thread.Sleep(2000);
        }

        public static List<string> GetWordList()
        {
            // Create dummy text and immediately ToLower() it
            var dummyText = "IT HAS turned out fortunate for me to-day that destiny appointed Braunau-on-the-Inn to be my birthplace. For that little town is situated just on the frontier between those two States the reunion of which seems, at least to us of the younger generation, a task to which we should devote our lives and in the pursuit of which every possible means should be employed.German - Austria must be restored to the great German Motherland. And not indeed on any grounds of economic calculation whatsoever. No, no.Even if the union were a matter of economic indifference, and even if it were to be disadvantageous from the economic standpoint, still it ought to take place. People of the same blood should be in the same REICH.The German people will have no right to engage in a colonial policy until they shall have brought all their children together in the one State.When the territory of the REICH embraces all the Germans and finds itself unable to assure them a livelihood, only then can the moral right arise, from the need of the people to acquire foreign territory. The plough is then the sword; and the tears of war will produce the daily bread for the generations to come. And so this little frontier town appeared to me as the symbol of a great task.But in another regard also it points to a lesson that is applicable to our day.Over a hundred years ago this sequestered spot was the scene of a tragic calamity which affected the whole German nation and will be remembered for ever, at least in the annals of German history.At the time of our Fatherland's deepest humiliation a bookseller, Johannes Palm, uncompromising nationalist and enemy of the French, was put to death here because he had the misfortune to have loved Germany well.He obstinately refused to disclose the names of his associates, or rather the principals who were chiefly responsible for the affair. Just as it happened with Leo Schlageter.The former, like the latter, was denounced to the French by a Government agent.It was a director of police from Augsburg who won an ignoble renown on that occasion and set the example which was to be copied at a later date by the neo - German officials of the REICH under Herr Severing's regime (Note 1). In this little town on the Inn, haloed by the memory of a German martyr, a town that was Bavarian by blood but under the rule of the Austrian State, my parents were domiciled towards the end of the last century.My father was a civil servant who fulfilled his duties very conscientiously.My mother looked after the household and lovingly devoted herself to the care of her children.From that period I have not retained very much in my memory; because after a few years my father had to leave that frontier town which I had come to love so much and take up a new post farther down the Inn valley, at Passau, therefore actually in Germany itself. In those days it was the usual lot of an Austrian civil servant to be transferred periodically from one post to another. Not long after coming to Passau my father was transferred to Linz, and while there he retired finally to live on his pension.But this did not mean that the old gentleman would now rest from his labours. He was the son of a poor cottager, and while still a boy he grew restless and left home. When he was barely thirteen years old he buckled on his satchel and set forth from his native woodland parish. Despite the dissuasion of villagers who could speak from 'experience,' he went to Vienna to learn a trade there.This was in the fiftieth year of the last century.It was a sore trial, that of deciding to leave home and face the unknown, with three gulden in his pocket. By when the boy of thirteen was a lad of seventeen and had passed his apprenticeship examination as a craftsman he was not content.Quite the contrary.The persistent economic depression of that period and the constant want and misery strengthened his resolution to give up working at a trade and strive for 'something higher.' As a boy it had seemed to him that the position of the parish priest in his native village was the highest in the scale of human attainment; but now that the big city had enlarged his outlook the young man looked up to the dignity of a State official as the highest of all.With the tenacity of one whom misery and trouble had already made old when only half - way through his youth the young man of seventeen obstinately set out on his new project and stuck to it until he won through.He became a civil servant.He was about twenty - three years old, I think, when he succeeded in making himself what he had resolved to become.Thus he was able to fulfil the promise he had made as a poor boy not to return to his native village until he was 'somebody.' He had gained his end.But in the village there was nobody who had remembered him as a little boy, and the village itself had become strange to him. Now at last, when he was fifty-six years old, he gave up his active career; but he could not bear to be idle for a single day.On the outskirts of the small market town of Lambach in Upper Austria he bought a farm and tilled it himself.Thus, at the end of a long and hard - working career, he came back to the life which his father had led. It was at this period that I first began to have ideals of my own.I spent a good deal of time scampering about in the open, on the long road from school, and mixing up with some of the roughest of the boys, which caused my mother many anxious moments.All this tended to make me something quite the reverse of a stay - at - home.I gave scarcely any serious thought to the question of choosing a vocation in life; but I was certainly quite out of sympathy with the kind of career which my father had followed. I think that an inborn talent for speaking now began to develop and take shape during the more or less strenuous arguments which I used to have with my comrades.I had become a juvenile ringleader who learned well and easily at school but was rather difficult to manage.In my freetime I practised singing in the choir of the monastery church at Lambach, and thus it happened that I was placed in a very favourable position to be emotionally impressed again and again by the magnificent splendour of ecclesiastical ceremonial.What could be more natural for me than to look upon the Abbot as representing the highest human ideal worth striving for, just as the position of the humble village priest had appeared to my father in his own boyhood days ? At least, that was my idea for a while.But the juvenile disputes I had with my father did not lead him to appreciate his son's oratorical gifts in such a way as to see in them a favourable promise for such a career, and so he naturally could not understand the boyish ideas I had in my head at that time.This contradiction in my character made him feel somewhat anxious.".ToLower();

            // Clear out any characters other than letters, numbers and spaces
            dummyText = Regex.Replace(dummyText, "[^a-z0-9 _]+", " ");

            var wordList = new List<string>();

            // Split the dummy text into an array by space
            wordList = dummyText.Split(' ').ToList();

            // Remove all words shorter than 3 letters from array
            wordList.RemoveAll(word => word.Length < 3);

            // Remove duplicates from array
            wordList = wordList.Distinct().ToList();

            return wordList;
        }
    }
}
