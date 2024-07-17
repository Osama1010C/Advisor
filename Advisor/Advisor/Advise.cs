using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor
{
    internal class Advise
    {
        private static readonly string[] adviceArray = new string[]
        {
            "تقرب الي الله",
            "Stay positive.",
            "Work hard and stay focused.",
            "Learn from your mistakes.",
            "Take care of your health.",
            "Stay curious and keep learning.",
            "Be kind to others.",
            "Manage your time wisely.",
            "Set realistic goals.",
            "Don't be afraid to ask for help.",
            "Practice gratitude.",
            "Stay organized.",
            "Take breaks when needed.",
            "Embrace change.",
            "Believe in yourself.",
            "Stay humble.",
            "Listen more than you speak.",
            "Take responsibility for your actions.",
            "Keep a positive attitude.",
            "Value your relationships.",
            "Be patient.",
            "Stay disciplined.",
            "Keep your promises.",
            "Focus on what you can control.",
            "Stay open-minded.",
            "Seek feedback and improve.",
            "Avoid procrastination.",
            "Be honest with yourself and others.",
            "Learn to say no.",
            "Invest in yourself.",
            "Stay resilient.",
            "Be proactive.",
            "Celebrate small wins.",
            "Stay true to your values.",
            "Keep learning new skills.",
            "Take care of your mental health.",
            "Network with others.",
            "Be adaptable.",
            "Find a balance between work and life.",
            "Stay motivated.",
            "Help others whenever you can.",
            "Stay focused on your goals.",
            "Be respectful.",
            "Stay calm under pressure.",
            "Learn to manage stress.",
            "Take calculated risks.",
            "Stay consistent.",
            "Keep your sense of humor.",
            "Value your time.",
            "Stay determined.",
            "Be mindful of your actions."
            
        };

        public static string GetAdvise()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, adviceArray.Length);
            string advise = adviceArray[randomNumber];
            return advise;
        }

    }
}
