---
sidebar_position: 2
---

# Coding

```mdx-code-block
import Tabs from '@theme/Tabs';
import TabItem from '@theme/TabItem';
import CodeBlock from '@theme/CodeBlock';
```

## Questions

Common coding questions that may come up during the process:

### How to reverse a string/array

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a string and the method should return the reverse of that string

    - **Input:** "this is random" | **Output:** "modnar si siht"
    - **Input:** [1, 2, 3, 4, 5, 6, 7, 8, 9] | **Output:** [9, 8, 7, 6, 5, 4, 3, 2, 1]

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/8qbWw49iW5VkX)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static void ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            charArray[i] = str[j];
            charArray[j] = str[i];
        }
        Console.WriteLine( new string(charArray));

        // Option2: Utilize Linq string methods to reverse a string
        string reversedString = new string(str.ToCharArray().Reverse().ToArray());
        Console.WriteLine($"Reversed String: {reversedString}");
    }

    private static void ReverseArray(int[] array)
    {
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

       Console.WriteLine("Reversed Array: [" + string.Join(", ", array) + "]");
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Check if string is a palindrome or not?

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a string and we need to print “Palindrome” or “Not Palindrome” based on whether the input string is a palindrome or not.

    - **Input:** madam | **Output:** Palindrome
    - **Input:** step on no pets | **Output:** Palindrome
    - **Input:** book | **Output:** Not Palindrome

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/25x3T50PqVOcI)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static bool IsPalindrome(string str)
    {
      // Remove spaces and convert to lowercase for case-insensitive comparison
      str = str.Replace(" ", "").ToLower();
      
      // The for loop compares characters from the start and end, moving inward. If all match, it’s a palindrome; otherwise, it’s not.
      for (int start = 0, end = str.Length - 1; start < end; start++, end--)
      {
          if (str[start] != str[end])
          {
              return false; //Not Palindrome
          }
      }

      return true; //Palindrome
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Reverse order of words in a string

<Tabs>
  <TabItem value="test" label="Test" default>
   The user will input a sentence and we need to reverse the sequence of words in the sentence.

    - **Input:** Welcome to Csharp corner | **Output:** corner Csharp to Welcome

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/2Cc66KM6opHCT)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`private static void ReverseSentence(string sentence)
    {
        // Split the sentence into words
        string[] words = sentence.Split(' ');
        
        string reversed = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            reversed += words[i];
            if (i > 0)
            {
                reversed += " "; // add space in between
            }
        }
        
        Console.WriteLine(reversed);
    
        
        // Optionn 2: Reverse the array using build in Reverse
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Reverse each word in a string

<Tabs>
  <TabItem value="test" label="Test" default>
   The user will input a sentence and we need to reverse each word individually without changing its position in the sentence.

    - **Input:** Welcome to Csharp corner | **Output:** emocleW ot prahsC renroc

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/7LhBPOEk8ScKg)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static void ReverseWordsInPlace(string sentence)
    {
        // Split the sentence into words
        string[] words = sentence.Split(' ');

        // Reverse each word individually
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }

        // Join the words back into a sentence
        Console.WriteLine(string.Join(" ", words));

    }

    private static string ReverseString(string word)
    {
        char[] charArray = word.ToCharArray();

        for (int i = 0, j = word.Length - 1; i < j; i++, j--)
        {
          charArray[i] = word[j];
          charArray[j] = word[i];
        }

        // OR - Remove one when test
        Array.Reverse(charArray);

        return new string(charArray);
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Count the occurrence of each character in a string

<Tabs>
  <TabItem value="test" label="Test" default>
   The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

    - **Input:** hello world | **Output:** h: 1, e: 1, l: 2, o: 1, w: 1, r: 1, d: 1

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/2m6I4Djl6z6xe)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static void CountCharacters(string input)
    {
        Dictionary<char, int> characterCounts = new Dictionary<char, int>();

        foreach (char character in input)
        {
            if (character == ' ') // Skip spaces
                continue;

            if (characterCounts.ContainsKey(character)) // Increase count if duplicate
            {
                characterCounts[character]++;
            }
            else
            {
                characterCounts[character] = 1; // Add to dict and count = 1
            }
        }

        foreach (var pair in characterCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Remove duplicate characters from a string

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a string and the method should remove multiple occurrences of characters in the string

    - **Input:** csharpcorner | **Output:** csharpone

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/00ndVtYOuUTRH)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static void RemoveDuplicateCharacters(string input)
    {
      Dictionary<char, bool> seen = new Dictionary<char, bool>();
      string result = "";
      
      foreach (char c in input)
      {
          // Option 1: Use string Contains()
          if (!result.Contains(c))
          {
              result += c;
          }
          
          //Option 2: Use Dict to check dup key
          if (!seen.ContainsKey(c))
          {
              seen[c] = true;
              result += c;
          }
      }
      Console.WriteLine(result.ToString());
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find all possible substring of a given string

<Tabs>
  <TabItem value="test" label="Test" default>
  This is a very frequent interview question. Here we need to form all the possible substrings from input string, varying from length 1 to the input string length. The output will include the input string also.

    - **Input:** abcd | **Output:** a ab abc abcd b bc bcd c cd d

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/51ULEsZwORoJg)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static void GenerateSubstrings(string input)
    {
      for (int start = 0; start < input.Length; start++) // Starting index
      {
        // Option 1: Use loop to build substring
        string substring = "";
        for (int end = start; end < input.Length; end++) // Ending index
        {
            substring += input[end]; // Build substring character by character
            Console.Write(substring + " "); // Print the substring
        }

        //Option 2: Use string.Substring()
        for (int length = 1; length <= input.Length - start; length++)
        {
            Console.Write(input.Substring(start, length) + " ");
        }
      }
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find missing number in an array

<Tabs>
<TabItem value="test" label="Test" default>
  Giving an array of integers, find the missing number in the array.

- **Example:** array[1-100], not sorted and missing number 34.

  - **Input:** [1-100] | **Output:** 34

- **Hint**: The formula is: `Sum = (n * (n + 1)) / 2`

**Link:** [Live Code Test](https://www.programiz.com/online-compiler/8wQ0YK6JMTVeB)

</TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static void FindMissingNumber(int[] arr, int n)
    {
      for (int start = 0; start < input.Length; start++) // Starting index
      {
        int missingNumber = int.MinValue;

        // Option 1: Use math
        int expectedSum = n * (n + 1) / 2; // Calculate the expected sum of the first n natural numbers
        int actualSum = arr.Sum();  // Calculate the actual sum of the array
        missingNumber = expectedSum - actualSum;         // The missing number is the difference

         // Option 2: Use hashset
        HashSet<int> allNumbers = new HashSet<int>(Enumerable.Range(1, n)); // Create a HashSet with all numbers from 1 to n
        foreach (int num in arr) // Remove all numbers that are present in the array
        {
            allNumbers.Remove(num);
        }
        missingNumber = allNumbers.First(); // The remaining number in the HashSet is the missing number

        Console.WriteLine("The missing number is: " + missingNumber);

      }
    }`}
    </CodeBlock>

  </TabItem>

</Tabs>

---

### Perform Left & Right circular rotation of an array

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input an integer array and the method should shift/right each element of input array to its Left by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.

    - **Input:** 1 2 3 4 5 | **Output:** Left - 2 3 4 5 1 | Right - 5 1 2 3 4

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/7apzdj5Lfej4j)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {` private static void ShiftLeft(int[] array)
    {
        int temp = array[0];
        for (int i = 0; i < array.Length - 1; i++) // Shift each element one position to the left
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;  // Move the first element to the last position
        
        Console.WriteLine("Left Shifted Array: " + string.Join(" ", array));
    }

    private static void ShiftRight(int[] array)
    {
        int temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--) // Shift each element one position to the right
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;  // Move the last element to the first position

        Console.WriteLine("Right Shifted Array: " + string.Join(" ", array));
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find if a positive integer is a prime number or not?

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a positive integer and the method should output “Prime” or “Not Prime” based on whether the input integer is a prime number or not.

    - **Input:** 20 | **Output:** Not Prime
    - **Input:** 17 | **Output:** Prime

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/03aZLCPLGJCCv)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  private static bool IsPrime(int number)
    {
      // Handle edge cases for numbers less than 2
      if (number < 2)
      {
          return false; // NOT PRIME
      }

      // Check divisibility from 2 to the square root of the number
      for (int i = 2; i <= Math.Sqrt(number); i++)
      {
          if (number % i == 0)
          {
              return false; // Found a divisor, NOT PRIME
          }
      }

      // If no divisors found, IS PRIME
      return true;
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find the sum of digits of a positive integer

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a positive integer and the method should return the sum of all the digits in that integer.

    - **Input:** 168 | **Output:** 15

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/9pgoI2VATYBiV)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {` private static void CalculateDigitSum(int number)
    {
      int sum = 0;

      // Loop to extract each digit and add it to the sum
      while (number > 0)
      {
          sum += number % 10;  // Extract the last digit
          number /= 10;        // Remove the last digit
      }

      Console.WriteLine("Sum of digits: " + sum);
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find 3 largest/smallest integer in an array using only one loop

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input an unsorted integer array and the method should find 3 largest/smallest integer in the array.

    - **Input:** 3 2 1 5 4 | **Output:** 3 Largest - 3 4 5 | Smallest - 1 2 3

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/1dsw7aTaQhjn2)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  public static void ThreeLargestSmallest(int[] array)
    {
        // Sort the array in ascending order
        Array.Sort(array);

        // Find the 3 smallest numbers
        int[] smallest = new int[3];
        for (int i = 0; i < smallest.Length; i++)
        {
            smallest[i] = array[i];
        }

        // Find the 3 largest numbers
        int[] largest = new int[3];
        for (int i = 0; i < largest.Length; i++)
        {
            largest[i] = array[array.Length - 1 - i];
        }

        Console.WriteLine("3 Smallest: " + string.Join(" ", smallest));
        Console.WriteLine("3 Largest: " + string.Join(" ", largest));
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find second largest integer in an array using only one loop

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input an unsorted integer array and the method should find the second largest integer in the array.

    - **Input:** 3 2 1 5 4 | **Output:** 4

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/5sFQ89HfxIaH7)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  public static void FindSecondLargestInArray(int[] array)
    {
      int largest = int.MinValue;
      int secondLargest = int.MinValue;

      foreach (int num in array)
      {
          if (num > largest) // If the current number is greater than the largest, update secondLargest first
          {
              secondLargest = largest;
              largest = num;
          }
          else if (num > secondLargest && num != largest) // If the current number is greater than secondLargest but not equal to largest, update secondLargest
          {
              secondLargest = num;
          }
      }

       Console.WriteLine("Second Largest: " + secondLargest);
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find third largest integer in an array using only one loop

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input an unsorted integer array and the method should find the third largest integer in the array.

    - **Input:** 3 2 1 5 4 | **Output:** 3

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/2yA4JrqGLdJKc)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {` public static void FindThirdLargestInArray(int[] array)
    {

        // Initialize variables to track the largest, second largest, and third largest
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        int thirdLargest = int.MinValue;

        foreach (int num in array)
        {
            // Update the three variables if the current number is greater than the largest
            if (num > largest)
            {
                thirdLargest = secondLargest;
                secondLargest = largest;
                largest = num;
            }
            // Update secondLargest and thirdLargest if the current number is between largest and secondLargest
            else if (num > secondLargest && num != largest)
            {
                thirdLargest = secondLargest;
                secondLargest = num;
            }
            // Update only thirdLargest if the current number is between secondLargest and thirdLargest
            else if (num > thirdLargest && num != secondLargest && num != largest)
            {
                thirdLargest = num;
            }
        }

        Console.WriteLine("Third Largest: " + thirdLargest);
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Convert a two-dimensional array to a one-dimensional array

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a 2-D array \( matrix /) and we need to convert it to a 1-D array. We will create a 1-D array column-wise.

    - **Input:** ` { { 1, 2, 3 }, { 4, 5, 6 } } ` | **Output:** 1 4 2 5 3 6

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/4XKt2tyqqQGeP)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  public static void ConvertTo1DArray(int[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);
      int[] result = new int[rows * cols]; // Initialize a 1D array with size rows * cols
      int index = 0; // Index for the 1D array

      // Traverse column-wise
      for (int col = 0; col < cols; col++)
      {
          for (int row = 0; row < rows; row++)
          {
              // Copy the element into the 1D array
              result[index++] = matrix[row, col];
          }
      }

      Console.WriteLine("1D Array Column-wise: " + string.Join(" ", result));
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Convert a one-dimensional array to a two-dimensional array

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input a 1-D array along with the number of rows and columns. The method should convert this 1-D array to a 2-D array(matrix) of a given row and column. We will create a matrix row-wise.

    - **Input:** `{1, 2, 3, 4, 5, 6}`, rows: 2, cols: 3 | **Output:** 1 2 3 \n 4 5 6

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/9tHkxp4EoMYHk)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  public static void ConvertTo2DArray(int[] oneDArray, int rows, int cols)
    {
        // Initialize a 2D array with the specified dimensions
        int[,] matrix = new int[rows, cols];

        // Fill the 2D array row-wise
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = oneDArray[i * cols + j];
            }
        }

         Print2DArray(matrix);
    }

    // Method to print a 2D array
    public static void Print2DArray(int[,] matrix)
    {
        Console.WriteLine("2D Array (Matrix):");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Find the angle between hour and minute hands of a clock

<Tabs>
  <TabItem value="test" label="Test" default>
  The user will input the hour and minute of the time and the method should give the angle between the hour hand and minute hand at that given time.

    - **Input:** 9 30 | **Output:** The angle between hour hand and minute hand is 105 degrees
    - **Input:** 13 30 | **Output:** The angle between hour hand and minute hand is 135 degrees

    **Link:** [Live Code Test](https://www.programiz.com/online-compiler/2ZzqBUBoscj1v)

  </TabItem>

  <TabItem value="answer" label="Answer">
    <CodeBlock language="cs" showLineNumbers={true}>
    {`  public static void CalculateAngle(int hour, int minute)
    {
      // Normalize the hour to 12-hour format
      hour = hour % 12;

      // Calculate the positions of the hour and minute hands in degrees
      double hourAngle = (hour * 30) + (minute * 0.5); // Each hour is 30 degrees, and each minute adds 0.5 degrees
      double minuteAngle = minute * 6; // Each minute is 6 degrees

      // Calculate the absolute difference between the two angles
      double angle = Math.Abs(hourAngle - minuteAngle);

      Console.WriteLine($"The angle between hour hand and minute hand is {Math.Min(angle, 360 - angle)} degrees.");
    }`}
    </CodeBlock>

  </TabItem>
</Tabs>

---

### Split Array into Pairs with Odd Sums

<Tabs>
<TabItem value="test" label="Test" default>

You are given an array `A` of `N` integers, where `N` is even. Your task is to determine if it is possible to split the array into `N/2` pairs such that:

1. **Every number in the array is used exactly once.**
2. **The sum of the two numbers in each pair is odd.**

#### Input Constraints

- `N` is an integer in the range: `[2, 100,000]`.
- Each element in the array `A` is an integer in the range: `[-1,000,000,000, 1,000,000,000]`.

#### Examples

| **Input**                  | **Output** | **Explanation**                                                                                                                         |
| -------------------------- | ---------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| `A = [2, 7, 4, 6, 3, 1]`   | `true`     | Possible pairs are `(2, 7)`, `(4, 3)`, and `(6, 1)`, all of which have odd sums.                                                        |
| `A = [-1, 1]`              | `false`    | The only possible pair is `(-1, 1)`, which has an even sum `-1 + 1 = 0`.                                                                |
| `A = [2, -1]`              | `true`     | The pair `(2, -1)` has an odd sum `2 + (-1) = 1`.                                                                                       |
| `A = [1, 2, 4, 3]`         | `true`     | Possible pairs are `(1, 2)` and `(4, 3)`, both with odd sums.                                                                           |
| `A = [-1, -3, 4, 7, 7, 7]` | `false`    | There are 4 odd numbers (`-1, -3, 7, 7`) and only 2 even numbers (`4`). It's not possible to pair every odd number with an even number. |

</TabItem>

<TabItem value="answer" label="Answer">

#### Step 1: Understand the Odd Sum Rule

- A pair will have an **odd sum** if one number is **odd** and the other is **even**.
- Examples:

  - `3 + 2 = 5` (Odd sum ✅)
  - `1 + 4 = 5` (Odd sum ✅)
  - `2 + 4 = 6` (Even sum ❌)
  - `3 + 5 = 8` (Even sum ❌)

  - `N` is guaranteed to be even, so you can always form `N/2` pairs.

- **Key Formula**:
  - oddCount = evenCount = 𝑁/2

---

#### Step 2: Count Odd and Even Numbers

- Traverse through the array and count:
  - The number of **odd numbers** (let’s call this `oddCount`).
  - The number of **even numbers** (let’s call this `evenCount`).

---

#### Step 3: Implement the Solution Efficiently

- Ensure the solution runs in \( O(N) \) time complexity:
  - Traverse the array once to count odd and even numbers.
- Ensure the solution uses \( O(1) \) space complexity:
  - Use only a few variables (`oddCount`, `evenCount`) to store the counts.

---

#### Step 4: Edge Cases to Consider

1. **Smallest Array**:

   - Input: `A = [1, 2]`
   - Output: `true` (1 odd and 1 even, so they can form a pair with an odd sum).

2. **Unbalanced Odd and Even Counts**:

   - Input: `A = [1, 3, 5, 7]`
   - Output: `false` (all odd, so no even numbers to pair with).

3. **Negative Numbers**:

   - Input: `A = [-2, -3, -4, -5]`
   - Output: `true` (`-2 + -3 = -5`, `-4 + -5 = -9`).

4. **Large Input**:
   - Ensure the solution handles arrays with up to \( N = 100,000 \) efficiently.

</TabItem>

<TabItem value="code" label="Code">
<CodeBlock language="cs" showLineNumbers={true}>
{`public bool solution(int[] A)
{
    int oddCount = 0;
    int evenCount = 0;
    int N = A.Length;
    int half = N / 2;

    // Count odd and even numbers
    foreach (int num in A)
    {
        if (num % 2 == 0) // Even number
            evenCount++;
        else // Odd number
            oddCount++;
    }

    // Optimize: Early exit if counts are already imbalanced
    if (oddCount > half || evenCount > half)
        return false;

    // Check if odd and even counts are equal
    return oddCount == evenCount;

} `}

</CodeBlock>
</TabItem>
</Tabs>
