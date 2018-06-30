The steps taken in creating this console application:
1 - Created a new class outside of program.cs (ReadAndWrite).
  > This class' primary function was to take all strings residing in the given example text file and put them into a list
    Measures were taken to ignore non-alphanumeric characters and ensure that there was content in the text file that would be in use
2 - In program.cs
  > Created an instance of the generated class in ReadAndWrite.cs and call its function, taking the text file's path as a parameter.
  > Created a new List that puts all strings collected and placed into a list.
  > Make the console request for user input which goes through the following validation:
    *It meets the regex's alphanumeric criteria
    *That no repeating characters have been inserted
    *That it is exactly 5 characters (used based in the example given in this assessment)
    (Error messages have been provided iin each scenario)
  > Then the user's input will then be checked with all the strings collected in the generated List if there is a match.
    The program will then tell the user if a match is found, alongside with the string that was inserted. If not, an error message will
    be provided.
