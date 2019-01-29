Fizz Buzz Tree
Traverse a tree and find values that are divisible by certain values and change the values to fizz, buzz or fizzbuzz

assigned this challenge, complete whiteboard exercise and solution.

Challenge
Create a tree with int values

Pass tree to a method that traverses the tree and checks if value are divisible by 3, if true change value to "fizz"

if value is divisible by 5 change vale to "buzz"

and if value is divisible by both 3 and 5 then change value to "FizzBuzz"

Approach and efficiency
Used a recursive method with if statements to check the values and push them to a new List which stores the unchanged values and the changed values. Then return the new list.

API
FizzBuzz() method traverses the tree looks for fizz buzz or fizzbuzz qualifying int and changes values then returns List. 
Big O 
Space O(1) 
Time O(n)

Visual



![Whiteboard](https://github.com/rynnnaa/data-structures-and-algorithms/blob/master/assets/FizzBuzzTree.jpg)
