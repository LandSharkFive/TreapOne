# Treap: Randomized Binary Search Tree

A C# implementation of a Treap—a hybrid data structure that maintains the properties of both a Binary Search Tree (BST) and a Heap. By assigning random priorities to nodes, the Treap ensures semi-balanced performance without complex rebalancing logic.



## 🚀 Overview
A Treap uses randomized priorities to maintain a semi-height-balanced structure ($2 \log n$ height). It uses simple rotations during insertion and deletion to preserve heap order.

* **Complexity:** Average $O(\log n)$ for Search, Insert, and Delete.
* **Space:** $O(n)$ space complexity.
* **Operations:** Supports duplicate keys and linear-time $O(n)$ printing.

## 🛠️ Build and Install
This is a C# Console-Mode Project.
1.  **Requirement:** Visual Studio 2022 or newer.
2.  **Setup:** Open the `.sln` file to compile and run.
3.  **Validation:** Includes Unit Tests and StopWatch-based Performance Tests.

## 📊 Performance Metrics
Results based on randomized integer keys:

| Keys | Height | Time |
| :--- | :--- | :--- |
| 1,000 | 18 | 0.1 ms |
| 10,000 | 31 | 2.4 ms |
| 100,000 | 37 | 29.0 ms |

---

## 📚 References
* [GeeksforGeeks: Treap (A Randomized Binary Search Tree)](https://www.geeksforgeeks.org/treap-a-randomized-binary-search-tree/)
* [GeeksforGeeks: Implementation of Search, Insert, and Delete](https://www.geeksforgeeks.org/implementation-of-search-insert-and-delete-in-treap/)


  
