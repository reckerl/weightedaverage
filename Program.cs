/*Programmer: Leah Recker
 *Date:01/19/21
 *Purpose: Calculating a Weighted Average
 * Class:CITP180
 * Assignment:GroupExercise, Chapter 2, Programming Exercise 8
 */
    using System;

namespace weightedaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int homework = 97;
            int projects = 82;
            int quizzes = 60;
            int exams = 75;
            int finalexams = 80; 

            decimal NewHomework;
            decimal NewProjects;
            decimal NewQuizzes;
            decimal NewExams;
            decimal NewFinal;

            NewHomework = (decimal)(homework * .1);
            NewProjects = (decimal)(projects * .35);
            NewQuizzes = (decimal)(quizzes * .1);
            NewExams = (decimal)(exams * .3);
            NewFinal = (decimal)(finalexams * .15);

            decimal WeightedAverage;

            WeightedAverage = (NewHomework + NewProjects + NewQuizzes + NewExams + NewFinal);
            Console.WriteLine("Your Homework Score:  " + homework + "\nYour projects score is:  " + projects + "\nyour quizzes score is:  " + quizzes + "\nYour exames score is:  " + exams + "\nyour final score is:  " + finalexams+"\n");
            Console.WriteLine("The weights are: \n Homework 10%\n Projects 35% \n Quizzes: 10% \n Exams: 30% \nFinal Exams: 15%\n");
            Console.WriteLine("\nYour weighted average :  "+WeightedAverage );
        }
    }
}
