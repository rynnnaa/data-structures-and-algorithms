# Get Edges.
Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? If so, how much will the total trip cost be?

# Challenge
Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.


# API
I used a queue to solve the problem. Enqueued the root node of the tree into the queue and set a variable called current to the front node of the queue, then dequeued the front and printed its value. Check to see if node matches city1, then checked if the on of the neighbors equals city2, if so return true and weight.  If not return false and 0.

Big O 
S O(n),
T O(v).

# Whiteboard
![Whiteboard](https://github.com/rynnnaa/data-structures-and-algorithms/blob/master/assets/get-edges.jpg)
