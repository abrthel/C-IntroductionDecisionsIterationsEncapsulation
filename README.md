# C# Introduction - Decisions, Iteration & Encapsulation

List of practice C# questions broken down by section and number.

**Trello:** [https://trello.com/b/7QPj9xUQ/c-introduction-decisions-iteration-encapsulation](https://trello.com/b/7QPj9xUQ/c-introduction-decisions-iteration-encapsulation)

## Requirements

### Procedural Programming
#### 1.
* Prompts the user for a number
* Outputs Cube of that number

#### 2.
* Prompt for total dollar value (as double)
* Prompt for number of diners (as int)
* Output the amount of the bill divided by each diner

#### 3.
* Prompt Age
* Output Birth year

#### 4.
* Prompts for a 4 digit integer.
* Calculate the sum of its digits without converting to a string (x%10; x/10;)


### Libraries - Math, String, Random and More

#### 1.
* Prompt for a string
* Output string as uppercase

#### 2.
* Prompt for three integers
* Output highest and lowest of the three

#### 3.
* Prompt for number of fence posts
* Output number of paint buckets required to paint the posts - 1:4 paint to fence posts

#### 4.
* Prompt for two sides of a right triangle
* Output length of hypotenuse to 2 decimal places.

#### 5.
* Output a random 5 characters long password of uppercase letters. (convert int to char and append to string)

### Expressions and Decisions
#### 1.
* Generate random number between 1 and 10
* Prompt two users for guesses and output winner
* Winner is user that has the closest answer
* Output Draw if both have the same distance

#### 2.
* Prompt user for an integer
* Output if number is odd or even

#### 3.
* Prompt user for number
* Output whether the number is a perfect square of a whole number or not

#### 4.
* Prompt users for simple expression (1 + 1, 3/2, 2-2, 4*4)
* Output result

#### 5.
* Prompt for 3 character month code (case insensitive)
* Output full name of month and number of days in that month using a switch
* Prompt for year if feb. is entered.


### Iteration and Basic Validation
#### 1.
* Prompt for number between 1 and 10 inclusive
* Loop until proper number is entered

#### 2.
* Output "Hello"
* Wait for user input
* Repeat until user input is 'stop' case insensitive

#### 3.
* Count from 1 to 100 outputting each value
* Replace every number divisible by three with "Fizz"
* Replace every number divisible by 5 with "Buzz"
* Replace every number divisible with 3 & 5 with "FizzBuzz"
* Make maintainable.

#### 4.
* Ask user for 20 integers (marks)
* If user enters -1 close program.
* There must be at least one mark
* Output average, highest and lowest mark
* Ask if they'd like to try again


### Exception Handling

#### 1.
* Modify program 1 - Iteration and Basic Validation
* user can enter non-numeric data and program wont crash
* throw exception when entered number is not between 1-10 (inclusive)
* Output exception message as part of error

#### 2.
* Modify program 4 - "Expressions and Decisions"
* Allow user to enter 0 as a divisor - program should not crash
* Prompt for new divisor if they do enter 0

#### 3.
* Modify program 3 - Iteration and Basic Validation
* User can enter 3 numbers and 3 words
* Throw exception on duplicate numbers or words or empty words; handle and prompt again
* Throw exception if divisor < 2
* User can enter start, end numbers.
* start,end numbers must be greater than 0
* end must be larger than start
* span between start-end must not be greater than 100

### Arrays and Basic Data Structures

### General
* Support Max 10 words
* Update/Insert cannot be a duplicate name
* Names cannot be < 2 characters
* Names cannot be whitespace
* Names must be one word
* Trim Trailing space
* Names are stored title case

### Update / Delete
* Can delete by index / name
* Compress list when item is deleted
* Name search is case insensitive

### List
* List starting at 1

### Insert
* Input is case insensitive
