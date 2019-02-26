Challenge

Contributors:
Dez Teague, Ray Johnson, Andrew Hinojosa, Luther McKeiver

A graph represented as an adjacency list, including the following methods:

AddNode()
Adds a new node to the graph
Takes in the value of that node
Returns the added node

AddEdge()
Adds a new edge between two nodes in the graph
Include the ability to have a “weight”
Takes in the two nodes to be connected by the edge
Both nodes should already be in the Graph

GetNodes()
Returns all of the nodes in the graph as a collection (set, list, or similar)

GetNeighbors()
Returns a collection of nodes connected to the given node
Takes in a given node
Include the weight of the connection in the returned collection

Size()
Returns the total number of nodes in the graph

Approach & Efficiency
4 methods for this implementation.

Add() assigns an index to the the Node. T O(1) sp O(1)

Get() Searches through the list and returns a node. T O(n) sp O(n)

GetAll() Will return all nodes. T O(n) sp O(n)

Count() Returns number of nodes in graph. T O(1) sp O(n)
