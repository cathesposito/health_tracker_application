namespace HealthTrackerApplication
{
    public class Program
    {
        // COMP100 Programming 1 - Assignment 2

        // In the Main method the user can add all his goals and it will show him a menu, where he can add information multiple times per day and for 7 days.
        static void Main(string[] args)
        {
            // F2 was used to format double numbers
            // Set boolean variable "toExit" equal to true.
            bool toExit = false;
            // Set 3 arryas to store the information for 7 days. Initialized with 0's.
            double[] waterConsumptionArray = { 0, 0, 0, 0, 0, 0, 0 };
            double[] calorieIntakeArray = { 0, 0, 0, 0, 0, 0, 0 };
            double[] physicalActivityArray = { 0, 0, 0, 0, 0, 0, 0 };
            // Initialize variables to be double and equal to zero
            double minumumWater = 0;
            double maximunWater = 0;
            double minumumCalorie = 0;
            double maximunCalorie = 0;
            double minumumPhysical = 0;
            double maximunPhysical = 0;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Health Tracker Application");
            Console.WriteLine("--------------------------");
            Console.Write("Before we start, what is your name? ");
            string? userName = Console.ReadLine();
            Console.WriteLine($"Welcome, {userName}!");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Add your Goals");
            Console.WriteLine("*----*----*----*----*");
            // Method "SetGoals" invocation here with two string arguments and pass two double arguments by reference, and return those values.
            SetGoals("Water Consumption", "liters", ref minumumWater, ref maximunWater);
            Console.WriteLine($"You set your Water Consumption to be between {minumumWater:F2} and {maximunWater:F2} liters.");
            Console.WriteLine("-****-****-****-****-");
            // Method "SetGoals" invocation here with two string arguments and pass two arguments by reference, and return those values.
            SetGoals("Calorie Intake", "cal", ref minumumCalorie, ref maximunCalorie);
            Console.WriteLine($"You set your Calorie Intake to be between {minumumCalorie:F2} and {maximunCalorie:F2} cal.");
            Console.WriteLine("-****-****-****-****-");
            // Method "SetGoals" invocation here with two string arguments and pass two arguments by reference, and return those values.
            SetGoals("Physical Activity", "min", ref minumumPhysical, ref maximunPhysical);
            Console.WriteLine($"You set your Physical Activity to be between {minumumPhysical:F2} and {maximunPhysical:F2} min.");
            Console.WriteLine();
            //  It will loop through, using do-while loop, as long as "toExit" is equal to false.
            do
            {

                Console.WriteLine("|---------------Menu--------------|");
                Console.WriteLine("(1) Add Water Consumption per day");
                Console.WriteLine("(2) Add Calorie Intake  per day");
                Console.WriteLine("(3) Add Physical Activity per day ");
                Console.WriteLine("(4) Summary");
                Console.WriteLine("(5) Insights");
                Console.WriteLine("(0) To Exit");
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine();
                Console.Write("What do you want to do? ");
                // Adding "?" after data type string to fix nullable warnings For .NET. 
                // Set var "choice" to be equal to the user input.
                // I chose string, because I don't need to use explicit casting.
                string? choice = Console.ReadLine();

                // Swith expression so the value of the "choice" is compared with the values of each case "3", "4"...
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You are in the Water Consumption per day session");
                        Console.WriteLine("*----*----*----*----*");
                        // Method "AddInfoArray" invocation here with 2 strings and 2 doubles arguments. Return double array and assigns it a value equal to the return value for the method.
                        waterConsumptionArray = AddInfoArray("Water Consumption", "liters", minumumWater, maximunWater);
                        Console.WriteLine("-----------------------");
                        // Break the switch block.
                        break;
                    case "2":
                        Console.WriteLine($"You are in the Calorie Intake per day session");
                        Console.WriteLine("*----*----*----*----*");
                        // Method "AddInfoArray" invocation here with 2 strings and 2 doubles arguments. Return double array and assigns it a value equal to the return value for the method.
                        calorieIntakeArray = AddInfoArray("Calorie Intake", "cal", minumumCalorie, maximunCalorie);
                        Console.WriteLine("-----------------------");
                        // Break the switch block.
                        break;
                    case "3":
                        Console.WriteLine($"You are in the Physical Activity per day session");
                        Console.WriteLine("*----*----*----*----*");
                        // Method "AddInfoArray" invocation here with 2 strings and 2 doubles arguments. Return double array and assigns it a value equal to the return value for the method.
                        physicalActivityArray = AddInfoArray("Physical Activity", "min", minumumPhysical, maximunPhysical);
                        Console.WriteLine("-----------------------");
                        // Break the switch block.
                        break;
                    case "4":
                        Console.WriteLine($"You are in the Summary per day session");
                        Console.WriteLine("*----*----*----*----*");
                        // Method "SummaryPerDayAndWeek" invocation here with one double array and two strings arguments.
                        SummaryPerDayAndWeek(waterConsumptionArray, "Water Consumption", "liters");
                        // Method "SummaryPerDayAndWeek" invocation here with one double array and two strings arguments.
                        SummaryPerDayAndWeek(calorieIntakeArray, "Calorie Intake", "cal");
                        // Method "SummaryPerDayAndWeek" invocation here with one double array and two strings arguments.
                        SummaryPerDayAndWeek(physicalActivityArray, "Physical Activity", "min");
                        Console.WriteLine("-----------------------");
                        // Break the switch block.
                        break;
                    case "5":
                        Console.WriteLine($"You are in the Insights per day session");
                        Console.WriteLine("*----*----*----*----*");
                        // Method "InsightPerDayAndWeek" invocation here with one double array, two strings and two doubles arguments.
                        InsightPerDayAndWeek(waterConsumptionArray, "Water Consumption", "liters", minumumWater, maximunWater);
                        // Method "InsightPerDayAndWeek" invocation here with one double array, two strings and two doubles arguments.
                        InsightPerDayAndWeek(calorieIntakeArray, "Calorie Intake", "cal", minumumCalorie, maximunCalorie);
                        // Method "InsightPerDayAndWeek" invocation here with one double array, two strings and two doubles arguments.
                        InsightPerDayAndWeek(physicalActivityArray, "Physical Activity", "min", minumumPhysical, maximunPhysical);
                        Console.WriteLine("-----------------------");
                        break;
                    case "0":
                        Console.WriteLine("Exited");
                        // Add new blank like.
                        Console.WriteLine();
                        // Assign the value of local variable "toExit" to true.
                        toExit = true;
                        // Break the switch block.
                        break;
                    // Any other case
                    default:
                        Console.WriteLine("Error, try again");
                        // Add new blank like.
                        Console.WriteLine();
                        // Break the switch block.
                        break;
                }
                // Checking the condition of variable "toExit" equal to "false" in both side of boolean operator "==".
                // And the condition will only be satisfied when the switch case is "0". So, the program will be finished.
            } while (toExit == false);
        }

        // Create new method outside Main method
        // Method "CheckValue" with one double, one string arguments, and pass three double arguments by reference, and return those values.
        // CheckValue method was created to check if the values added by the user make sense. So he cannot add negative number, nor number different from each range set by myself.
        static void CheckValue(double value, string unit, ref double minumum, ref double maximun, ref double valueChecked)
        {
            // Set boolean variable "toContinue" equal to true.
            bool toContinue = true;
            // Add if-condition for the string unit argument, in both sides of boolean operator "==". Set minumum and maximum variables that are going to be return by the method.
            if (unit == "liters")
            {
                minumum = 0.2;
                maximun = 0.9;
            }
            else if (unit == "cal")
            {
                minumum = 200;
                maximun = 900;
            }
            else
            {
                minumum = 10;
                maximun = 60;
            }
            //  It will loop through, using while loop, as long as "toContinue" is true, in both sides of boolean operator "==".
            while (toContinue == true)
            {
                // Check conditions using logical OR operator ||
                if (value < minumum || value > maximun)
                {
                    Console.Write($"You should add a value between {minumum:F2} and {maximun:F2} {unit}! New value: ");
                    // Set "value" to be equal to the user input. And used explicit casting to convert data types.
                    value = Convert.ToDouble(Console.ReadLine());
                }
                // Any other condition, set "toContinue" var to be false and stop the while loop.
                else
                {
                    toContinue = false;
                };
            }
            // Set "valueChecked" that is going to the return as equal to "value".
            valueChecked = value;
        }

        // Create new method outside Main method
        // Method "CheckValueForGoal" with one double and one string arguments. Return a double.
        // CheckValueForGoal method is used to check if the the values for the method "SetGoals", checks if the values added by the user make sense. So he cannot add negative number, nor number different from each range set by myself.
        static double CheckValueForGoal(double value, string unit)
        {
            // Set variables with no value.
            double minumum;
            double maximun;
            // Set boolean variable "toContinue" equal to true.
            bool toContinue = true;
            // Add conditions for the string unit argument, in both sides of boolean operator "==". Set minumum and maximum variables that I chose to be the values that will be used to validade the user inputs.
            if (unit == "liters")
            {
                minumum = 2;
                maximun = 5;
            }
            else if (unit == "cal")
            {
                minumum = 1500;
                maximun = 4000;
            }
            else
            {
                minumum = 20;
                maximun = 120;
            }
            //  It will loop through, using while loop, as long as "toContinue" is true, in both sides of boolean operator "==".
            while (toContinue == true)
            {
                // Check conditions using logical OR operator ||
                if (value < minumum || value > maximun)
                {
                    Console.Write($"The daily recommended values are between {minumum:F2} and {maximun:F2} {unit}! ");
                    // Set "value" to be equal to the user input. And used explicit casting to convert data types.
                    value = Convert.ToInt16(Console.ReadLine());
                }
                // Any other condition, set "toContinue" var to be false and stop the while loop.
                else
                {
                    toContinue = false;
                };
            }
            // Return "value".
            return value;
        }

        // Create new method outside Main method
        // Method "SetGoals" with two strings arguments, and pass two doubles arguments by reference, and return those values.
        // SetGoals method is used for the user add values for each metric. And check if those values are ok using "CheckValueForGoal" method.
        static void SetGoals(string inputName, string unit, ref double minumumChecked, ref double maximunChecked)
        {
            Console.Write($"What is your minumum {inputName} goal per day in {unit}? ");
            // Set "minumumGoal" to be equal to the user input. And used explicit casting to convert data types.
            double minumumGoal = Convert.ToInt16(Console.ReadLine());
            // Method "CheckValueForGoal" invocation here with one double and one string arguments. Return double and assigns it a value equal to the return value for the method.
            minumumChecked = CheckValueForGoal(minumumGoal, unit);
            Console.Write($"What is your maximun {inputName} goal per day in {unit}? ");
            // Set "maximunGoal" to be equal to the user input. And used explicit casting to convert data types.
            double maximunGoal = Convert.ToInt16(Console.ReadLine());
            // Method "CheckValueForGoal" invocation here with one double and one string arguments. Return double and assigns it a value equal to the return value for the method.
            maximunChecked = CheckValueForGoal(maximunGoal, unit);
            // It will loop through, using while loop, as long as "maximunChecked" is less or equal to "minumumChecked".
            // I added here this condition so the user does not add value for maximunChecked less than minumumChecked.
            while (maximunChecked <= minumumChecked)
            {
                Console.WriteLine($"Add a number higher than {minumumChecked:F2} {unit}!");
                Console.Write($"What is your maximun {inputName} goal per day in {unit}? ");
                // Set "maximunGoal2" to be equal to the user input. And used explicit casting to convert data types.
                double maximunGoal2 = Convert.ToInt16(Console.ReadLine());
                // Method "CheckValueForGoal" invocation here with one double and one string arguments. Return double and assigns it a value equal to the return value for the method.
                maximunChecked = CheckValueForGoal(maximunGoal2, unit);
            }
        }
        // Create new method outside Main method
        // Method "AddInfoArray" with two strings and two doubles arguments. Return one double array.
        // AddInfoArray method is used to add value to each metric array. During each day and/or for entire week. User can choose if he wants to continue to add information for the day. The user can also choose if he wants to add information for multi days.
        static double[] AddInfoArray(string inputName, string unit, double minumumGoal, double maximunGoal)
        {
            // Set double array "AddInfoArray" and allocate memory for the number of items equal to 7.
            double[] AddInfoArray = new double[7];
            // Set variables with no value.
            int day;
            // Set boolean variable "toContinue" equal to true.
            bool toContinue = true;
            // Initialize variables to be double and equal to zero.
            double minumum = 0;
            double maximun = 0;
            double valueChecked = 0;

            //  It will loop through, using for loop, as long as "day" is less than 7, and "day" will increment in 1.
            for (day = 1; day <= 7; day++)
            {
                // Use do-while loop as long as the var value for "toContinue" is equal to true, in both sides of boolean operator "==".
                while (toContinue == true)
                {
                    Console.WriteLine($"Day {day}");
                    // Add condition here, that when day is equal to 8, the while loop break.
                    if (day != 8)
                    {
                        // Initialize "sum" to be double and equal to zero. It is inside the while loop, because it needs to be a new variable for each time that method is called.
                        double sum = 0;
                        //  It will loop through, using do-while loop, as long as "sum" is less or equal to "maximunGoal".
                        do
                        {
                            Console.Write($"What is your {inputName} in {unit}? ");
                            // Set "input" to be equal to the user input. And used explicit casting to convert data types.
                            double input = Convert.ToDouble(Console.ReadLine());
                            // Method "CheckValue" invocation here with one double and one string arguments, and pass three doubles arguments by reference, and return those values.
                            CheckValue(input, unit, ref minumum, ref maximun, ref valueChecked);
                            // Add conditions using logical AND operator &&
                            if (valueChecked >= minumum && valueChecked <= maximun)
                            {
                                // Used compound assignment, to add the variables, so it means "sum = sum + valueChecked".
                                sum += valueChecked;
                                // Add conditions if "sum" is greater or equal to "maximunGoal"
                                if (sum >= maximunGoal)
                                {
                                    // Assign value "sum" to the array "AddInfoArray" in the index position equal to day minus 1. Ex day=1; position 1-1=0.
                                    AddInfoArray[day - 1] = sum;
                                    Console.WriteLine($"Your sum is {sum:F2} in {unit}. Better than your goal!");
                                    // Break the if block.
                                    break;
                                }
                                else
                                {   
                                    Console.WriteLine($"Your goal is between {minumumGoal:F2} and {maximunGoal:F2} in {unit}. You had {sum:F2} {unit}.");
                                    Console.Write($"Do you want to continue to add {unit} for today? Yes or No? ");
                                    // Adding "?" after data type string to fix nullable warnings For .NET. 
                                    // Set var "answer" to be equal to the user input. I chose string, because I don't need to use explicit casting.
                                    string? answer = Console.ReadLine();
                                    // Set var "answerLowerCase" to be equal to var "answer" and use method ToLower to edit string to lowercase
                                    string answerLowerCase = answer.ToLower();
                                    // Add condition if "answerLowerCase" is equal to "yes", in both sides of boolean operator "==".
                                    if (answerLowerCase == "yes")
                                    {
                                        // Continue the if block.
                                        continue;
                                    }
                                    // Any other condition
                                    else
                                    {
                                        // Assign value "sum" to the array "AddInfoArray" in the index position equal to day minus 1. Ex day=1; position 1-1=0.
                                        AddInfoArray[day - 1] = sum;
                                        // Break the if block.
                                        break;
                                    };
                                }
                            }
                            // Any other condition
                            else
                            {
                                Console.WriteLine("Invalid entry. Try again!");
                            }
                        } while (sum <= maximunGoal);

                        Console.WriteLine($"Your sum for day {day} is {sum:F2} in {unit}.");
                        // Add condition if "day" is equal to "7", in both sides of boolean operator "==". Set "toContinue" var to be false and stop the do-while loop.
                        if (day == 7)
                        {
                            toContinue = false;
                        }
                        // Any other condition
                        else
                        {
                            Console.Write($"Do you want to continue to add info for day {day + 1}? Yes or No? ");
                            // Adding "?" after data type string to fix nullable warnings For .NET. 
                            // Set var "answer2" to be equal to the user input. I chose string, because I don't need to use explicit casting.
                            string? answer2 = Console.ReadLine();
                            // Set var "answerLowerCase2" to be equal to var "answer2" and use method ToLower to edit string to lowercase
                            string answerLowerCase2 = answer2.ToLower();
                            // Add condition if "answerLowerCase" is different of "yes", using boolean operator "!=". Set "toContinue" var to be false and stop the do-while loop.
                            if (answerLowerCase2 != "yes")
                            {
                                toContinue = false;
                            }
                        }
                        // Break the if block.
                        break;
                    }
                };
            };
            // Retunr double array
            return AddInfoArray;
        }
        // Create new method outside Main method
        // Method "GetFeedback" with two strings and three doubles arguments. Return none.
        // GetFeedback method is used to print out feedbacks based in the user informations. It can be fair, good or excellent.
        static void GetFeedback(string unit, double value, double minumum, double maximun, string period)
        {
            // Set variables with no value.
            int index;
            string feedback;
            // Set random number generator using Random class.
            Random rand = new Random();

            // Set strings arrays and assigns strings values.
            string[] excellentFeedback = { "You excel!", "Excellent job!", "You are doing great!", "Amazing!" };
            string[] goodFeedback = { "Goal achieved!", "Good job!", "You are doing well!", "Nice job!", "Cool!" };
            string[] fairFeedback = { "Goal is not achieved!", "You can do better!", "You can do more!", };
            // Add conditions using logical AND operator &&
            if (value >= minumum && value <= maximun)
            {
                // Assign value random number using array length and set "index" var.
                index = rand.Next(goodFeedback.Length);
                // Set "feedback" var to be equal to the string in the "index" position in the string array selected.
                feedback = goodFeedback[index];
                Console.WriteLine($"Your average per {period} is {value:F2} {unit}, which it is between {minumum:F2} and {maximun:F2} {unit}! {feedback}");
            }
            // If value is less than minumum
            else if (value < minumum)
            {
                // Assign value random number using array length and set "index" var.
                index = rand.Next(fairFeedback.Length);
                // Set "feedback" var to be equal to the string in the "index" position in the string array selected.
                feedback = fairFeedback[index];
                Console.WriteLine($"Your average per {period} is {value:F2} {unit}, it should be between {minumum:F2} and {maximun:F2} {unit}! {feedback}");
                // Set double "diff" variable to be the difference between minumum and value.
                double diff = minumum - value;
                Console.WriteLine($"Try to do more! Add more {diff:F2} {unit} in your {period}!");
            }
            // Any other condition, which means that "value" is greater than "maximun".
            else
            {
                // Assign value random number using array length and set "index" var.
                index = rand.Next(excellentFeedback.Length);
                // Set "feedback" var to be equal to the string in the "index" position in the string array selected.
                feedback = excellentFeedback[index];
                Console.WriteLine($"Your average per {period} is {value:F2} {unit}, higher than for {maximun:F2} {unit}! {feedback}");
            };
        }
        // Create new method outside Main method
        // Method "SummaryPerDayAndWeek" with two strings and one double array arguments. Return none.
        // SummaryPerDayAndWeek method will do the sum and average for the day or week.
        static void SummaryPerDayAndWeek(double[] array, string inputName, string unit)
        {
            // Method "NumberOfZerosLeftInTheWeek" invocation here with one double array argument. Return integer value and assign to "zeroExist" variable.
            int zeroExist = NumberOfZerosLeftInTheWeek(array);
            // If "zeroExist" is different than 7, which means that the user had added information.
            if (zeroExist != 7)
            {
                // Method "CalculateAverageOfAllValues" invocation here with one double array and one integer arguments. Return double value and assign to "averagePerDay" variable.
                double averagePerDay = CalculateAverageOfAllValues(array, zeroExist);
                Console.WriteLine($"You average per day is {averagePerDay:F2} {unit}");
                // Method "CalculateAverageOfAllValues" invocation here with one double array and one zero arguments. Return double value and assign to "averagePerWeek" variable.
                double averagePerWeek = CalculateAverageOfAllValues(array, 0);
                Console.WriteLine($"You average per week is {averagePerWeek:F2} {unit}");
                Console.WriteLine("****----****----****");
            }
            // Any other condition
            else
            {
                Console.WriteLine($"No info added for {inputName}");
            }
        }
        // Create new method outside Main method
        // Method "InsightPerDayAndWeek" with one double array, two strings, and two doubles arguments. Return none.
        // InsightPerDayAndWeek method will do the sum and average for the day or week, and add feedback for the user.
        static void InsightPerDayAndWeek(double[] array, string inputName, string unit, double minumum, double maximun)
        {
            // Method "NumberOfZerosLeftInTheWeek" invocation here with one double array argument. Return integer value and assign to "zeroExist" variable.
            int zeroExist = NumberOfZerosLeftInTheWeek(array);
            // If "zeroExist" is different than 7, which means that the user had added information.
            if (zeroExist != 7)
            {
                // Method "CalculateAverageOfAllValues" invocation here with one double array and one integer arguments. Return double value and assign to "averagePerDay" variable.
                double averagePerDay = CalculateAverageOfAllValues(array, zeroExist);
                // Method "GetFeedback" invocation here with two strings and three doubles arguments. Return none.
                GetFeedback(unit, averagePerDay, minumum, maximun, "day");
                // Method "CalculateAverageOfAllValues" invocation here with one double array and one zero arguments. Return double value and assign to "averagePerWeek" variable.
                double averagePerWeek = CalculateAverageOfAllValues(array, 0);
                // Method "GetFeedback" invocation here with two strings and three doubles arguments. Return none.
                GetFeedback(unit, averagePerWeek, minumum, maximun, "week");
                Console.WriteLine("****----****----****");
            }
            // Any other condition
            else
            {
                Console.WriteLine($"No info added for {inputName}");
            }
        }
        // Create new method outside Main method
        // Method "NumberOfZerosLeftInTheWeek" with one double array argument. Return integer.
        // NumberOfZerosLeftInTheWeek method is used to catch number of zeros in the array. If the array has 7 zeros, it means that the user does not add any info for the metric.
        static int NumberOfZerosLeftInTheWeek(double[] array)
        {
            // Set "numberOfZeros" to be equal to 7. Because the arrays "waterConsumptionArray",  "calorieIntakeArray" and "physicalActivityArray" are initialized with 7 zeros.
            int numberOfZeros = 7;
            // Use Array.Exists and lambda expression to check if the array contain the "0" elements. If "0" exists, set "zeroExist" to be a true.
            bool zeroExist = Array.Exists(array, element => element == 0);
            // Add conditions for the bool "zeroExist" argument is equal to true, in both sides of boolean operator "==".
            if (zeroExist == true)
            {
                // Use Array.FindAll and lambda expression to check if the array contain the "0" elements. If "0" exists, set double array "numberOfZerosArray" with the all zeros.
                double[] numberOfZerosArray = Array.FindAll(array, element => element == 0);
                // Get the size of "numberOfZerosArray" and set "numberOfZeros" to be the return integer value.
                numberOfZeros = numberOfZerosArray.Length;
            }
            // Return integer
            return numberOfZeros;
        }

        // Create new method outside Main method
        // Method "CalculateSumOfAllValues" with one double array argument. Return double.
        // CalculateSumOfAllValues method to calculate the sum of all values in the array.
        static double CalculateSumOfAllValues(double[] array)
        {
            // Initialize "sum" to be double and equal to zero.
            double sum = 0;
            //  It will loop through, using for loop, as long as "i" is less than "array.Length", and "i" will increment in 1.
            for (int i = 0; i < array.Length; i++)
            {
                // Add value from the double array in the position "i" and add to "sum" variable using compound assignment.
                sum += array[i];
            }
            // Return double
            return sum;
        }

        // Create new method outside Main method
        // Method "CalculateAverageOfAllValues" with one double array and one integer arguments. Return double.
        // CalculateAverageOfAllValues method to calculate the average of all values in the array. The division will depend on the number "numberOfZeros", because I don't want the average for days that are zero.
        static double CalculateAverageOfAllValues(double[] array, int numberOfZeros)
        {
            // Method "CalculateSumOfAllValues" invocation here with one double array argument. Return double value and assign to "sum" variable.
            double sum = CalculateSumOfAllValues(array);
            // Set "average" as double and it is equal to "sum" divided by 7 minus numberOfZeros. I want to get the floating-point number so I added "(double)" before the math operation.
            double average = (double)sum / (7 - numberOfZeros);
            // Retunr double
            return average;
        }
    }
}

