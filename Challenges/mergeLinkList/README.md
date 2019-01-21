Code Challenge 08
Developer: Ryna Truong

Contributor: Gwen, Jason Few
Merge Two Linked Lists

Actual Time to complete: 1 Hours White Board / 3 Hours Coding

Challenge
Write a Method called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

Approach & Efficiency
The approach taken was to create two linked lists as static methods and then merge them to return a zipped list.
Big O Time = O(n) - The method must first traverse the entire list to measure the length. Then merge the list to return a zipped list.

![Whiteboard](https://github.com/rynnnaa/data-structures-and-algorithms/blob/master/assets/ll_merge.jpg)
