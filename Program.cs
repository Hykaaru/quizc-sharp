namespace quiz
{
    using System;
    using System.IO;
        class Program
        {
            static void Main(string[] args)
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Alex\Documents\quiz.txt");
                Console.WriteLine("Quiz Questions = ");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }
                bool q1ans = true;
                bool q2ans = true;
                bool q2ansa = false;
                bool q3ans = true;
                bool q3ansa = false;
                bool q4ans = true;
                bool q4ansa = false;
                bool q5ans = true;
                bool q5ansa = false;
                int lives = 5;
                string q1 = "Do you like CS?";
                string q2 = "Do you write in pseudocode first?";
                string q3 = "What are you?";
                string q4 = "yesno?";
                string q5 = "yesno??";
                string name = "";
                int score = 0;
                string answer = "";
                bool quiz = true;

                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

                if (lives > 0)
                {
                    while (quiz == true)
                    {
                        Console.WriteLine($"{q1} \n\rWhat is your answer?\n\r(a): yes\n\r(b): no\n\r(c): all of the above");
                        answer = Console.ReadLine();
                        q1ans = false;
                        while (q1ans == false)
                        {
                        if (answer == "a")
                        {
                            Console.WriteLine("Correct");
                            score += 1;
                            q1ans = true;
                            q2ansa = true;
                        }
                        else if (answer != "a" && lives > 0)
                        {
                            Console.WriteLine($"{q1}\n\rWrong.");
                            Console.WriteLine("Try again");
                            answer = Console.ReadLine();
                            q2ans = false;
                            q1ans = false;
                            lives--;
                            Console.WriteLine(lives);

                            if (lives <= 0)
                            {
                                Console.WriteLine("you died!! kekw");
                            }
                        }
                        }
                        while (q2ansa == true)
                        {
                            Console.WriteLine($"{q2} \n\rWhat is your answer?\n\r(a): yes\n\r(b): no\n\r(c): all of the above");
                            answer = Console.ReadLine();
                            q2ans = false;
                            while (q2ans == false)
                            {
                            if (answer == "a")
                            {
                                Console.WriteLine("Correct");
                                score += 1;
                                q2ans = true;
                                q2ansa = false;
                                q3ansa = true;
                            }
                            else if (answer != "a" && lives > 0)
                            {
                                Console.WriteLine($"{q2}\n\rWrong.");
                                Console.WriteLine("Try again");
                                answer = Console.ReadLine();
                                q2ans = false;
                                q1ans = false;
                                lives--;
                                Console.WriteLine(lives);

                                if (lives <= 0)
                                {
                                    Console.WriteLine("you died!! kekw");
                                }
                            }
                            }
                        }
                        while (q3ansa == true)
                        {
                            Console.WriteLine($"{q3} \n\rWhat is your answer?\n\r(a): yes\n\r(b): no\n\r(c): all of the above");
                            answer = Console.ReadLine();
                            q3ans = false;
                            while (q3ans == false)
                            {
                                if (answer == "a")
                                {
                                    Console.WriteLine("Correct");
                                    score += 1;
                                    q3ans = true;
                                    q3ansa = false;
                                    q4ansa = true;

                                }
                                else if (answer != "a" && lives > 0)
                                {
                                    Console.WriteLine($"{q3}\n\rWrong.");
                                    Console.WriteLine("Try again");
                                    answer = Console.ReadLine();
                                    q3ans = false;
                                lives--;
                                    Console.WriteLine(lives);
                                        if (lives <= 0)
                                        {
                                            Console.WriteLine("you died!! kekw");
                                        }

                                    }
                            }
                        }
                        while (q4ansa == true)
                        {
                            Console.WriteLine($"{q4} \n\rWhat is your answer?\n\r(a): yes\n\r(b): no\n\r(c): all of the above");
                            answer = Console.ReadLine();
                            q4ans = false;
                            while (q4ans == false)
                            {
                                if (answer == "a")
                                {
                                    Console.WriteLine("Correct");
                                    score += 1;
                                    q4ans = true;
                                    q4ansa = false;
                                    q5ansa = true;
                                }
                                else if (answer != "a" && lives > 0 )
                                {
                                    Console.WriteLine($"{q4}\n\rWrong.");
                                    Console.WriteLine("Try again");
                                    answer = Console.ReadLine();
                                    q4ans = false;
                                lives--;
                                Console.WriteLine(lives);

                                if (lives <= 0)
                                {
                                    Console.WriteLine("you died!! kekw");
                                }

                            }
                            }
                        }
                        while (q5ansa == true)
                        {
                            Console.WriteLine($"{q5} \n\rWhat is your answer?\n\r(a): yes\n\r(b): no\n\r(c): all of the above");
                            answer = Console.ReadLine();
                            q5ans = false;
                            while (q5ans == false)
                            {
                                if (answer == "a")
                                {
                                    Console.WriteLine("Correct");
                                    score += 1;
                                    q5ans = true;
                                    q5ansa = false;
                                    q5ansa = false;
                                }
                                else if (answer != "a" && lives > 0)
                                {
                                    Console.WriteLine($"{q5}\n\rWrong.\n\rtry again: ");
                                    answer = Console.ReadLine();
                                    q5ans = false;
                                lives--;
                                Console.WriteLine(lives);

                                if (lives <= 0)
                                {
                                    Console.WriteLine("you died!! kekw");
                                }

                            }
                            }
                        }
                        if (q5ansa == false)
                        {
                            Console.WriteLine("Well done. 5/5");
                            Console.WriteLine("you have finished the quiz");
                            Console.WriteLine($"You had {lives} lives left, well done!");
                        break;
                        }
                    }
                    if (lives <= 0)
                    {
                    Console.WriteLine("you died!! kekw");
                    }
                }

            }
        }
    }
