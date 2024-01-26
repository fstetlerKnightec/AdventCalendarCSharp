﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {


        public List<string> reverseStrings(List<string> strings) {
            return strings.Select(s => reverseString(s)).ToList();
        }

        public string returnFirstNumberPartOne(string currentString) {
            for (int i = 0; i < currentString.Length; i++) {
                if (char.IsDigit(currentString[i])) {
                    return currentString[i].ToString();
                }        
            }

            return null;
        }

        public string returnFirstNumberFromLeftPartTwo(string currentString) {
            List<string> listOfNumbersAsWords = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < currentString.Length; i++) {
                if (char.IsDigit(currentString[i])) {
                    return currentString[i].ToString();
                }

                for (int j = 0; j < listOfNumbersAsWords.Count; j++) {
                    if (currentString.Substring(i).StartsWith(listOfNumbersAsWords[j])) {
                        return (j + 1).ToString();
                    }
                }
            }
            return null;
        }

        public string returnFirstNumberFromRightPartTwo(string currentString) {
            List<string> listOfNumbersAsReversedWords = new List<string>() { "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin" };
            string reversedString = reverseString(currentString);

            for (int i = 0; i < reversedString.Length; i++) {
                if (char.IsDigit(reversedString[i])) {
                    return reversedString[i].ToString();
                }
                
                for (int j = 0; j < listOfNumbersAsReversedWords.Count; j++) {
                    if (reversedString.Substring(i).StartsWith(listOfNumbersAsReversedWords[j])) {
                        return (j + 1).ToString();
                    }
                }
              
            }

            return null;
        }

        public int addAllNumbersTogether(List<string> listOfCombinedNumbers) {
            int sum = 0;

            foreach (string s in listOfCombinedNumbers) {
                sum += int.Parse(s);
            }
            return sum;
        }

        public int resultsPartOne() {
            List<string> listOfStrings = Util.getListOfStringsFromFile("C:\\Programming\\C#\\AdventCalendarC#\\resources\\dayone.txt");

            List<string> listOfReversedStrings = reverseStrings(listOfStrings);


            List<string> listOfFirstNumbersFromLeft = listOfStrings.Select(s => returnFirstNumberPartOne(s)).ToList();
            List<string> listOfFirstNumbersFromRight = listOfReversedStrings.Select(s => returnFirstNumberPartOne(s)).ToList();

            List<string> combinedNumbers = combineLeftAndRightNumberToList(listOfFirstNumbersFromLeft, listOfFirstNumbersFromRight);

            int totalSum = addAllNumbersTogether(combinedNumbers);

            return totalSum;
         }

        public int resultsPartTwo() {
            List<string> listOfStrings = Util.getListOfStringsFromFile("C:\\Programming\\C#\\AdventCalendarC#\\resources\\dayone.txt");

            List<string> listOfFirstNumbersFromLeft = listOfStrings.Select(s => returnFirstNumberFromLeftPartTwo(s)).ToList();
            List<string> listOfFirstNumbersFromRight = listOfStrings.Select(s => returnFirstNumberFromRightPartTwo(s)).ToList();

            List<string> combinedNumbers = combineLeftAndRightNumberToList(listOfFirstNumbersFromLeft, listOfFirstNumbersFromRight);

            int totalSum = addAllNumbersTogether(combinedNumbers);

            return totalSum;
        }

        public List<string> combineLeftAndRightNumberToList(List<string> left, List<string> right) {
            List<string> combinedNumbers = new List<string>();

            for (int i = 0; left.Count > i; i++) {
                string number = "";
                number = left[i].ToString() + right[i].ToString();
                combinedNumbers.Add(number);
            }
            return combinedNumbers;
        }

        public string reverseString(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        

        public void printSolutionOne() {
            Console.WriteLine(resultsPartOne());


        }

        public void printSolutionTwo() {
            Console.WriteLine(resultsPartTwo());
        }
    }
}
