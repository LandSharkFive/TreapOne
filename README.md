# Treap 

This project contains a Treap binary search tree (BST) demonstration.   The application inserts and deletes random numbers into a semi-balanced binary search tree.

## Install and Build

The is a C# Console-Mode Project.  Open with  Visual Studio 2022 and above to compile. 

## Description:

  A Treap is a semi-balanced binary search tree (BST).  The Tree class contains methods to Insert, Delete and Print keys.  Most operations (Insert, Delete and Search) are logarithmic in time, O(log N), except for print, which is linear time, O(N).  The Tree is Semi-Height-Balanced to a height of 1.4 Log(N).  On average, two rotations are possible for each insert or delete.

## Performance

Keys | Height | Time 
--- | --- | --- 
1K | 18 | 0.1 ms
10K | 31 | 2.4 ms
100K | 37 | 29 ms

## Unit Tests

Unit Tests are included.  Performance Tests are included (See Stop Watch).


## References

1. "Treap:  A Randomized Binary Search Tree", Dec 15, 2022, https://www.geeksforgeeks.org/treap-a-randomized-binary-search-tree/
2. "Implementation of Search, Insert and Delete in Treap", Nov 27, 2023, https://www.geeksforgeeks.org/implementation-of-search-insert-and-delete-in-treap/



  
